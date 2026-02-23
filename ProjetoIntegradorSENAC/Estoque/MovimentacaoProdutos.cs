using ProjetoIntegradorSENAC.Empresa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegradorSENAC.Estoque
{
    public partial class MovimentacaoProdutos : Form
    {
        private int _idEmpresa;
        private int _produtoId;

        public MovimentacaoProdutos(int idEmpresa)
        {
            InitializeComponent();
            _idEmpresa = idEmpresa;
        }
        private void MovimentacaoProdutos_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.AutoScroll = true;
            //Permite quebrar linhas
            flowLayoutPanel1.WrapContents = true;
            //Permite ser da esquerda pra direita
            flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
            for (int i = 0; i < 20; i++)
            {
                AdicionarProdutoAoPanel("a", null, 1, 1, 1);
            };
        }

        private void AdicionarProdutoAoPanel(string nomeProduto, Image imagem, int id, int quant, int quantTotal)
        { // Painel do produto
            Panel p = new Panel();
            p.Width = 215;
            p.Height = 185;
            p.BackColor = Color.FromArgb(40, 40, 60);
            p.BorderStyle = BorderStyle.FixedSingle;
            p.Margin = new Padding(10);


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
            flowLayoutPanel1.Controls.Add(p);
        }
    }
}
