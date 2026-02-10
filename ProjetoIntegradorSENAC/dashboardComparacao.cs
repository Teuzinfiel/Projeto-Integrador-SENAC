using ProjetoIntegradorSENAC.Dashboard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegradorSENAC
{
    public partial class dashboardComparacao : Form
    {
        private int idEmpresa;
        private Dictionary<string, object> param_idEmpresa;
        public dashboardComparacao(int idEmpresa)
        {
            InitializeComponent();
            this.idEmpresa = idEmpresa;
            param_idEmpresa = new Dictionary<string, object>()
            {
                { "@idEmpresa", idEmpresa }
            };
        }

        private void dashboardComparacao_Load(object sender, EventArgs e)
        {

           /* func_dashboard.carregarInfoComparacao(lbDash1, lbDash2, lbDash3, lbDash4, Info1_dash,
            Info2_dash, Info3_dash, Info4_dash, param_idEmpresa);
            func_dashboard.load_grafico_comparacao(grafico1, grafico2, param_idEmpresa, lblProximo, lblLonge);*/

        }
    }
}
