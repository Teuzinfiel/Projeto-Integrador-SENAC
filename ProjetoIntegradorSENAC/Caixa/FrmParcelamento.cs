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
    public partial class FrmParcelamento : Form
    {
        public int Parcelas { get; private set; }

        public FrmParcelamento()
        {
            InitializeComponent();

            numParcelas.Minimum = 1;
            numParcelas.Maximum = 12;
            numParcelas.Value = 1;
        }



        private void btnConfirmar_Click_1(object sender, EventArgs e)
        {
            Parcelas = (int)numParcelas.Value;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
