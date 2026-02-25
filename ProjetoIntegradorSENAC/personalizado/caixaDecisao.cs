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
    public partial class caixaDecisao : Form
    {
        public bool decisao;

        private string Mensagem;
        private string Titulo;
        public caixaDecisao(string mensagem, string titulo)
        {
            InitializeComponent();
            Mensagem = mensagem;
            Titulo = titulo;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void BtnSim_Click(object sender, EventArgs e)
        {
            decisao = true;
            this.Close();

        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            decisao = false;
            this.Close();
        }

        private void Escolha_Load(object sender, EventArgs e)
        {
            lbMensagem.Text = Mensagem;
            lbTitulo.Text = Titulo;
        }
    }
}
