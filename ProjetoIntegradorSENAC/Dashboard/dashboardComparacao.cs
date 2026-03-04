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
        private bool produtosBoo = false;
        private bool vendasBoo = true;

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
        private void EstilizarComparacao()
        {
            lbDash1.MaximumSize = new Size(Info1_dash.Width, 0);
            lbDash2.MaximumSize = new Size(Info2_dash.Width, 0);
            lbDash3.MaximumSize = new Size(Info3_dash.Width, 0);
            lbDash4.MaximumSize = new Size(Info4_dash.Width, 0);

            // 🔥 TÍTULO
            lbTituloDash.ForeColor = Color.FromArgb(0, 150, 255);
            lbTituloDash.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold);

            // =============================
            // 🟦 BOTÕES
            // =============================
            Button[] botoes = { btnBuscar, btnProdutos, btnVendas, btnComparacao };

            foreach (var btn in botoes)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = Color.FromArgb(0, 120, 215);
                btn.ForeColor = Color.White;
                btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
                btn.Cursor = Cursors.Hand;
            }

            // =============================
            // 📊 CARDS KPI
            // =============================
            var cards = new[] { Info1_dash, Info2_dash, Info3_dash, Info4_dash };
            var labels = new[] { lbDash1, lbDash2, lbDash3, lbDash4 };

            for (int i = 0; i < cards.Length; i++)
            {
                var card = cards[i];
                var label = labels[i];

                card.FlatStyle = FlatStyle.Flat;

                card.Font = new Font("Segoe UI", 9F);

                label.Dock = DockStyle.Fill;
                label.TextAlign = ContentAlignment.TopLeft;
                label.AutoSize = false;
                label.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
                label.ForeColor = Color.FromArgb(0, 150, 255);
            }

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

            lblProximo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
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

            EstilizarComparacao();
            
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
            AplicarTemaDarkComparacao(grafico1);
            AplicarTemaDarkComparacao(grafico2);

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
