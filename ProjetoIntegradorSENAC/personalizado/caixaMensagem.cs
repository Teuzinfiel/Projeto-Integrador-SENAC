using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegradorSENAC.personalizado
{
    public partial class caixaMensagem : Form
    {
        private string Mensagem;
        private string Titulo;
        public caixaMensagem(string mensagem, string titulo)
        {
            InitializeComponent();
            Mensagem = mensagem;
            Titulo = titulo;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void caixaMensagem_Load(object sender, EventArgs e)
        {
            lbMensagem.Text = Mensagem;
            lbTitulo.Text = Titulo;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
