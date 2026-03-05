using OxyPlot;
using OxyPlot.Series;
using ProjetoIntegradorSENAC.Dashboard;
using ProjetoIntegradorSENAC.personalizado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegradorSENAC
{
    public partial class dashboardComparacao : Form
    {
        private MainEmpresa _main;
        private int idEmpresa;
        private Dictionary<string, object> param_idEmpresa;

        public dashboardComparacao(MainEmpresa main, int idEmpresa)
        {
            InitializeComponent();
            this.idEmpresa = idEmpresa;
            this._main = main;
            param_idEmpresa = new Dictionary<string, object>()
            {
                { "@idEmpresa", idEmpresa }
            };
        }
        private void btnVendas_Click(object sender, EventArgs e)
        {
            _main.AbrirFormNoPanel(new dashboardVenda(_main, idEmpresa));
        }
        private void btnProdutos_Click(object sender, EventArgs e)
        {
            _main.AbrirFormNoPanel(new dashboardProduto(_main, idEmpresa));
        }
        private void btnEstoque_Click(object sender, EventArgs e)
        {
            _main.AbrirFormNoPanel(new dashboardEstoque(_main, idEmpresa));
        }
        private void EstilizarComparacao()
        {
           

            // =============================
            // 📈 GRÁFICOS (Container)
            // =============================
            GroupBox[] graficos = { grafico1_dash, grafico2_dash };

            foreach (var g in graficos)
            {
                g.ForeColor = Color.White;
                g.FlatStyle = FlatStyle.Flat;
                g.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            }

            // =============================
            // 🏷️ LEGENDAS PRÓXIMO / LONGE
            // =============================

            lbl1periodo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLonge.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        }
        private void AplicarTemaDarkComparacao(OxyPlot.WindowsForms.PlotView plot)
        {
            if (plot.Model == null) return;

            var model = plot.Model;

            // Fundo
            model.Background = OxyColors.Transparent;
            model.PlotAreaBorderColor = OxyColors.Transparent;

            // Texto
            model.TextColor = OxyColors.White;
            model.TitleColor = OxyColors.White;
            model.TitleFontSize = 15;

            // Eixos
            foreach (var axis in model.Axes)
            {
                axis.TextColor = OxyColors.White;
                axis.AxislineColor = OxyColors.Gray;

                axis.MajorGridlineStyle = LineStyle.Solid;
                axis.MajorGridlineColor = OxyColor.FromAColor(40, OxyColors.White);

                axis.MinorGridlineStyle = LineStyle.None;
            }

            // Séries (somente LineSeries para evitar erro)
            foreach (var s in model.Series)
            {
                if (s is LineSeries)
                {
                    var line = (LineSeries)s;


                    line.StrokeThickness = 3;

                    line.MarkerType = MarkerType.Circle;
                    line.MarkerSize = 4;
                }
            }

            plot.InvalidatePlot(true);
        }
        private void dashboardComparacao_Load(object sender, EventArgs e)
        {
            maskedInicio1Periodo.Text = DateTime.Now.AddMonths(-1).ToString("dd/MM/yyyy");
            maskedFim1Periodo.Text = DateTime.Now.ToString("dd/MM/yyyy");
            maskedInicio2Periodo.Text = DateTime.Now.AddMonths(-2).ToString("dd/MM/yyyy");
            maskedFim2Periodo.Text = DateTime.Now.AddMonths(-1).ToString("dd/MM/yyyy");
            CarregarPag();
            EstilizarComparacao();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CarregarPag();
        }
        private void CarregarPag()
        {
            if (!AtualizarPeriodoComparacao())
            {
                caixaMensagem info = new caixaMensagem("As datas estão incorreta ou na posição" +
                    "\nerrada!!!", "Falha ❌");
                info.ShowDialog();
                return;
            }
            func_dashboard.carregarInfoComparacao(lbDash1, lbDash2, lbDash3, lbDash4, param_idEmpresa);
            func_dashboard.load_grafico_comparacao(grafico1, grafico2, param_idEmpresa, lbl1periodo, lblLonge,lbTituloGrafico1, lbTituloGrafico2);
            AplicarTemaDarkComparacao(grafico1);
            AplicarTemaDarkComparacao(grafico2);
        }
        private bool AtualizarPeriodoComparacao()
        {
            if (!DateTime.TryParseExact(maskedInicio1Periodo.Text, "dd/MM/yyyy",
                CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime inicio1Periodo))
                return false;

            if (!DateTime.TryParseExact(maskedFim1Periodo.Text, "dd/MM/yyyy",
                CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fim1Periodo))
                return false;

            if (!DateTime.TryParseExact(maskedInicio2Periodo.Text, "dd/MM/yyyy",
                CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime inicio2Periodo))
                return false;

            if (!DateTime.TryParseExact(maskedFim2Periodo.Text, "dd/MM/yyyy",
                CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fim2Periodo))
                return false;

            inicio1Periodo = inicio1Periodo.Date;
            fim1Periodo = fim1Periodo.Date.AddDays(1).AddSeconds(-1);

            inicio2Periodo = inicio2Periodo.Date;
            fim2Periodo = fim2Periodo.Date.AddDays(1).AddSeconds(-1);


            if (inicio1Periodo > fim1Periodo)
                return false;

            if (inicio2Periodo > fim2Periodo)
                return false;

            param_idEmpresa["@dataInicio1Periodo"] = inicio1Periodo;
            param_idEmpresa["@dataFim1Periodo"] = fim1Periodo;

            param_idEmpresa["@dataInicio2Periodo"] = inicio2Periodo;
            param_idEmpresa["@dataFim2Periodo"] = fim2Periodo;

            return true;
        }
    }
}
