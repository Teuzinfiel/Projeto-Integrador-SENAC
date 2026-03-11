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

namespace ProjetoIntegradorSENAC.Caixa
{
    public partial class Devolucoes : Form
    {

        public string CodigoDigitado { get; private set; }
        public Devolucoes()
        {
            InitializeComponent();
            this.AcceptButton = button1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                var opa = new caixaMensagem("Digite o código da venda.", "Falha ❌");
                opa.ShowDialog(); 
                return;
            }

            CodigoDigitado = textBox1.Text.Trim();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Devolucoes_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
    }
}
