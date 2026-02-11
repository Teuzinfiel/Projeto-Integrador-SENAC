using MySql.Data.MySqlClient;
using ProjetoIntegradorSENAC.Classes;
using ProjetoIntegradorSENAC.Usuario;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoIntegradorSENAC.Caixa
{
    public partial class caixa : Form
    {
        private Venda _vendaAtual = new Venda();
        private Dictionary<int, Panel> _painelPorProduto = new Dictionary<int, Panel>();
        int idEmpresa;
        int idUser;
        int idFunc;
        public caixa(int idEmpresa, int idUsuario)
        {
            InitializeComponent();
            this.idEmpresa = idEmpresa;
            this.idUser = idUsuario;

            BuscarFuncionario();
        }

        private void caixa_Load(object sender, EventArgs e)
        {
            string query = $@"
            SELECT 
                 p.id AS produto_id,
                  p.nome AS Produto,
                  p.preco AS Preco,
            COALESCE((
                 SELECT quantidade_final
                  FROM movimentacoes_estoque m
                   WHERE m.produto_id = p.id
               ORDER BY m.id DESC
                  LIMIT 1
               ), 0) AS estoque
            FROM produtos p
            WHERE p.comercio_id = {idEmpresa}
            ORDER BY p.nome ASC
            LIMIT 50;
            ";

            carregarProdutos(Banco.Pesquisar(query));
            dtgProdutos.AllowUserToResizeRows = false;

            flpCaixa.AutoScroll = true;
            flpCaixa.WrapContents = true;
            flpCaixa.FlowDirection = FlowDirection.LeftToRight;
        }

        private void carregarProdutos(DataTable db)
        {
            dtgProdutos.DataSource = null;
            dtgProdutos.Rows.Clear();
            dtgProdutos.Columns.Clear();
            dtgProdutos.DataSource = db;

            dtgProdutos.Columns["produto_id"].Visible = false;
            dtgProdutos.Columns["estoque"].Visible = false;

            if (dtgProdutos.Columns.Contains("produto_codigo"))
                dtgProdutos.Columns["produto_codigo"].Visible = false;

        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string pesquisa = (txtPesquisa.Text ?? "").Trim();


            string query = $@"
            SELECT 
                 p.id AS produto_id,
                 p.nome AS Produto,
                 p.preco AS Preco,
                 p.codigo_barra AS produto_codigo,
             COALESCE((
             SELECT quantidade_final
             FROM movimentacoes_estoque m
             WHERE m.produto_id = p.id
             ORDER BY m.id DESC
             LIMIT 1
             ), 0) AS estoque
            FROM produtos p
            WHERE p.comercio_id = {idEmpresa}
             AND (p.nome LIKE '%{pesquisa}%' 
             OR p.codigo_barra LIKE '%{pesquisa}%')
            ORDER BY p.nome ASC
            LIMIT 50;
            ";



            carregarProdutos(Banco.Pesquisar(query));

        }

        private void dtgProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dtgProdutos.Rows[e.RowIndex];

            int idProduto = Convert.ToInt32(row.Cells["produto_id"].Value);
            string nome = row.Cells["Produto"].Value.ToString() ?? "Produto";

            decimal preco = row.Cells["Preco"]?.Value != DBNull.Value
                ? Convert.ToDecimal(row.Cells["Preco"].Value)
                : 0m;

            int estoque = Convert.ToInt32(row.Cells["estoque"].Value);

            // 🔍 Verifica se já existe no carrinho
            var itemExistente = _vendaAtual.Itens.FirstOrDefault(i => i.ProdutoId == idProduto);

            int quantidadeAtual = itemExistente?.Quantidade ?? 0;

            // 🚫 Bloqueia antes de adicionar
            if (quantidadeAtual >= estoque)
            {
                MessageBox.Show("Estoque insuficiente");
                return;
            }

            // ✅ Agora sim pode adicionar
            _vendaAtual.AdicionarOuIncrimentar(idProduto, nome, preco);

            var item = _vendaAtual.Itens.First(i => i.ProdutoId == idProduto);

            decimal desconto = 0;
            decimal.TryParse(textDesconto.Text, out desconto);
            _vendaAtual.AplicarDesconto(desconto, idProduto);

            if (_painelPorProduto.TryGetValue(idProduto, out var painel))
            {
                AtualizarPainel(painel, item);
            }
            else
            {
                Panel novoP = CriarPainelProduto(null, item, estoque);
                flpCaixa.Controls.Add(novoP);
                _painelPorProduto[idProduto] = novoP;
                lbItens.Text = _vendaAtual.Itens.Count.ToString();
            }

            lbPreço.Text = _vendaAtual.TotalBruto.ToString();
        }


        private Panel CriarPainelProduto(Image imagem, ItemVenda item, int estoque)
        { // Painel do produto
            string nome = item.NomeProduto;
            int id = item.ProdutoId;

            Panel p = new Panel();
            p.Width = 170;
            p.Height = 250;
            p.BackColor = Color.FromArgb(40, 40, 60);
            p.BorderStyle = BorderStyle.FixedSingle;
            p.Margin = new Padding(10);
            p.Tag = id;


            // Nome do produto
            Label lblNome = new Label();
            lblNome.Text = nome;
            lblNome.ForeColor = Color.White;
            lblNome.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblNome.AutoSize = false;
            lblNome.TextAlign = ContentAlignment.MiddleCenter;
            lblNome.Width = p.Width;
            lblNome.Height = 25;
            lblNome.Location = new Point(0, 5);

            // PictureBox
            PictureBox pic = new PictureBox();
            pic.Width = 200;
            pic.Height = 140;
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.Image = imagem;
            pic.Location = new Point(15, 35);

            // Label de quantidade
            Label lblQtd = new Label();
            lblQtd.Text = item.Quantidade.ToString();
            lblQtd.ForeColor = Color.White;
            lblQtd.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblQtd.AutoSize = false;
            lblQtd.TextAlign = ContentAlignment.MiddleCenter;
            lblQtd.Width = 40;
            lblQtd.Height = 30;
            lblQtd.Location = new Point(70, 185);
            lblQtd.Tag = "qtd";
            lblQtd.Name = "labelQuant";

            // Label de preço total do produto
            Label lblPreco = new Label();
            lblPreco.Text = $"{item.Total:C2}";
            lblPreco.ForeColor = Color.White;
            lblPreco.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblPreco.AutoSize = false;
            lblPreco.TextAlign = ContentAlignment.MiddleCenter;
            lblPreco.Width = 120;
            lblPreco.Height = 30;
            lblPreco.Location = new Point(25, 210);
            lblPreco.Tag = "preco";
            lblPreco.Name = "labelPreco"
;
            Func<string, int, int, Button> btn = (texto, locx, locy) =>
            {
                return new Button()
                {
                    Text = texto,
                    Width = 40,
                    Height = 30,
                    Location = new Point(locx, locy),
                    BackColor = Color.FromArgb(70, 70, 100),
                    FlatStyle = FlatStyle.Flat,
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold)
                };
            };

            Button btnMais = btn("+", 20, 185);
            Button btnMenos = btn("-", 110, 185);
            Button btnCancel = btn("X", 130, 3);

            btnCancel.BackColor = Color.DarkRed;

            btnMais.Click += (s, e) =>
            {
                if (estoque <= item.Quantidade)
                {
                    MessageBox.Show("Estoque insuficiente");
                }
                else
                {
                    _vendaAtual.Incrementar(id);



                    // Aplica desconto se existir texto válido
                    decimal desconto = 0;
                    decimal.TryParse(textDesconto.Text, out desconto);
                    _vendaAtual.AplicarDesconto(desconto, id);

                    AtualizarPainel(p, item);
                    lbPreço.Text = _vendaAtual.TotalBruto.ToString();
                }
            };

            btnCancel.Click += (s, e) =>
            {

                _vendaAtual.Remover(id);
                flpCaixa.Controls.Remove(p);
                _painelPorProduto.Remove(id);
                p.Dispose();
                lbPreço.Text = _vendaAtual.TotalBruto.ToString();
                lbItens.Text = _vendaAtual.Itens.Count.ToString();
            };

            btnMenos.Click += (s, e) =>
            {
                _vendaAtual.DecrementarOuRemover(id);

                if (_vendaAtual.Itens.FirstOrDefault(i => i.ProdutoId == id) != null)
                {
                    decimal desconto = 0;
                    decimal.TryParse(textDesconto.Text, out desconto);
                    _vendaAtual.AplicarDesconto(desconto, id);
                    AtualizarPainel(p, item);
                    lbPreço.Text = _vendaAtual.TotalBruto.ToString();
                }
                else
                {
                    flpCaixa.Controls.Remove(p);
                    _painelPorProduto.Remove(id);
                    p.Dispose();
                    lbPreço.Text = _vendaAtual.TotalBruto.ToString();
                    lbItens.Text = _vendaAtual.Itens.Count.ToString();
                }
            };


            p.Controls.Add(lblNome);
            p.Controls.Add(pic);
            p.Controls.Add(lblQtd);
            p.Controls.Add(btnMais);
            p.Controls.Add(btnMenos);
            p.Controls.Add(btnCancel);
            p.Controls.Add(lblPreco);

            btnCancel.BringToFront();


            return p;
        }

        private void AtualizarPainel(Panel panel, ItemVenda item)
        {
            var lblQuant = panel.Controls.OfType<Label>().FirstOrDefault(l => l.Tag?.ToString() == "qtd");

            lblQuant.Text = null;
            lblQuant.Text = item.Quantidade.ToString();


            var lblPreco = panel.Controls.OfType<Label>().FirstOrDefault(l => l.Tag?.ToString() == "preco");

            lblPreco.Text = null;
            lblPreco.Text = $"{item.Total:C2}";



        }

        private void textDesconto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (ItemVenda item in _vendaAtual.Itens)
                {
                    decimal desconto = 0;
                    decimal.TryParse(textDesconto.Text, out desconto);
                    int idProduto = item.ProdutoId;

                    if (_painelPorProduto.TryGetValue(idProduto, out var painel))
                    {
                        _vendaAtual.AplicarDesconto(desconto, idProduto);
                        AtualizarPainel(painel, item);
                        lbPreço.Text = _vendaAtual.TotalBruto.ToString();
                    }
                    ;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selecione um Desconto entre 0 a 99");
                textDesconto.Text = "0";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (_vendaAtual.EstaVazia()) return;

            var resp = MessageBox.Show(
                "Deseja cancelar a venda?",
                "Cancelar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resp == DialogResult.Yes)
                LimparVenda();

        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            if (_vendaAtual.EstaVazia())
            {
                MessageBox.Show("Não há itens na venda.");
                return;
            }

            using (var frm = new FrmPagamento())
            {
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    try
                    {
                        _vendaAtual.FormaPagamento = frm.FormaPagamentoSelecionada;

                        int vendaId = SalvarVenda();
                        SalvarItensVenda(vendaId);

                        MessageBox.Show("Venda finalizada com sucesso!");
                        LimparVenda();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao salvar venda:\n" + ex.Message);
                    }
                }
            }

        }

        private void LimparVenda()
        {
            _vendaAtual = new Venda();
            _painelPorProduto.Clear();

            flpCaixa.Controls.Clear();

            lbPreço.Text = "0,00";
            lbItens.Text = "0";
            textDesconto.Text = "0";
        }
        private int SalvarVenda()
        {
            using (MySqlConnection conn = Banco.AbrirConexao())
            {
                string sql = @"
            INSERT INTO vendas
            (funcionario_id, comercio_id, total, forma_pagamento, descontos, codigo_consumidor)
            VALUES
            (@funcionario, @comercio, @total, @forma, @descontos, @codigo_consumidor);
            SELECT LAST_INSERT_ID();
        ";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    string codigo = Guid.NewGuid().ToString("N");
                    cmd.Parameters.AddWithValue("@funcionario", idFunc);
                    cmd.Parameters.AddWithValue("@comercio", idEmpresa);
                    cmd.Parameters.AddWithValue("@total", _vendaAtual.TotalBruto);
                    cmd.Parameters.AddWithValue("@forma", _vendaAtual.FormaPagamento);
                    cmd.Parameters.AddWithValue("@descontos", _vendaAtual.Descontos);
                    cmd.Parameters.AddWithValue("@codigo_consumidor", codigo);

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        private void SalvarItensVenda(int vendaId)
        {
            using (MySqlConnection conn = Banco.AbrirConexao())
            {
                string sql = @"
            INSERT INTO items_venda
            (produtos_id, quantidade, preco_unitario, vendas_id)
            VALUES
            (@produto, @quantidade, @preco, @venda);
        ";

                foreach (var item in _vendaAtual.Itens)
                {
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@produto", item.ProdutoId);
                        cmd.Parameters.AddWithValue("@quantidade", item.Quantidade);
                        cmd.Parameters.AddWithValue("@preco", item.PrecoUnitario);
                        cmd.Parameters.AddWithValue("@venda", vendaId);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        private void BuscarFuncionario()
        {
            using (MySqlConnection conn = Banco.AbrirConexao())
            {
                string sql = @"
            SELECT id 
            FROM funcionarios 
            WHERE usuarios_id = @usuario 
            AND comercio_id = @comercio
            LIMIT 1;
        ";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@usuario", idUser);
                    cmd.Parameters.AddWithValue("@comercio", idEmpresa);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                        idFunc = Convert.ToInt32(result);
                    else
                        MessageBox.Show("Funcionário não encontrado para este usuário.");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Devolucoes frm = new Devolucoes())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    ExcluirVendaPorCodigo(frm.CodigoDigitado);
                }
            }
        }

        private void ExcluirVendaPorCodigo(string codigo)
        {
            using (MySqlConnection conn = Banco.AbrirConexao())
            using (MySqlTransaction trans = conn.BeginTransaction())
            {
                try
                {
                    // 🔎 Buscar venda
                    string sqlVenda = @"
                SELECT id, funcionario_id
                FROM vendas
                WHERE codigo_consumidor = @codigo
                LIMIT 1;
            ";

                    int vendaId;
                    int funcionarioId;

                    using (MySqlCommand cmd = new MySqlCommand(sqlVenda, conn, trans))
                    {
                        cmd.Parameters.AddWithValue("@codigo", codigo);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (!reader.Read())
                                throw new Exception("Venda não encontrada.");

                            vendaId = reader.GetInt32("id");
                            funcionarioId = reader.IsDBNull(reader.GetOrdinal("funcionario_id"))
                                ? 0
                                : reader.GetInt32("funcionario_id");
                        }
                    }

                    // 🔎 Buscar itens da venda
                    var itens = new List<(int produtoId, int quantidade)>();

                    string sqlItens = @"
                SELECT produtos_id, quantidade
                FROM items_venda
                WHERE vendas_id = @venda;
            ";

                    using (MySqlCommand cmd = new MySqlCommand(sqlItens, conn, trans))
                    {
                        cmd.Parameters.AddWithValue("@venda", vendaId);

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                itens.Add((
                                    reader.GetInt32("produtos_id"),
                                    reader.GetInt32("quantidade")
                                ));
                            }
                        }
                    }

                    // 🔁 Devolver estoque
                    foreach (var item in itens)
                    {
                        string sqlMov = @"
                    INSERT INTO movimentacoes_estoque
                    (produto_id, funcionario_id, comercio_id, tipo, quantidade)
                    VALUES
                    (@produto, @funcionario, @comercio, 'entrada', @quantidade);
                ";

                        using (MySqlCommand cmd = new MySqlCommand(sqlMov, conn, trans))
                        {
                            cmd.Parameters.AddWithValue("@produto", item.produtoId);
                            cmd.Parameters.AddWithValue("@funcionario", funcionarioId);
                            cmd.Parameters.AddWithValue("@comercio", idEmpresa);
                            cmd.Parameters.AddWithValue("@quantidade", item.quantidade);

                            cmd.ExecuteNonQuery();
                        }
                    }

                    // ❌ Excluir itens
                    using (MySqlCommand cmd = new MySqlCommand(
                        "DELETE FROM items_venda WHERE vendas_id = @venda",
                        conn, trans))
                    {
                        cmd.Parameters.AddWithValue("@venda", vendaId);
                        cmd.ExecuteNonQuery();
                    }

                    // ❌ Excluir venda
                    using (MySqlCommand cmd = new MySqlCommand(
                        "DELETE FROM vendas WHERE id = @venda",
                        conn, trans))
                    {
                        cmd.Parameters.AddWithValue("@venda", vendaId);
                        cmd.ExecuteNonQuery();
                    }

                    trans.Commit();

                    MessageBox.Show("Venda excluída e estoque devolvido com sucesso!");
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("Erro ao excluir venda:\n" + ex.Message);
                }
            }
        }

    }
}
