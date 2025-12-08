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
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegradorSENAC.Dashboard
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }
        string meses;
        bool padraoBoo = true;
        bool mesesBoo = false;
        bool produtoBoo = false;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            meses = "1";
            if (comboBox1.SelectedIndex == 1) meses = "6";
            else if (comboBox1.SelectedIndex == 2) meses = "12";

            if (padraoBoo)
            {
                func_dashboard.carregarInfoPadrao(label1, label2, label3, label4, meses, groupBox1,
                groupBox2, groupBox3, groupBox4);
                load_grafico_padrao();
            }
            else if (mesesBoo)
            {
                load_grafico_meses();
            }
            else if (produtoBoo)
            {
                load_grafico_produto();
            }



        }
        public void load_grafico_padrao()
        {
            PlotModel modelo = new PlotModel { Title = "Top 5 produtos mais vendidios", TextColor = OxyColors.White, PlotAreaBorderColor = OxyColors.White };

            var categoryAxis = new CategoryAxis { Position = AxisPosition.Left, Title = "Produtos", TicklineColor = OxyColors.White, };
            var linearAxis = new LinearAxis { Position = AxisPosition.Bottom, Title = "Quantidade", TicklineColor = OxyColors.White, };
            modelo.Axes.Add(categoryAxis);
            modelo.Axes.Add(linearAxis);

            var barSeries = new BarSeries { Title = "Vendas", FillColor = OxyColors.SkyBlue };

            DataTable tabela = func_dashboard.ExecutarSelect("SELECT p.id, p.nome, SUM(iv.quantidade) AS total_vendido " +
            "FROM items_venda iv " +
            " JOIN produtos p ON p.id = iv.produtos_id " +
            "GROUP BY p.id, p.nome " +
            "ORDER BY total_vendido DESC LIMIT 5");


            foreach (DataRow row in tabela.Rows)
            {

                ItemVenda item = new ItemVenda(
                    produtoId: Convert.ToInt32(row["id"]),
                    nomeProduto: row["nome"].ToString(),
                    0,
                    quantidade: Convert.ToInt32(row["total_vendido"])
                );

                categoryAxis.Labels.Add(item.NomeProduto);
                barSeries.Items.Add(new BarItem { Value = item.Quantidade });
            }

            modelo.Series.Add(barSeries);
            grafico1.Model = modelo;

            PlotModel modelo2 = new PlotModel { Title = "Top 5 categorias mais vendidas", TextColor = OxyColors.White, PlotAreaBorderColor = OxyColors.White };
            var pieSeries = new PieSeries { StrokeThickness = 1.0, InsideLabelPosition = 0.8, AngleSpan = 360, StartAngle = 0 };

            DataTable tabela2 = func_dashboard.ExecutarSelect(
            "SELECT p.categoria, " +
            "SUM(iv.quantidade) AS total_vendido " +
            "FROM items_venda iv " +
            "JOIN produtos p ON p.id = iv.produtos_id " +
            "JOIN vendas v ON v.id = iv.vendas_id " +
            "GROUP BY p.categoria " +
            "ORDER BY total_vendido DESC " +
            "LIMIT 5;");

            foreach (DataRow row in tabela2.Rows)
            {

                cls_Produto produto = new cls_Produto(

                    categoria: row["categoria"].ToString()
                );
                pieSeries.Slices.Add(new PieSlice(produto.Categoria, Convert.ToDouble(row["total_vendido"])) { IsExploded = false });
            }
            modelo2.Series.Add(pieSeries);
            grafico2.Model = modelo2;

        }
        public void load_grafico_produto()
        {
            PlotModel modelo = new PlotModel { Title = "Top 4 produtos mais vendidios", TextColor = OxyColors.White, PlotAreaBorderColor = OxyColors.White };

            var categoryAxis = new CategoryAxis { Position = AxisPosition.Left, Title = "Produtos", TicklineColor = OxyColors.White, };
            var linearAxis = new LinearAxis { Position = AxisPosition.Bottom, Title = "Quantidade", TicklineColor = OxyColors.White, };
            modelo.Axes.Add(categoryAxis);
            modelo.Axes.Add(linearAxis);

            var barSeries = new BarSeries { Title = "Vendas", FillColor = OxyColors.SkyBlue };

            DataTable tabela = func_dashboard.ExecutarSelect("SELECT p.id, p.nome, SUM(iv.quantidade) AS total_vendido " +
            "FROM items_venda iv " +
            " JOIN produtos p ON p.id = iv.produtos_id " +
            "GROUP BY p.id, p.nome " +
            "ORDER BY total_vendido DESC LIMIT 5");


            foreach (DataRow row in tabela.Rows)
            {

                ItemVenda item = new ItemVenda(
                    produtoId: Convert.ToInt32(row["id"]),
                    nomeProduto: row["nome"].ToString(),
                    0,
                    quantidade: Convert.ToInt32(row["total_vendido"])
                );

                categoryAxis.Labels.Add(item.NomeProduto);
                barSeries.Items.Add(new BarItem { Value = item.Quantidade });
            }

            modelo.Series.Add(barSeries);
            grafico1.Model = modelo;

            PlotModel modelo2 = new PlotModel { Title = "Top 5 categorias mais vendidas", TextColor = OxyColors.White, PlotAreaBorderColor = OxyColors.White };
            var pieSeries = new PieSeries { StrokeThickness = 1.0, InsideLabelPosition = 0.8, AngleSpan = 360, StartAngle = 0 };

            DataTable tabela2 = func_dashboard.ExecutarSelect(
            "SELECT p.categoria, " +
            "SUM(iv.quantidade) AS total_vendido " +
            "FROM items_venda iv " +
            "JOIN produtos p ON p.id = iv.produtos_id " +
            "JOIN vendas v ON v.id = iv.vendas_id " +
            "GROUP BY p.categoria " +
            "ORDER BY total_vendido DESC " +
            "LIMIT 5;");

            foreach (DataRow row in tabela2.Rows)
            {

                cls_Produto produto = new cls_Produto(

                    categoria: row["categoria"].ToString()
                );
                pieSeries.Slices.Add(new PieSlice(produto.Categoria, Convert.ToDouble(row["total_vendido"])) { IsExploded = false });
            }
            modelo2.Series.Add(pieSeries);
            grafico2.Model = modelo2;

        }
        public void load_grafico_meses()
        {
            PlotModel modelo = new PlotModel { Title = "Top 3 produtos mais vendidios", TextColor = OxyColors.White, PlotAreaBorderColor = OxyColors.White };

            var categoryAxis = new CategoryAxis { Position = AxisPosition.Left, Title = "Produtos", TicklineColor = OxyColors.White, };
            var linearAxis = new LinearAxis { Position = AxisPosition.Bottom, Title = "Quantidade", TicklineColor = OxyColors.White, };
            modelo.Axes.Add(categoryAxis);
            modelo.Axes.Add(linearAxis);

            var barSeries = new BarSeries { Title = "Vendas", FillColor = OxyColors.SkyBlue };

            DataTable tabela = func_dashboard.ExecutarSelect("SELECT p.id, p.nome, SUM(iv.quantidade) AS total_vendido " +
            "FROM items_venda iv " +
            " JOIN produtos p ON p.id = iv.produtos_id " +
            "GROUP BY p.id, p.nome " +
            "ORDER BY total_vendido DESC LIMIT 5");


            foreach (DataRow row in tabela.Rows)
            {

                ItemVenda item = new ItemVenda(
                    produtoId: Convert.ToInt32(row["id"]),
                    nomeProduto: row["nome"].ToString(),
                    0,
                    quantidade: Convert.ToInt32(row["total_vendido"])
                );

                categoryAxis.Labels.Add(item.NomeProduto);
                barSeries.Items.Add(new BarItem { Value = item.Quantidade });
            }

            modelo.Series.Add(barSeries);
            grafico1.Model = modelo;

            PlotModel modelo2 = new PlotModel { Title = "Top 5 categorias mais vendidas", TextColor = OxyColors.White, PlotAreaBorderColor = OxyColors.White };
            var pieSeries = new PieSeries { StrokeThickness = 1.0, InsideLabelPosition = 0.8, AngleSpan = 360, StartAngle = 0 };

            DataTable tabela2 = func_dashboard.ExecutarSelect(
            "SELECT p.categoria, " +
            "SUM(iv.quantidade) AS total_vendido " +
            "FROM items_venda iv " +
            "JOIN produtos p ON p.id = iv.produtos_id " +
            "JOIN vendas v ON v.id = iv.vendas_id " +
            "GROUP BY p.categoria " +
            "ORDER BY total_vendido DESC " +
            "LIMIT 5;");

            foreach (DataRow row in tabela2.Rows)
            {

                cls_Produto produto = new cls_Produto(

                    categoria: row["categoria"].ToString()
                );
                pieSeries.Slices.Add(new PieSlice(produto.Categoria, Convert.ToDouble(row["total_vendido"])) { IsExploded = false });
            }
            modelo2.Series.Add(pieSeries);
            grafico2.Model = modelo2;

        }
        private void dashboard_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void btnPadrao_Click(object sender, EventArgs e)
        {
            produtoBoo = false;
            padraoBoo = true;
            mesesBoo = false;
            func_dashboard.carregarInfoPadrao(label1, label2, label3, label4, meses, groupBox1,
            groupBox2, groupBox3, groupBox4);
            load_grafico_padrao();
        }

        private void btnMeses_Click(object sender, EventArgs e)
        {
            produtoBoo = false;
            padraoBoo = false;
            mesesBoo = true;
            load_grafico_meses();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            produtoBoo = true;
            padraoBoo = false;
            mesesBoo = false;
            load_grafico_produto();
        }
    }
}
