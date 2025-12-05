using ProjetoIntegradorSENAC.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegradorSENAC.Caixa
{
    public partial class caixa : Form
    {
        public caixa()
        {
            InitializeComponent();
        }

        private void caixa_Load(object sender, EventArgs e)
        {
            string query = $"select id,nome from produtos limit 50";
            var produtos = Banco.Pesquisar(query);
            dtgProdutos.DataSource = produtos;
            flpCaixa.AutoScroll = true;
            //Permite quebrar linhas
            flpCaixa.WrapContents = true;
            //Permite ser da esquerda pra direita
            flpCaixa.FlowDirection = FlowDirection.LeftToRight;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string pesquisa = txtPesquisa.Text;

            dtgProdutos.DataSource = null;
            dtgProdutos.Rows.Clear();


            string query = $"SELECT id, nome FROM produtos WHERE nome LIKE '%{pesquisa}%' or codigo_barra like '%{pesquisa}%'";
            var produtos = Banco.Pesquisar(query);
            dtgProdutos.DataSource = produtos;
        }

        private void dtgProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            { // Pega o nome do produto (exemplo)
                string nome = dtgProdutos.Rows[e.RowIndex].Cells["nome"].Value.ToString();
                // Imagem padrão (pode carregar do banco) // ou null
                int id = Convert.ToInt32(dtgProdutos.Rows[e.RowIndex].Cells["id"].Value);
                bool veri = false;

                if (flpCaixa.Controls.OfType<Panel>().Any())
                {
                    foreach (Panel p in flpCaixa.Controls.OfType<Panel>())
                    {
                        if (Convert.ToInt32(p.Tag) == id)
                        {
                            int quantidade = int.Parse(p.Controls["labelQuant"].Text);
                            p.Controls["labelQuant"].Text = (quantidade + 1).ToString();
                            veri = true;
                            break;
                        }


                    }
                }
                else if (!flpCaixa.Controls.OfType<Panel>().Any())
                {
                    AdicionarProdutoAoPanel(nome, null, id);
                    veri = true;
                }
                if (!veri)
                {
                    AdicionarProdutoAoPanel(nome, null, id);
                }
            }
        }

        private void AdicionarProdutoAoPanel(string nomeProduto, Image imagem, int id)
        { // Painel do produto
            Panel p = new Panel();
            p.Width = 170;
            p.Height = 240;
            p.BackColor = Color.FromArgb(40, 40, 60);
            p.BorderStyle = BorderStyle.FixedSingle;
            p.Margin = new Padding(10);
            p.Tag = id;

            // Nome do produto
            Label lblNome = new Label();
            lblNome.Text = nomeProduto;
            lblNome.ForeColor = Color.White;
            lblNome.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblNome.AutoSize = false;
            lblNome.TextAlign = ContentAlignment.MiddleCenter;
            lblNome.Width = p.Width;
            lblNome.Height = 25;
            lblNome.Location = new Point(0, 5);

            // PictureBox
            PictureBox pic = new PictureBox();
            pic.Width = 140;
            pic.Height = 140;
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.Image = imagem;
            pic.Location = new Point(15, 35);

            // Label de quantidade
            Label lblQtd = new Label();
            lblQtd.Text = "1";
            lblQtd.ForeColor = Color.White;
            lblQtd.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblQtd.AutoSize = false;
            lblQtd.TextAlign = ContentAlignment.MiddleCenter;
            lblQtd.Width = 40;
            lblQtd.Height = 30;
            lblQtd.Location = new Point(65, 185);
            lblQtd.Tag = "qtd";
            lblQtd.Name = "labelQuant"
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




            p.Controls.Add(lblNome);
            p.Controls.Add(pic);
            p.Controls.Add(lblQtd);
            p.Controls.Add(btnMais);
            p.Controls.Add(btnMenos);
            p.Controls.Add(btnCancel);

            btnCancel.BringToFront();
            flpCaixa.Controls.Add(p);

            btnMais.Click += (s, e) =>
            {
                string query = $"SELECT id, nome FROM produtos WHERE nome LIKE '%{pesquisa}%' or codigo_barra like '%{pesquisa}%'";
                var produtos = Banco.Pesquisar(query);

                int q = int.Parse(lblQtd.Text);
                lblQtd.Text = (q + 1).ToString();
            };

            btnMenos.Click += (s, e) =>
            {
                int q = int.Parse(lblQtd.Text);
                if (q > 1) lblQtd.Text = (q - 1).ToString();
            };

            btnCancel.Click += (s, e) =>
            {
                flpCaixa.Controls.Remove(p);
                p.Dispose();
            };
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            flpCaixa.Controls.Clear();
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {

        }
    }
}

