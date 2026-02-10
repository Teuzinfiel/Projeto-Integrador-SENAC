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


        private void btnDinheiro_Click_1(object sender, EventArgs e)
        {
            this.Selecionar("Dinheiro");
        }

        private void btnCredito_Click_1(object sender, EventArgs e)
        {
             this.Selecionar("Credito");
        }

        private void btnDebito_Click_1(object sender, EventArgs e)
        {
             this.Selecionar("Débito");
        }

        private void btnPix_Click_1(object sender, EventArgs e)
        {
            this.Selecionar("Pix");
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
