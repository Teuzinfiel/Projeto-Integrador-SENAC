using ProjetoIntegradorSENAC.Logins;
using ProjetoIntegradorSENAC.personalizado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegradorSENAC
{
    public partial class codigo : Form
    {
        private int validacaoCodigo = 0;
        private string Email = "";
        public codigo(int codigo, string email)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ActiveControl = txtCodigo;
            this.validacaoCodigo = codigo;
            this.Email = email;
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void codigo_Load(object sender, EventArgs e)
        {
            panel1.Focus();
            lbEmail.Text = Email;
        }

        private void btnVerificarCodigo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                caixaMensagem mensagem = new caixaMensagem("insira o codigo primeiro", "Falha ❌");
                mensagem.Show();
                return;
            }
            if (Convert.ToInt32(txtCodigo.Text) == validacaoCodigo)
            {
                mudarSenha mudar = new mudarSenha(validacaoCodigo, Email);
                mudar.Show();
                this.Hide();
            }
            else
            {
                caixaMensagem mensagem = new caixaMensagem("codigo errado", "Falha ❌");
                mensagem.Show();
            }
        }

        private void btnVoltarParaLogin_Click(object sender, EventArgs e)
        {
            loginUsuario usuario = new loginUsuario();
            usuario.Show();
            this.Hide();
        }
    }
}
