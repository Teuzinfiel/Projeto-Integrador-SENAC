using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoIntegradorSENAC.Classes;
using ProjetoIntegradorSENAC.Empresa;
using ProjetoIntegradorSENAC.Usuario;

namespace ProjetoIntegradorSENAC.Logins
{
    public partial class loginUsuario : Form
    {
        public loginUsuario()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string query = $"select nome, senha from usuarios where nome = '{txtNome.Text}'";

            var usuario = Banco.Pesquisar(query);

            string senha = usuario.Rows[0]["senha"].ToString();

            if (txtSenha.Text == senha)
            {

                frmEmpresa frmEmpresa = new frmEmpresa();
                frmEmpresa.Show();
                this.Hide();
            }
            else MessageBox.Show("senha incorreta camarada");

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void chkMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrarSenha.Checked)
            {
                txtSenha.UseSystemPasswordChar = false; // Mostra a senha
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;  // Esconde a senha
            }
        }

        private void CriarConta_Click(object sender, EventArgs e)
        {
            cadUsuario cadastrar = new cadUsuario();
            cadastrar.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            cadUsuario cadastrar = new cadUsuario();
            cadastrar.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmEmpresa frmEmpresa = new frmEmpresa();
            frmEmpresa.Show();
            this.Hide();

        }
    }
}
