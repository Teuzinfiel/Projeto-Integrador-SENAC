using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegradorSENAC.Produto
{
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();

        }

        public int CodigoProduto()
        {

            Random random = new Random();
            int codigo = random.Next(100000000, 999999999);


            return codigo;
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {

        }
    }
}
