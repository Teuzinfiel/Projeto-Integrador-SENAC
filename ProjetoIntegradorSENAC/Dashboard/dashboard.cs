using MySql.Data.MySqlClient;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using ProjetoIntegradorSENAC.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegradorSENAC.Dashboard
{
    public partial class dashboard : Form
    {
        private MainPrincipal _main; // referência ao form pai
        private int idEmpresa;
        private Dictionary<string, object> param_idEmpresa;
        private bool abrirVendas = false;
        public dashboard(MainPrincipal main, int idEmpresa, bool abrirVendas)
        {
            InitializeComponent();
            _main = main;
            this.idEmpresa = idEmpresa;
            this.abrirVendas = abrirVendas;
            param_idEmpresa = new Dictionary<string, object>()
            {
                { "@idEmpresa", idEmpresa }
            };
        }
        bool produtosBoo = false, vendasBoo = false;

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            if (produtosBoo)
            {
                return;
            }
            AtivarProdutos();
            carregarPag();
        }
        private void btnVendas_Click(object sender, EventArgs e)
        {
            if (vendasBoo)
            {
                return;
            }
            AtivarVendas();
            carregarPag();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            carregarPag();
        }
        private void dashboard_Load(object sender, EventArgs e)
        {
            EstilizarCards();
            if (abrirVendas == true)
            {
                vendasBoo = true;
            }
            else
            {
                produtosBoo = true;
            }
            maskedInicio.Text = DateTime.Now.ToString("dd/MM/yyyy");
            maskedFim.Text = DateTime.Now.ToString("dd/MM/yyyy");
            carregarPag();
        }

        private void carregarPag()
        {
            if (!maskedInicio.MaskFull || !maskedFim.MaskFull ||
                !DateTime.TryParse(maskedInicio.Text, out _) ||
                !DateTime.TryParse(maskedFim.Text, out _))
            {
                MessageBox.Show("Data incompleta ou vazia.");
                return;
            }
            if (!func_dashboard.AtualizarPeriodo(maskedInicio, maskedFim, param_idEmpresa))
            {
                MessageBox.Show("Erro ao atualizar o período. Verifique as datas e tente novamente.");
                return;
            }
            if (produtosBoo)
            {

                func_dashboard.load_grafico_produtos(grafico1, grafico2, param_idEmpresa);
                AplicarTemaDark(grafico1);
                AplicarTemaDark(grafico2);

                func_dashboard.carregarInfoProdutos(lbDash1, lbDash2, lbDash3, lbDash4,
                Info1_dash, Info2_dash, Info3_dash, Info4_dash, param_idEmpresa, lbTituloDash);
            }
            else if (vendasBoo)
            {
                func_dashboard.load_grafico_vendas(grafico1, grafico2, param_idEmpresa);
                AplicarTemaDark(grafico1);
                AplicarTemaDark(grafico2);

                func_dashboard.carregarInfoVendas(lbDash1, lbDash2, lbDash3, lbDash4, Info1_dash,
                Info2_dash, Info3_dash, Info4_dash, param_idEmpresa, lbTituloDash);
            }

        }
        public void AtivarVendas()
        {
            produtosBoo = false;
            vendasBoo = true;
        }
        public void AtivarProdutos()
        {
            produtosBoo = true;
            vendasBoo = false;
        }

        private void btnComparacao_Click(object sender, EventArgs e)
        {
            _main.AbrirFormNoPanel(new dashboardComparacao(_main, idEmpresa));
        }
        private void AplicarTemaDark(OxyPlot.WindowsForms.PlotView plot)
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

                    line.Color = OxyColor.Parse("#1E90FF"); // Azul moderno
                    line.StrokeThickness = 3;

                    line.MarkerType = MarkerType.Circle;
                    line.MarkerSize = 4;
                    line.MarkerFill = OxyColor.Parse("#1E90FF");
                }
            }

            plot.InvalidatePlot(true);
        }
        private void EstilizarCards()
        {
            var cards = new[] { Info1_dash, Info2_dash, Info3_dash, Info4_dash };
            var labels = new[] { lbDash1, lbDash2, lbDash3, lbDash4 };

            for (int i = 0; i < cards.Length; i++)
            {
                var card = cards[i];
                var label = labels[i];

                // Fundo moderno
                card.BackColor = Color.FromArgb(35, 35, 55);
                card.ForeColor = Color.FromArgb(180, 180, 200);

                // Remove borda padrão feia
                card.FlatStyle = FlatStyle.Flat;

                // Título menor
                card.Font = new Font("Segoe UI", 9F, FontStyle.Regular);

                // Número principal grande
                label.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold);
                label.ForeColor = Color.FromArgb(30, 144, 255); // Azul moderno
                label.AutoSize = false;
                label.Dock = DockStyle.Fill;
                label.TextAlign = ContentAlignment.MiddleCenter;
            }
        }
    }
}


