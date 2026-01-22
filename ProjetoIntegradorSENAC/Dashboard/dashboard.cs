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
        private Dictionary<string, string> mes;
        public dashboard(int idEmpresa)
        {
            InitializeComponent();
            this.idEmpresa = idEmpresa;
            param_idEmpresa = new Dictionary<string, object>()
            {
                { "@idEmpresa", idEmpresa }
            };


        }
        string periodo;
        bool produtosBoo = true, vendasBoo = false, comparacaoBoo = false, recarregarCombo = false;




        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            periodo = func_dashboard.carregarPeriodo(comboPeriodo_dash);
            if (produtosBoo)
            {
                func_dashboard.carregarInfoProdutos(label1, label2, label3, label4, Info1_dash,
                Info2_dash, Info3_dash, Info4_dash, param_idEmpresa, periodo);
                func_dashboard.load_grafico_produtos( grafico1,grafico2, param_idEmpresa, periodo);
            }
            else if (vendasBoo)
            {
                func_dashboard.load_grafico_vendas(grafico1, grafico2, param_idEmpresa, periodo);
                func_dashboard.carregarInfoVendas(label1, label2, label3, label4, Info1_dash,
                Info2_dash, Info3_dash, Info4_dash, param_idEmpresa, periodo);
            }
            else if (comparacaoBoo)
            {
                func_dashboard.carregarInfoComparacao(label1, label2, label3, label4, Info1_dash,
                Info2_dash, Info3_dash, Info4_dash, param_idEmpresa, periodo, comboPeriodo_dash);
                func_dashboard.load_grafico_comparacao(grafico1, grafico2, param_idEmpresa, periodo, comboPeriodo_dash);
            }
        }
        private void dashboard_Load(object sender, EventArgs e)
        {
            comboPeriodo_dash.SelectedIndex = 0;
        }
        private void btnProdutos_Click(object sender, EventArgs e)
        {
            if (comparacaoBoo == true)
            {
                recarregarCombo = true;
            }
            comparacaoBoo = false;
            produtosBoo = true;
            vendasBoo = false;
            func_dashboard.carregarInfoProdutos(label1, label2, label3, label4, Info1_dash,
            Info2_dash, Info3_dash, Info4_dash, param_idEmpresa, periodo);
            func_dashboard.load_grafico_produtos(grafico1,grafico2, param_idEmpresa, periodo);
            func_dashboard.carregarCombo(comboPeriodo_dash, comparacaoBoo, produtosBoo, vendasBoo, recarregarCombo);
        }
        private void btnVendas_Click(object sender, EventArgs e)
        {
            if (comparacaoBoo == true)
            {
                recarregarCombo = true;
            }
            comparacaoBoo = false;
            produtosBoo = false;
            vendasBoo = true;
            func_dashboard.load_grafico_vendas(grafico1, grafico2, param_idEmpresa, periodo);
            func_dashboard.carregarInfoVendas(label1, label2, label3, label4, Info1_dash,
            Info2_dash, Info3_dash, Info4_dash, param_idEmpresa, periodo);
            func_dashboard.carregarCombo(comboPeriodo_dash, comparacaoBoo, produtosBoo, vendasBoo, recarregarCombo);

        }
        private void btnComparacao_Click(object sender, EventArgs e)
        {
            if (produtosBoo == true|| vendasBoo == true)
            {
                recarregarCombo = true;
            }
            comparacaoBoo = true;
            produtosBoo = false;
            vendasBoo = false;
            func_dashboard.load_grafico_comparacao(grafico1, grafico2, param_idEmpresa, periodo, comboPeriodo_dash);
            func_dashboard.carregarInfoComparacao(label1, label2, label3, label4, Info1_dash,
            Info2_dash, Info3_dash, Info4_dash, param_idEmpresa, periodo, comboPeriodo_dash);
            func_dashboard.carregarCombo(comboPeriodo_dash, comparacaoBoo, produtosBoo, vendasBoo, recarregarCombo);

        }
    }
}


