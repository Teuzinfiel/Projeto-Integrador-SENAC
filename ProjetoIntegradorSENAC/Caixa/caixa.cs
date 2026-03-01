using MySql.Data.MySqlClient;
using ProjetoIntegradorSENAC.Classes;
using ProjetoIntegradorSENAC.LogInf;
using ProjetoIntegradorSENAC.Usuario;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Media;

namespace ProjetoIntegradorSENAC.Caixa
{
    public partial class caixa : Form
    {
        private Venda _vendaAtual = new Venda();
        private Dictionary<int, Panel> _painelPorProduto = new Dictionary<int, Panel>();
        int idEmpresa;
        int idUser;
        int idFunc;
        private string _codigoConsumidor;
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
        {
            int id = item.ProdutoId;

            Panel p = new Panel
            {
                Width = 170,
                Height = 200,
                BackColor = Color.FromArgb(35, 37, 50),
                Margin = new Padding(10),
                Tag = id
            };

            // 🔵 Cantos arredondados
            p.Paint += (s, e) =>
            {
                using (var path = RoundedRect(new Rectangle(0, 0, p.Width - 1, p.Height - 1), 15))
                {
                    p.Region = new Region(path);
                }
            };

            // Nome
            Label lblNome = new Label
            {
                Text = item.NomeProduto,
                ForeColor = Color.White,
                Font = new Font("Segoe UI Semibold", 9, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Width = p.Width,
                Height = 28,
                Location = new Point(0, 8)
            };

            // Quantidade
            Label lblQtd = new Label
            {
                Text = item.Quantidade.ToString(),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 13, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Width = 50,
                Height = 30,
                Location = new Point(60, 75),
                Tag = "qtd"
            };

            // 🔵 Preço Azul
            Label lblPreco = new Label
            {
                Text = $"{item.Total:C2}",
                ForeColor = Color.FromArgb(0, 150, 255),
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Width = p.Width,
                Height = 25,
                Location = new Point(0, 120),
                Tag = "preco"
            };

            Color azulSistema = Color.FromArgb(0, 150, 255);

            Button btnMais = CriarBotao("+", azulSistema);
            Button btnMenos = CriarBotao("-", azulSistema);
            Button btnCancel = CriarBotao("X", Color.FromArgb(220, 50, 50));

            btnMais.Location = new Point(20, 75);
            btnMenos.Location = new Point(120, 75);

            btnCancel.Size = new Size(24, 24);
            btnCancel.Location = new Point(p.Width - 30, 8);
            btnCancel.TextAlign = ContentAlignment.MiddleCenter;
            btnCancel.Padding = new Padding(0);

            // EVENTO +
            btnMais.Click += (s, e) =>
            {
                if (estoque <= item.Quantidade)
                {
                    MessageBox.Show("Estoque insuficiente");
                    return;
                }

                _vendaAtual.Incrementar(id);

                decimal desconto = 0;
                decimal.TryParse(textDesconto.Text, out desconto);
                _vendaAtual.AplicarDesconto(desconto, id);

                AtualizarPainel(p, item);
                AtualizarResumo();
            };

            // EVENTO -
            btnMenos.Click += (s, e) =>
            {
                _vendaAtual.DecrementarOuRemover(id);

                var existe = _vendaAtual.Itens.FirstOrDefault(i => i.ProdutoId == id);

                if (existe != null)
                {
                    AtualizarPainel(p, existe);
                }
                else
                {
                    flpCaixa.Controls.Remove(p);
                    _painelPorProduto.Remove(id);
                    p.Dispose();
                }

                AtualizarResumo();
            };

            // EVENTO X
            btnCancel.Click += (s, e) =>
            {
                _vendaAtual.Remover(id);

                flpCaixa.Controls.Remove(p);
                _painelPorProduto.Remove(id);
                p.Dispose();

                AtualizarResumo();
            };

            p.Controls.Add(lblNome);
            p.Controls.Add(lblQtd);
            p.Controls.Add(lblPreco);
            p.Controls.Add(btnMais);
            p.Controls.Add(btnMenos);
            p.Controls.Add(btnCancel);

            return p;
        }

        private void AtualizarResumo()
        {
            lbPreço.Text = (_vendaAtual?.TotalBruto ?? 0).ToString();
            lbItens.Text = (_vendaAtual?.Itens?.Count ?? 0).ToString();
        }

        private void AtualizarPainel(Panel panel, ItemVenda item)
        {
            if (panel == null || panel.IsDisposed || item == null)
                return;

            var lblQuant = panel.Controls
                .OfType<Label>()
                .FirstOrDefault(l => l.Tag?.ToString() == "qtd");

            if (lblQuant != null)
                lblQuant.Text = item.Quantidade.ToString();

            var lblPreco = panel.Controls
                .OfType<Label>()
                .FirstOrDefault(l => l.Tag?.ToString() == "preco");

            if (lblPreco != null)
                lblPreco.Text = $"{item.Total:C2}";
        }

        private Button CriarBotao(string texto, Color cor)
        {
            Button btn = new Button
            {
                Text = texto,
                Width = 30,
                Height = 30,
                FlatStyle = FlatStyle.Flat,
                BackColor = cor,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };

            btn.FlatAppearance.BorderSize = 0;

            // 🔵 Botão redondo
            btn.Paint += (s, e) =>
            {
                using (var path = new System.Drawing.Drawing2D.GraphicsPath())
                {
                    path.AddEllipse(0, 0, btn.Width - 1, btn.Height - 1);
                    btn.Region = new Region(path);
                }
            };

            return btn;
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

                        SoundPlayer player = new SoundPlayer(Properties.Resources.videoplayback);
                        player.Play();
                        MessageBox.Show("Venda finalizada com sucesso!");
                        LogService.CriarLog(this.idEmpresa, this.idUser, "Fez uma venda");
                        LimparVenda();
                        AbrirTelaImpressao(vendaId);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao salvar venda:\n" + ex.Message);
                    }
                }
            }

        }

        private void AbrirTelaImpressao(int vendaId)
        {
            using (var frm = new frmImprimirVenda(vendaId))
            {
                frm.ShowDialog(this);
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
                    this._codigoConsumidor = Guid.NewGuid().ToString("N");
                    cmd.Parameters.AddWithValue("@funcionario", idFunc);
                    cmd.Parameters.AddWithValue("@comercio", idEmpresa);
                    cmd.Parameters.AddWithValue("@total", _vendaAtual.TotalBruto);
                    cmd.Parameters.AddWithValue("@forma", _vendaAtual.FormaPagamento);
                    cmd.Parameters.AddWithValue("@descontos", _vendaAtual.Descontos);
                    cmd.Parameters.AddWithValue("@codigo_consumidor", this._codigoConsumidor);

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        private void SalvarItensVenda(int vendaId)
        {
            using (MySqlConnection conn = Banco.AbrirConexao())
            using (MySqlTransaction trans = conn.BeginTransaction())
            {
                try
                {
                    string sqlItem = @"
                INSERT INTO items_venda
                (produtos_id, quantidade, preco_unitario, vendas_id)
                VALUES
                (@produto, @quantidade, @preco, @venda);
            ";

                    foreach (var item in _vendaAtual.Itens)
                    {
                        // 🔹 Salva item da venda (SEU CÓDIGO ORIGINAL)
                        using (MySqlCommand cmd = new MySqlCommand(sqlItem, conn, trans))
                        {
                            cmd.Parameters.AddWithValue("@produto", item.ProdutoId);
                            cmd.Parameters.AddWithValue("@quantidade", item.Quantidade);
                            cmd.Parameters.AddWithValue("@preco", item.PrecoUnitario);
                            cmd.Parameters.AddWithValue("@venda", vendaId);
                            cmd.ExecuteNonQuery();
                        }

                        // 🔹 Atualiza estoque (NOVO - sem mexer no resto do sistema)
                        decimal atual = BuscarEstoqueAtual(item.ProdutoId, conn, trans);
                        decimal final = atual - item.Quantidade;

                        string sqlMov = @"
                    INSERT INTO movimentacoes_estoque
                    (produto_id, funcionario_id, comercio_id, tipo, quantidade, quantidade_final, motivo)
                    VALUES
                    (@produto, @funcionario, @comercio, 'saida', @quantidade, @final, 'VENDA');
                ";

                        using (MySqlCommand cmdMov = new MySqlCommand(sqlMov, conn, trans))
                        {
                            cmdMov.Parameters.AddWithValue("@produto", item.ProdutoId);
                            cmdMov.Parameters.AddWithValue("@funcionario", idFunc);
                            cmdMov.Parameters.AddWithValue("@comercio", idEmpresa);
                            cmdMov.Parameters.AddWithValue("@quantidade", item.Quantidade);
                            cmdMov.Parameters.AddWithValue("@final", final);
                            cmdMov.ExecuteNonQuery();
                        }
                    }

                    trans.Commit();
                }
                catch
                {
                    trans.Rollback();
                    throw;
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
                    LogService.CriarLog(this.idEmpresa, this.idUser, "Devoluiu uma venda");

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
    (produto_id, funcionario_id, comercio_id, tipo, quantidade, quantidade_final, motivo)
    VALUES
    (@produto, @funcionario, @comercio, 'entrada', @quantidade, @final, 'DEVOLUCAO_CLIENTE');
";

                        decimal atual = BuscarEstoqueAtual(item.produtoId, conn, trans);
                        decimal final = atual + item.quantidade;

                        using (MySqlCommand cmd = new MySqlCommand(sqlMov, conn, trans))
                        {
                            cmd.Parameters.AddWithValue("@produto", item.produtoId);
                            cmd.Parameters.AddWithValue("@funcionario", funcionarioId);
                            cmd.Parameters.AddWithValue("@comercio", idEmpresa);
                            cmd.Parameters.AddWithValue("@quantidade", item.quantidade);
                            cmd.Parameters.AddWithValue("@final", final);


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
                    RecarregarProdutos();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("Erro ao excluir venda:\n" + ex.Message);
                }
            }
        }
        private System.Drawing.Drawing2D.GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            var path = new System.Drawing.Drawing2D.GraphicsPath();

            path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);
            path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90);
            path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            return path;
        }
        private decimal BuscarEstoqueAtual(int produtoId, MySqlConnection conn, MySqlTransaction trans)
        {
            string sql = @"SELECT COALESCE((
        SELECT quantidade_final 
        FROM movimentacoes_estoque 
        WHERE produto_id = @id 
        ORDER BY id DESC 
        LIMIT 1
    ), 0)";

            using (var cmd = new MySqlCommand(sql, conn, trans))
            {
                cmd.Parameters.AddWithValue("@id", produtoId);
                return Convert.ToDecimal(cmd.ExecuteScalar());
            }
        }

        private void RecarregarProdutos()
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

        private void rightLayout_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
