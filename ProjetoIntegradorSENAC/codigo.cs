using ProjetoIntegradorSENAC.Logins;
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
        public codigo(int codigo)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.validacaoCodigo = codigo;
        }
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

        private void codigo_Load(object sender, EventArgs e)
        {
            panel1.Focus();
        }

        private void btnVerificarCodigo_Click(object sender, EventArgs e)
        {
            if (validacaoCodigo == 0)
            {
                MessageBox.Show("insira o codigo primeiro");
                return; 
            }
            if (Convert.ToInt32(txtCodigo) == validacaoCodigo)
            {
                MessageBox.Show("certinho");

            }
            else
            {
                MessageBox.Show("codigo errado");
            
            }
        }
    }
}
