using ProjetoIntegradorSENAC.Empresa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegradorSENAC.Estoque
{
    public partial class MovimentacaoProdutos : Form
    {
        private int _idEmpresa;
        private int _produtoId;

        public MovimentacaoProdutos(int idEmpresa)
        {
            InitializeComponent();
            _idEmpresa = idEmpresa;
        }
        private void MovimentacaoProdutos_Load(object sender, EventArgs e)
        {
         
        }

        private void AdicionarProdutoAoPanel(string nomeProduto, Image imagem, int id, int quant, int quantTotal)
        {
        
        }
    }
}
