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
        private int idEmpresa;
        private Dictionary<string, object> param_idEmpresa;
        public dashboard(int idEmpresa)
        {
            InitializeComponent();
            this.idEmpresa = idEmpresa;
            param_idEmpresa = new Dictionary<string, object>()
            {
                { "@idEmpresa", idEmpresa }
            };
        }
        string periodoAtual, periodoPassado;
        bool produtosBoo, vendasBoo, comparacaoBoo;

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            if (produtosBoo)
            {
                return;
            }
            AtivarProdutos();

            if (!maskedInicio.MaskFull || !maskedFim.MaskFull ||
                !DateTime.TryParse(maskedInicio.Text, out _) ||
                !DateTime.TryParse(maskedFim.Text, out _))
            {
                MessageBox.Show("Data incompleta ou vazia.");
                return;
            }
            carregarPag();
        }
        private void btnVendas_Click(object sender, EventArgs e)
        {
            if (vendasBoo)
            {
                return;
            }
            AtivarVendas();
            if (!maskedInicio.MaskFull || !maskedFim.MaskFull ||
                !DateTime.TryParse(maskedInicio.Text, out _) ||
                !DateTime.TryParse(maskedFim.Text, out _))
            {
                MessageBox.Show("Data incompleta ou vazia.");
                return;
            }
            carregarPag();
            
        }
        private void btnComparacao_Click(object sender, EventArgs e)
        {
            if (comparacaoBoo)
            {
                return;
            }
            AtivarComparacao();

            if (!maskedInicio.MaskFull || !maskedFim.MaskFull ||
                !DateTime.TryParse(maskedInicio.Text, out _) ||
                !DateTime.TryParse(maskedFim.Text, out _))
            {
                MessageBox.Show("Data incompleta ou vazia.");
                return;
            }
            carregarPag();
            
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!maskedInicio.MaskFull || !maskedFim.MaskFull ||
                !DateTime.TryParse(maskedInicio.Text, out _) ||
                !DateTime.TryParse(maskedFim.Text, out _))
            {
                MessageBox.Show("Data incompleta ou vazia.");
                return;
            }
            carregarPag();
        }
        private void dashboard_Load(object sender, EventArgs e)
        {

            maskedInicio.Text = DateTime.Now.ToString("dd/MM/yyyy");
            maskedFim.Text = DateTime.Now.ToString("dd/MM/yyyy");
            AtivarVendas();
            carregarPag();
        }
        
        private void carregarPag()
        {
            if (!func_dashboard.AtualizarPeriodo(maskedInicio, maskedFim, param_idEmpresa))
            {
                MessageBox.Show("Data inválida");
                return;
            }
            
            periodoAtual = maskedInicio.Text;
            periodoPassado = maskedFim.Text;
            if (comparacaoBoo)
            {
                func_dashboard.carregarInfoComparacao(label1, label2, label3, label4, Info1_dash,
                Info2_dash, Info3_dash, Info4_dash, param_idEmpresa, periodoAtual, periodoPassado);
                func_dashboard.load_grafico_comparacao(grafico1, grafico2, param_idEmpresa, periodoAtual, periodoPassado, lblProximo, lblLonge);
            }
            else if (produtosBoo)
            {
                func_dashboard.load_grafico_produtos(grafico1, grafico2, param_idEmpresa);
                func_dashboard.carregarInfoProdutos(label1, label2, label3, label4,
                Info1_dash, Info2_dash, Info3_dash, Info4_dash, param_idEmpresa);
            }
            else if (vendasBoo)
            {
                func_dashboard.load_grafico_vendas(grafico1, grafico2, param_idEmpresa);
                func_dashboard.carregarInfoVendas(label1, label2, label3, label4, Info1_dash,
                Info2_dash, Info3_dash, Info4_dash, param_idEmpresa);
            }
        }
        private void AtivarVendas()
        {
            produtosBoo = false;
            vendasBoo = true;
            comparacaoBoo = false;
        }

        private void AtivarProdutos()
        {
            produtosBoo = true;
            vendasBoo = false;
            comparacaoBoo = false;
        }

        private void AtivarComparacao()
        {
            produtosBoo = false;
            vendasBoo = false;
            comparacaoBoo = true;
        }

    }
}


