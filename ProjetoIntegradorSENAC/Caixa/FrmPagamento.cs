using System;
using System.Windows.Forms;

namespace ProjetoIntegradorSENAC.Caixa
{
    public partial class FrmPagamento : Form
    {
        public string FormaPagamentoSelecionada { get; private set; }

        public FrmPagamento()
        {
            InitializeComponent();
            
        }

        private void Selecionar(string forma)
        {
            FormaPagamentoSelecionada = forma;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            this.Selecionar("Pix");
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            this.Selecionar("Dinheiro");
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            this.Selecionar("Credito");
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            this.Selecionar("Débito");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
