using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoIntegradorSENAC.Caixa;
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

        
            string query = $"SELECT id, nome, senha FROM usuarios WHERE nome = '{txtNome.Text}'";
            DataTable usuario = Banco.Pesquisar(query);

          
            if (usuario.Rows.Count == 0)
            {
                MessageBox.Show("Usuário não encontrado!");
                return;
            }

         
            string senhaBanco = usuario.Rows[0]["senha"].ToString();
            int idUser = Convert.ToInt16(usuario.Rows[0]["id"]);

            if (txtSenha.Text == senhaBanco)
            {
                frmEmpresa frmEmpresa = new frmEmpresa(idUser);
                frmEmpresa.idUsuario = idUser;
                frmEmpresa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Senha incorreta!");
            }
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

        private void btnLogin_Click1(object sender, EventArgs e)
        {

            cadUsuario cadastrar = new cadUsuario();
            cadastrar.Show();
            this.Hide();
        }

    }
}
