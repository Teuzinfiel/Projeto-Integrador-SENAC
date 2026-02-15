using ProjetoIntegradorSENAC.Classes;
using ProjetoIntegradorSENAC.Logins;
using ProjetoIntegradorSENAC.personalizado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoIntegradorSENAC
{
    public partial class recuperarEmail : Form
    {
        public recuperarEmail()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        int codigoVal = 0;
        float angulo = 0;

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bntVoltar_Click(object sender, EventArgs e)
        {
            loginUsuario usuario = new loginUsuario();
            usuario.Show();
            this.Hide();
        }

        private void recuperarEmail_Load(object sender, EventArgs e)
        {
            panel1.Focus();
            Funcoes.AtivarMovimentoPanel(this, panelTop);
        }

        private async void btnCadastro_Click(object sender, EventArgs e)
        {
            if (!Funcoes.isEmail(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                caixaMensagem mensagem =
                    new caixaMensagem("Email inválido", "Falha ❌");

                mensagem.Show();
                return;
            }

            string verificarEmail =
                $"SELECT * FROM usuarios WHERE email = '{txtEmail.Text}' ";

            var data = Banco.Pesquisar(verificarEmail);

            if (data.Rows.Count <= 0)
            {
                caixaMensagem mensagem =
                    new caixaMensagem("Esse e-mail não está cadastrado", "Falha ❌");

                mensagem.Show();
                return;
            }

            try
            {
                MostrarLoading(); 

                Random random = new Random();
                codigoVal = random.Next(100000, 999999);

                await EnviarEmailAsync(txtEmail.Text, codigoVal);

                EsconderLoading(); 

                codigo codigo = new codigo(codigoVal, txtEmail.Text);
                codigo.Show();

                this.Hide();
            }
            catch (Exception ex)
            {
                EsconderLoading();

                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void GirarImagem()
        {
            angulo += 10f;

            if (angulo >= 360)
                angulo = 0;

            Bitmap bmp = new Bitmap(Properties.Resources.spinner);

            Bitmap bmpRotacionado = new Bitmap(bmp.Width, bmp.Height);

            using (Graphics g = Graphics.FromImage(bmpRotacionado))
            {
                g.TranslateTransform(bmp.Width / 2, bmp.Height / 2);
                g.RotateTransform(angulo);
                g.TranslateTransform(-bmp.Width / 2, -bmp.Height / 2);

                g.DrawImage(bmp, new Point(0, 0));
            }

            picLoading.Image = bmpRotacionado;
        }

        private void timerLoading_Tick(object sender, EventArgs e)
        {
            GirarImagem();
        }
        private void MostrarLoading()
        {
            lblCarregando.Visible = true;
            picLoading.Visible = true;
            timerLoading.Start();
        }

        private void EsconderLoading()
        {
            timerLoading.Stop();
            lblCarregando.Visible = false;
            picLoading.Visible = false;
        }
        private async Task EnviarEmailAsync(string destino, int codigo)
        {
            await Task.Run(() =>
            {
                string corpoEmail = $@"
                <html>
                <body>
                    <h2>Recuperação de Senha</h2>
                    <p>Seu código é:</p>
                    <h1>{codigo}</h1>
                </body>
                </html>";

                using (SmtpClient smtp = new SmtpClient())
                {
                    using (MailMessage email = new MailMessage())
                    {
                        smtp.Host = "smtp.gmail.com";
                        smtp.Port = 587;
                        smtp.EnableSsl = true;

                        smtp.Credentials =
                            new System.Net.NetworkCredential(
                                "gustavorb1341@gmail.com",
                                "ttznihendehmibjp"
                            );

                        email.From =
                            new MailAddress("gustavorb1341@gmail.com");

                        email.To.Add(destino);

                        email.Subject = "Código de Validação";

                        email.Body = corpoEmail;
                        email.IsBodyHtml = true;

                        smtp.Send(email);
                    }
                }
            });
        }


    }
}
