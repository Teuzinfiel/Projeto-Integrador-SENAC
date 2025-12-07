using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.WindowsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using OxyPlot.Series;
using System.Drawing;
using System.Linq;
using System.Text;
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
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            meses = "1";
            if (comboBox1.SelectedIndex == 1) meses = "6";
            else if (comboBox1.SelectedIndex == 2) meses = "12";
            
            func_dashboard.carregarInfoPadrao(label1, label2, label3, label4, meses, groupBox1,
            groupBox2, groupBox3, groupBox4);
            load_grafico_padrao();
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
                categoryAxis.Labels.Add(row["nome"].ToString());
                barSeries.Items.Add(new BarItem { Value = Convert.ToDouble(row["total_vendido"]) });
            }

            modelo.Series.Add(barSeries);
            grafico1.Model = modelo;
        }
    }
}
