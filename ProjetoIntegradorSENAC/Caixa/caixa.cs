using ProjetoIntegradorSENAC.Classes;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace ProjetoIntegradorSENAC.Caixa
{
    public partial class caixa : Form
    {
        private Venda _vendaAtual = new Venda();
        private Dictionary<int, Panel> _painelPorProduto = new Dictionary<int, Panel>();
        int idEmpresa;
        public caixa(int idEmpresa)
        {
            InitializeComponent();
            this.idEmpresa = idEmpresa;
        }

        private void caixa_Load(object sender, EventArgs e)
        {
            string query = @"SELECT p.id AS produto_id,
                            p.nome AS Produto,
                            p.preco AS Preco,
                            COALESCE((SELECT quantidade_final
                            FROM movimentacoes_estoque m
                            WHERE m.produto_id = p.id
                            ORDER BY m.id DESC
                            LIMIT 1), 0) AS estoque
                            FROM produtos p
                            ORDER BY p.nome ASC
                            limit 50"; ;

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


            string query = $@"SELECT p.id AS produto_id,
                            p.nome AS Produto,
                            p.preco AS Preco,
                            p.codigo_barra AS produto_codigo,
                            COALESCE((SELECT quantidade_final
                            FROM movimentacoes_estoque m
                            WHERE m.produto_id = p.id
                            ORDER BY m.id DESC
                            LIMIT 1), 0) AS estoque 
                            FROM produtos p where p.nome Like '%{pesquisa}%' Or p.codigo_barra LIKE '%{pesquisa}%'
                            ORDER BY p.nome ASC
                            limit 50;";


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

            _vendaAtual.AdicionarOuIncrimentar(idProduto, nome, preco);
            var item = _vendaAtual.Itens.FirstOrDefault(i => i.ProdutoId == idProduto);
            decimal desconto = 0m;
            decimal.TryParse(textDesconto.Text, out desconto);

            if (_painelPorProduto.TryGetValue(idProduto, out var painel))
            {


                if (estoque <= item.Quantidade)
                {
                    AtualizarPainel(painel, item);
                    lbPreço.Text = _vendaAtual.TotalBruto.ToString();
                    MessageBox.Show("Estoque insuficiente");
                }
                else
                {
                    _vendaAtual.AplicarDesconto(desconto, idProduto);
                    AtualizarPainel(painel, item);
                    lbPreço.Text = _vendaAtual.TotalBruto.ToString();
                }

            }
            else
            {
                _vendaAtual.AplicarDesconto(desconto, idProduto);
                Panel novoP = CriarPainelProduto(null, item, estoque);
                flpCaixa.Controls.Add(novoP);
                _painelPorProduto[idProduto] = novoP;
                lbPreço.Text = _vendaAtual.TotalBruto.ToString();
                lbItens.Text = _vendaAtual.Itens.Count.ToString();
            }
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

  
    }
}
