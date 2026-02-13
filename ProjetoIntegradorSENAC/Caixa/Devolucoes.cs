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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Digite o código da venda.");
                return;
            }

            CodigoDigitado = textBox1.Text.Trim();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
