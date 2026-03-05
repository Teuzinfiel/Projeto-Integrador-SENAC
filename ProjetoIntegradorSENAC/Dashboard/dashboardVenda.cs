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
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegradorSENAC.Dashboard
{
    public partial class dashboardVenda : Form
    {
        private MainEmpresa _main; // referência ao form pai
        private int idEmpresa;
        private Dictionary<string, object> parametros;
        public dashboardVenda(MainEmpresa main, int idEmpresa)
        {
            InitializeComponent();
            _main = main;
            this.idEmpresa = idEmpresa;
            parametros = new Dictionary<string, object>()
            {
                { "@idEmpresa", idEmpresa }
            };
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            _main.AbrirFormNoPanel(new dashboardProduto(_main, idEmpresa));
        }
        private void btnComparacao_Click(object sender, EventArgs e)
        {
            _main.AbrirFormNoPanel(new dashboardComparacao(_main, idEmpresa));
        }
        private void buttonEstoque_Click(object sender, EventArgs e)
        {
            _main.AbrirFormNoPanel(new dashboardEstoque(_main, idEmpresa));
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {

            carregarPag();
        }
        private void dashboard_Load(object sender, EventArgs e)
        {
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
            if (!AtualizarPeriodo())
            {
                MessageBox.Show("Erro ao atualizar o período. Verifique as datas e tente novamente.");
                return;
            }
            func_dashboard.load_grafico_vendas(grafico1, grafico2, parametros,lbTituloGrafico1,lbTituloGrafico2);
            func_dashboard.carregarInfoVendas(lbDash1, lbDash2, lbDash3, lbDash4, parametros);
            func_dashboard.EstilizarGrafico(grafico1,grafico2);
        }
       
        private bool AtualizarPeriodo()
        {
            if (!DateTime.TryParseExact(maskedInicio.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime inicio))
                return false;

            if (!DateTime.TryParseExact(maskedFim.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fim))
                return false;

            if (inicio > fim)
                return false;

            parametros.Remove("@dataInicio");
            parametros.Remove("@dataFim");

            parametros["@dataInicio"] = inicio.ToString("yyyy-MM-dd");
            parametros["@dataFim"] = fim.ToString("yyyy-MM-dd");

            return true;
        }

    }
}


