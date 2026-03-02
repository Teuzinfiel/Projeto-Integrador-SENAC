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
        private void EstilizarComparacao()
        {
            // 🎨 FUNDO GERAL
            panel1.BackColor = Color.FromArgb(30, 30, 45);
            tlpMain.BackColor = Color.FromArgb(25, 25, 40);

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

                card.BackColor = Color.FromArgb(35, 35, 55);
                card.ForeColor = Color.FromArgb(180, 180, 200);
                card.FlatStyle = FlatStyle.Flat;

                card.Font = new Font("Segoe UI", 9F);

                label.Dock = DockStyle.Fill;
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold);
                label.ForeColor = Color.FromArgb(0, 150, 255);
            }

            // =============================
            // 📈 GRÁFICOS (Container)
            // =============================
            GroupBox[] graficos = { grafico1_dash, grafico2_dash };

            foreach (var g in graficos)
            {
                g.BackColor = Color.FromArgb(35, 35, 55);
                g.ForeColor = Color.White;
                g.FlatStyle = FlatStyle.Flat;
                g.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            }

            // =============================
            // 🏷️ LEGENDAS PRÓXIMO / LONGE
            // =============================
            lblProximo.ForeColor = Color.FromArgb(0, 200, 120); // verde
            lblLonge.ForeColor = Color.FromArgb(255, 140, 0);   // laranja

            lblProximo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLonge.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
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
