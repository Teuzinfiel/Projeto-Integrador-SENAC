using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegradorSENAC.Dashboard
{
    public partial class dashboardEstoque : Form
    {
        private MainEmpresa _main; // referência ao form pai
        private int idEmpresa;
        private Dictionary<string, object> param_idEmpresa;
        public dashboardEstoque(MainEmpresa main, int idEmpresa)
        {
            InitializeComponent();
            _main = main;
            this.idEmpresa = idEmpresa;
            param_idEmpresa = new Dictionary<string, object>()
            {
                { "@idEmpresa", idEmpresa }
            };
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            _main.AbrirFormNoPanel(new dashboardProduto(_main, idEmpresa));
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            _main.AbrirFormNoPanel(new dashboardVenda(_main, idEmpresa));
        }

        private void btnComparacao_Click(object sender, EventArgs e)
        {
            _main.AbrirFormNoPanel(new dashboardComparacao(_main, idEmpresa));
        }

        private void dashboardEstoque_Load(object sender, EventArgs e)
        {
            lbTempo.Text = "Dados atualizados em: " + DateTime.Now;
            CarregarPag();

        }
        private void CarregarPag()
        {
            func_dashboard.carregarInfoEstoque(lbDash1, lbDash2, lbDash3, lbDash4, param_idEmpresa);
            func_dashboard.load_grafico_estoque(grafico1, grafico2, param_idEmpresa, lbTituloGrafico1, lbTituloGrafico2);
            func_dashboard.EstilizarGrafico(grafico1, grafico2);
        }

        private void dashboardEstoque_Shown(object sender, EventArgs e)
        {
            CarregarPag();
        }
    }
}
