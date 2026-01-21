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
        bool produtosBoo = true;
        bool vendasBoo = false;
        bool comparacaoBoo = false;




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
                load_grafico_vendas();
                func_dashboard.carregarInfoVendas(label1, label2, label3, label4, Info1_dash,
                Info2_dash, Info3_dash, Info4_dash, param_idEmpresa, periodo);
            }
            else if (comparacaoBoo)
            {
                func_dashboard.carregarInfoComparacao(label1, label2, label3, label4, Info1_dash,
                Info2_dash, Info3_dash, Info4_dash, param_idEmpresa, periodo, comboPeriodo_dash);
                //load_grafico_comparacao();
            }
        }
        

        public void load_grafico_comparacao()
        {
            // grafico 1
            PlotModel modelo = new PlotModel { Title = "Top 5 produtos mais vendidos", TextColor = OxyColors.White, PlotAreaBorderColor = OxyColors.White };

            var categoryAxis = new CategoryAxis { Position = AxisPosition.Left, Title = "Produtos", TicklineColor = OxyColors.White, };
            var linearAxis = new LinearAxis { Position = AxisPosition.Bottom, Title = "Quantidade", TicklineColor = OxyColors.White, };
            modelo.Axes.Add(categoryAxis);
            modelo.Axes.Add(linearAxis);

            var barSeries = new BarSeries { Title = "Vendas", FillColor = OxyColors.SkyBlue };

            DataTable tabela = func_dashboard.ExecutarSelect(@"SELECT 
            p.id,
            p.nome,
            SUM(iv.quantidade) AS total_vendido
            FROM items_venda iv
            JOIN produtos p ON p.id = iv.produtos_id
            JOIN vendas v ON v.id = iv.vendas_id
            JOIN funcionarios f ON f.id = v.funcionario_id
            WHERE f.comercio_id = @idEmpresa
            GROUP BY p.id, p.nome
            ORDER BY total_vendido DESC
            LIMIT 5;
            ", param_idEmpresa);


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

            // grafico 2

            PlotModel modelo2 = new PlotModel { Title = "Top 5 produtos com mais receita", TextColor = OxyColors.White, PlotAreaBorderColor = OxyColors.White };
            var categoryAxis2 = new CategoryAxis { Position = AxisPosition.Left, Title = "Produtos", TicklineColor = OxyColors.White, };
            var linearAxis2 = new LinearAxis { Position = AxisPosition.Bottom, Title = "Receita", TicklineColor = OxyColors.White, };
            modelo2.Axes.Add(categoryAxis2);
            modelo2.Axes.Add(linearAxis2);

            var barSeries2 = new BarSeries { Title = "Receita", FillColor = OxyColors.Orange };

            DataTable tabela2 = func_dashboard.ExecutarSelect(
            @"
            SELECT 
            p.id,
            p.nome AS produto,
            iv.preco_unitario AS preco,
            SUM(iv.preco_unitario * iv.quantidade) AS receita
                FROM items_venda iv
            JOIN produtos p ON p.id = iv.produtos_id
            JOIN vendas v ON v.id = iv.vendas_id 
            JOIN funcionarios f ON f.id = v.funcionario_id
            WHERE f.comercio_id = @idEmpresa
            GROUP BY p.id, p.nome
            ORDER BY receita DESC
            LIMIT 5;
            ", param_idEmpresa);

            foreach (DataRow row in tabela2.Rows)
            {

                ItemVenda item = new ItemVenda(
                    produtoId: Convert.ToInt32(row["id"]),
                    nomeProduto: row["produto"].ToString(),
                    precoUnitario: Convert.ToDecimal(row["preco"])
                );
                categoryAxis2.Labels.Add(item.NomeProduto);
                barSeries2.Items.Add(new BarItem { Value = Convert.ToDouble(row["receita"]) });
            }
            modelo2.Series.Add(barSeries2);
            grafico2.Model = modelo2;

        }
        public void load_grafico_vendas()
        {
            // grafico 1

            int[] vendasPorDia = new int[31];

            using (var con = new MySqlConnection(Banco.caminho))
            {
                con.Open();

                string sql = @"
    SELECT 
    DAY(v.data_venda) AS dia,
    COUNT(v.id) AS qtd
    FROM vendas v
    JOIN funcionarios f ON v.funcionario_id = f.id
    JOIN comercios c ON f.comercio_id = c.id
    WHERE 
    c.id = @empresaId
    AND MONTH(v.data_venda) = MONTH(CURDATE())
    AND YEAR(v.data_venda) = YEAR(CURDATE())
    GROUP BY dia
    ORDER BY dia;";

                using (var cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@empresaId", idEmpresa.ToString());
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            int dia = dr.GetInt32("dia");
                            int qtd = dr.GetInt32("qtd");
                            vendasPorDia[dia - 1] = qtd;
                        }
                    }
                }
            }

            var modelo = new PlotModel
            {
                Title = "Vendas por Dia do Mês",
                TextColor = OxyColors.White,
                PlotAreaBorderColor = OxyColors.White
            };

            modelo.Axes.Add(new CategoryAxis
            {
                Position = AxisPosition.Bottom,
                Key = "Dias",
                ItemsSource = GerarDiasDoMes(),
                TextColor = OxyColors.White,
                TicklineColor = OxyColors.White
            });

            modelo.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Left,
                Title = "Quantidade de Vendas",
                TextColor = OxyColors.White,
                TicklineColor = OxyColors.White
            });

            var serie = new LineSeries
            {
                Title = "Vendas",
                Color = OxyColors.Red,
                MarkerType = MarkerType.Circle,
                MarkerSize = 4,
                MarkerStroke = OxyColors.White,
                MarkerFill = OxyColors.Red
            };

            for (int i = 0; i < 31; i++)
                serie.Points.Add(new DataPoint(i, vendasPorDia[i]));

            modelo.Series.Add(serie);

            grafico1.Model = modelo;

            //Grafico 2
            PlotModel modelo2 = new PlotModel { Title = "Top 5 produtos mais vendidos do mês", TextColor = OxyColors.White, PlotAreaBorderColor = OxyColors.White };

            var categoryAxis2 = new CategoryAxis { Position = AxisPosition.Left, Title = "Produtos", TicklineColor = OxyColors.White, };
            var linearAxis2 = new LinearAxis { Position = AxisPosition.Bottom, Title = "Quantidade", TicklineColor = OxyColors.White, };
            modelo2.Axes.Add(categoryAxis2);
            modelo2.Axes.Add(linearAxis2);

            var barSeries2 = new BarSeries { Title = "Vendas", FillColor = OxyColors.SkyBlue };

            DataTable tabela = func_dashboard.ExecutarSelect(@"SELECT 
            p.id,
            p.nome,
            SUM(iv.quantidade) AS total_vendido
            FROM items_venda iv
            JOIN produtos p ON p.id = iv.produtos_id
            JOIN vendas v ON v.id = iv.vendas_id
            JOIN funcionarios f ON f.id = v.funcionario_id
            WHERE f.comercio_id = @idEmpresa
            AND MONTH(v.data_venda) = MONTH(CURDATE())
            AND YEAR(v.data_venda) = YEAR(CURDATE())
            GROUP BY p.id, p.nome
            ORDER BY total_vendido DESC
            LIMIT 5;

            ", param_idEmpresa);

            foreach (DataRow row in tabela.Rows)
            {
                ItemVenda item = new ItemVenda(
                    produtoId: Convert.ToInt32(row["id"]),
                    nomeProduto: row["nome"].ToString(),
                    0,
                    quantidade: Convert.ToInt32(row["total_vendido"])
                );
                categoryAxis2.Labels.Add(item.NomeProduto);
                barSeries2.Items.Add(new BarItem { Value = item.Quantidade });
            }
            modelo2.Series.Add(barSeries2);
            grafico2.Model = modelo2;
        }

        private string[] GerarDiasDoMes()
        {
            string[] dias = new string[31];
            for (int i = 0; i < 31; i++)
                dias[i] = (i + 1).ToString();
            return dias;
        }
        private void dashboard_Load(object sender, EventArgs e)
        {
            comboPeriodo_dash.SelectedIndex = 0;
        }
        private void btnProdutos_Click(object sender, EventArgs e)
        {
            comparacaoBoo = false;
            produtosBoo = true;
            vendasBoo = false;
            func_dashboard.carregarInfoProdutos(label1, label2, label3, label4, Info1_dash,
            Info2_dash, Info3_dash, Info4_dash, param_idEmpresa, periodo);
            func_dashboard.load_grafico_produtos(grafico1,grafico2, param_idEmpresa, periodo);
            func_dashboard.carregarCombo(comboPeriodo_dash, comparacaoBoo, produtosBoo, vendasBoo);
        }
        private void btnVendas_Click(object sender, EventArgs e)
        {
            comparacaoBoo = false;
            produtosBoo = false;
            vendasBoo = true;
            //load_grafico_vendas();
            func_dashboard.carregarInfoVendas(label1, label2, label3, label4, Info1_dash,
            Info2_dash, Info3_dash, Info4_dash, param_idEmpresa, periodo);
            func_dashboard.carregarCombo(comboPeriodo_dash, comparacaoBoo, produtosBoo, vendasBoo);
        }
        private void btnComparacao_Click(object sender, EventArgs e)
        {
            comparacaoBoo = true;
            produtosBoo = false;
            vendasBoo = false;
            //load_grafico_comparacao();
            func_dashboard.carregarInfoComparacao(label1, label2, label3, label4, Info1_dash,
            Info2_dash, Info3_dash, Info4_dash, param_idEmpresa, periodo, comboPeriodo_dash);
            func_dashboard.carregarCombo(comboPeriodo_dash, comparacaoBoo, produtosBoo, vendasBoo);
        }

        
    }
}


