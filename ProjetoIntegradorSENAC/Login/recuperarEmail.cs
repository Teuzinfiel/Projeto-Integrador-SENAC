using ProjetoIntegradorSENAC.Logins;
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
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            loginUsuario usuario = new loginUsuario();
            usuario.Show();
            this.Hide();
        }

        private void recuperarEmail_Load(object sender, EventArgs e)
        {
            panel1.Focus();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Informe um email válido.");
                return;
            }
            try
            {
                Random random = new Random();
                codigoVal = random.Next(100000, 999999);
                using (SmtpClient smtp = new SmtpClient())
                {
                    using (MailMessage email = new MailMessage())
                    {
                        smtp.Host = "smtp.gmail.com";
                        smtp.Port = 587;
                        smtp.EnableSsl = true;
                        smtp.UseDefaultCredentials = false;
                        smtp.Credentials = new System.Net.NetworkCredential("gustavorb1341@gmail.com", "ttznihendehmibjp");

                        email.From = new MailAddress("gustavorb1341@gmail.com");
                        email.To.Add(txtEmail.Text);

                        email.Subject = "codigo de validação";
                        email.IsBodyHtml = false;
                        email.Body = codigoVal.ToString();

                        smtp.Send(email);
                    }
                }
                codigo codigo = new codigo(codigoVal);
                codigo.Show();
                this.Hide();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);

            }
        }
    }
}
