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


            string query = $"SELECT id, email, senha FROM usuarios WHERE email = '{txtEmail.Text}'";
            DataTable usuario = Banco.Pesquisar(query);


            if (usuario.Rows.Count == 0)
            {
                MessageBox.Show("Usuário não encontrado!");
                return;
            }


            string senhaBanco = usuario.Rows[0]["senha"].ToString();
            int usuarioId = Convert.ToInt16(usuario.Rows[0]["id"]);

            if (txtSenha.Text == senhaBanco)
            {

                query = "Select from funcionarios where usuario_id = " + usuarioId;


                try
                {
                    DataTable funcionario = Banco.Pesquisar(query);
                    string cargo = funcionario.Rows[0]["cargo"].ToString();
                    if (cargo != "gerente")
                    {

                        int comercioID = Convert.ToInt16(funcionario.Rows[0]["comercio_id"]);
                        query = "Select dono_id from comercios where id = " + comercioID;
                        var comercio = Banco.Pesquisar(query);

                        int donoID = Convert.ToInt16(comercio.Rows[0]["dono_id"]);

                        MainPrincipal mainPrincipal = new MainPrincipal(comercioID, donoID, usuarioId);
                        mainPrincipal.Show();
                        this.Hide();
                    }
                    else
                    {
                        frmEmpresa frmEmpresa = new frmEmpresa(usuarioId);
                        frmEmpresa.idUsuario = usuarioId;
                        frmEmpresa.Show();
                        this.Hide();
                    }

                }
                catch(Exception)
                {
                    frmEmpresa frmEmpresa = new frmEmpresa(usuarioId);
                    frmEmpresa.idUsuario = usuarioId;
                    frmEmpresa.Show();
                    this.Hide();
                }
          
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

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
