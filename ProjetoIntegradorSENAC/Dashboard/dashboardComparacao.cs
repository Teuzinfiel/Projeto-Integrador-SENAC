using ProjetoIntegradorSENAC.Dashboard;
using ProjetoIntegradorSENAC.personalizado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegradorSENAC
{
    public partial class dashboardComparacao : Form
    {
        private MainPrincipal _main;
        private int idEmpresa;
        private Dictionary<string, object> param_idEmpresa;
        private bool produtosBoo = false;
        private bool vendasBoo = true;

        public dashboardComparacao(MainPrincipal main, int idEmpresa)
        {
            InitializeComponent();
            this.idEmpresa = idEmpresa;
            this._main = main;
            param_idEmpresa = new Dictionary<string, object>()
            {
                { "@idEmpresa", idEmpresa }
            };
        }

        private void dashboardComparacao_Load(object sender, EventArgs e)
        {
            maskedInicio1Periodo.Text = DateTime.Now.AddMonths(-1).ToString("dd/MM/yyyy");
            maskedFim1Periodo.Text = DateTime.Now.ToString("dd/MM/yyyy");
            maskedInicio2Periodo.Text = DateTime.Now.AddMonths(-2).ToString("dd/MM/yyyy");
            maskedFim2Periodo.Text = DateTime.Now.AddMonths(-1).ToString("dd/MM/yyyy");
            if (!func_dashboard.AtualizarPeriodoComparacao(maskedInicio1Periodo, maskedFim1Periodo, maskedInicio2Periodo, maskedFim2Periodo, param_idEmpresa))
            { 
                caixaMensagem info = new caixaMensagem("As datas estão incorreta ou na posição" +
                    "\nerrada!!!", "Falha ❌");
                info.ShowDialog();
                return;
            }
            func_dashboard.carregarInfoComparacao(lbDash1, lbDash2, lbDash3, lbDash4, Info1_dash,
            Info2_dash, Info3_dash, Info4_dash, param_idEmpresa,lbTituloDash);
            func_dashboard.load_grafico_comparacao(grafico1, grafico2, param_idEmpresa, lblProximo, lblLonge);

        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            produtosBoo = false;
            vendasBoo = true;
            _main.AbrirFormNoPanel(new dashboard(_main, idEmpresa, vendasBoo));
        }
        private void btnProdutos_Click(object sender, EventArgs e)
        {
            produtosBoo = true;
            vendasBoo = false;
            _main.AbrirFormNoPanel(new dashboard(_main, idEmpresa, vendasBoo));
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!func_dashboard.AtualizarPeriodoComparacao(maskedInicio1Periodo, maskedFim1Periodo, maskedInicio2Periodo, maskedFim2Periodo, param_idEmpresa))
            {
                caixaMensagem info = new caixaMensagem("As datas estão incorreta ou na posição" +
                    "\nerrada!!!", "Falha ❌");
                info.ShowDialog();
                return;
            }
            func_dashboard.carregarInfoComparacao(lbDash1, lbDash2, lbDash3, lbDash4, Info1_dash,
            Info2_dash, Info3_dash, Info4_dash, param_idEmpresa, lbTituloDash);
            func_dashboard.load_grafico_comparacao(grafico1, grafico2, param_idEmpresa, lblProximo, lblLonge);
        }
    }
}
