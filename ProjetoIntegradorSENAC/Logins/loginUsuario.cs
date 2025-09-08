using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoIntegradorSENAC.Empresa;

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
            frmEmpresa frmEmpresa = new frmEmpresa();
            frmEmpresa.Show();
            this.Hide();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        //bagui de mostra senha
        private void label4_Click(object sender, EventArgs e)
        {
            if (txtSenha.UseSystemPasswordChar == true)
            {
                txtSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
            }
        }
    }
}
