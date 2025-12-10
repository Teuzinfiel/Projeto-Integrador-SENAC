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
        private Dictionary<string, object> parametros;
        private Dictionary<string, string> mes;
        public dashboard(int idEmpresa)
        {
            InitializeComponent();
            this.idEmpresa = idEmpresa;
            parametros = new Dictionary<string, object>()
        {
            { "@idEmpresa", idEmpresa }
            };

            mes = new Dictionary<string, string>()
        {
            { "@mes", meses }
            };
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
                groupBox2, groupBox3, groupBox4, idEmpresa, parametros, mes);
                load_grafico_padrao();
            }
            else if (mesesBoo)
            {
                load_grafico_meses();
                func_dashboard.carregarInfoMeses(label1, label2, label3, label4, meses, groupBox1,
                groupBox2, groupBox3, groupBox4, idEmpresa, parametros, mes);
            }
            else if (produtoBoo)
            {
                func_dashboard.carregarInfoProdutos(label1, label2, label3, label4, meses, groupBox1,
                groupBox2, groupBox3, groupBox4, idEmpresa, parametros, mes);
                load_grafico_produto();
            }



        }
        public void load_grafico_padrao()
        {

            // Vetor para armazenar as vendas dos dias 1 a 31
            int[] vendasPorDia = new int[31];

            using (var con = new MySqlConnection(func_dashboard.strCon))
            {
                con.Open();

                string sql = @"
            SELECT 
                DAY(data_venda) AS dia,
                COUNT(id) AS qtd
            FROM vendas
            WHERE 
                MONTH(data_venda) = MONTH(CURDATE())
                AND YEAR(data_venda) = YEAR(CURDATE())
            GROUP BY dia
            ORDER BY dia;
        ";

                using (var cmd = new MySqlCommand(sql, con))
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int dia = dr.GetInt32("dia");   // Exemplo: 1, 2, 3...
                        int qtd = dr.GetInt32("qtd");   // Quantidade de vendas do dia
                        vendasPorDia[dia - 1] = qtd;    // Armazena no índice correto
                    }
                }
            }

            // Criação do gráfico
            var modelo = new PlotModel
            {
                Title = "Vendas por Dia do Mês",
                TextColor = OxyColors.White,
                PlotAreaBorderColor = OxyColors.White
            };

            // Eixo X (1 a 31)
            modelo.Axes.Add(new CategoryAxis
            {
                Position = AxisPosition.Bottom,
                Key = "Dias",
                ItemsSource = GerarDiasDoMes(),
                TextColor = OxyColors.White,
                TicklineColor = OxyColors.White
            });

            // Eixo Y
            modelo.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Left,
                Title = "Quantidade de Vendas",
                TextColor = OxyColors.White,
                TicklineColor = OxyColors.White
            });

            // Série do gráfico
            var serie = new LineSeries
            {
                Title = "Vendas",
                Color = OxyColors.Red,
                MarkerType = MarkerType.Circle,
                MarkerSize = 4,
                MarkerStroke = OxyColors.White,
                MarkerFill = OxyColors.Red
            };

            // Adiciona os pontos ao gráfico
            for (int i = 0; i < 31; i++)
                serie.Points.Add(new DataPoint(i, vendasPorDia[i]));

            modelo.Series.Add(serie);

            // Exibe no PlotView
            grafico1.Model = modelo;







            PlotModel modelo2 = new PlotModel { Title = "Top 5 categorias mais vendidas", TextColor = OxyColors.White, PlotAreaBorderColor = OxyColors.White };
            var pieSeries = new PieSeries { StrokeThickness = 1.0, InsideLabelPosition = 0.8, AngleSpan = 360, StartAngle = 0 };

            DataTable tabela2 = func_dashboard.ExecutarSelect(
            @"SELECT 
            p.categoria,
            SUM(iv.quantidade) AS total_vendido
            FROM items_venda iv
            JOIN produtos p ON p.id = iv.produtos_id
            JOIN vendas v ON v.id = iv.vendas_id
            JOIN funcionarios f ON f.id = v.funcionario_id
            WHERE f.comercio_id = @idEmpresa
            GROUP BY p.categoria
            ORDER BY total_vendido DESC
            LIMIT 5;
            ", parametros, mes);/////////////////////////

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
            PlotModel modelo = new PlotModel { Title = "Top 5 produtos mais vendidios", TextColor = OxyColors.White, PlotAreaBorderColor = OxyColors.White };

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
            ", parametros, mes);/////////////////////////


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
            SUM(iv.preco_unitario * iv.quantidade) AS receita
                FROM items_venda iv
            JOIN produtos p ON p.id = iv.produtos_id
            JOIN vendas v ON v.id = iv.vendas_id 
            JOIN funcionarios f ON f.id = v.funcionario_id
            WHERE f.comercio_id = @idEmpresa
            GROUP BY p.id, p.nome
            ORDER BY receita DESC
            LIMIT 5;
            ", parametros, mes);//////////////////////////////////

            foreach (DataRow row in tabela2.Rows)
            {

                ItemVenda item = new ItemVenda(
                    produtoId: Convert.ToInt32(row["id"]),
                    nomeProduto: row["produto"].ToString()
                );
                categoryAxis2.Labels.Add(item.NomeProduto);
                barSeries2.Items.Add(new BarItem { Value = Convert.ToDouble(row["receita"]) });

            }
            modelo2.Series.Add(barSeries2);
            grafico2.Model = modelo2;

        }
        public void load_grafico_meses()
        {
            PlotModel modeloHorario = new PlotModel
            {
                Title = "Vendas por horário (todos os dias)",
                TextColor = OxyColors.White,
                PlotAreaBorderColor = OxyColors.White
            };

            var categoryAxisH = new CategoryAxis
            {
                Position = AxisPosition.Bottom,
                Title = "Horário",
                TicklineColor = OxyColors.White,
                TextColor = OxyColors.White
            };

            var linearAxisH = new LinearAxis
            {
                Position = AxisPosition.Left,
                Title = "Quantidade de Vendas",
                TicklineColor = OxyColors.White,
                TextColor = OxyColors.White
            };

            modeloHorario.Axes.Add(categoryAxisH);
            modeloHorario.Axes.Add(linearAxisH);

            // Série de linha
            var lineSeriesH = new LineSeries
            {
                Title = "Vendas",
                Color = OxyColors.SkyBlue,
                MarkerType = MarkerType.Circle,
                MarkerSize = 5,
                MarkerFill = OxyColors.SkyBlue,
                MarkerStroke = OxyColors.White
            };

            // ---------------------------------------------------------------------
            //   CONSULTA SQL — VENDAS POR HORA
            // ---------------------------------------------------------------------

            int[] vendasPorHora = new int[24];

            using (var con = new MySqlConnection(func_dashboard.strCon))
            {
                con.Open();

                string sql = @"
        SELECT 
            HOUR(data_venda) AS hora,
            COUNT(*) AS total_vendas
        FROM vendas
        GROUP BY hora
        ORDER BY hora;
    ";

                using (var cmd = new MySqlCommand(sql, con))
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int hora = dr.GetInt32("hora");
                        int total = dr.GetInt32("total_vendas");
                        vendasPorHora[hora] = total;
                    }
                }
            }

            // ---------------------------------------------------------------------
            //   MONTAGEM DO GRÁFICO
            // ---------------------------------------------------------------------

            for (int i = 0; i < 24; i++)
            {
                categoryAxisH.Labels.Add(i.ToString("00")); // “00”, “01”, “02”...

                // adiciona ponto na linha
                lineSeriesH.Points.Add(new DataPoint(i, vendasPorHora[i]));
            }

            modeloHorario.Series.Add(lineSeriesH);

            // Exibe no PlotView
            grafico1.Model = modeloHorario;




            // ==============================
            //   GRÁFICO barra – TOP 5 produtos mais vendidos
            // ==============================

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

            ", parametros, mes);/////////////////////////


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
            comboBox1.SelectedIndex = 0;
        }

        private void btnPadrao_Click(object sender, EventArgs e)
        {
            produtoBoo = false;
            padraoBoo = true;
            mesesBoo = false;
            func_dashboard.carregarInfoPadrao(label1, label2, label3, label4, meses, groupBox1,
            groupBox2, groupBox3, groupBox4, idEmpresa, parametros, mes);
            load_grafico_padrao();
        }

        private void btnMeses_Click(object sender, EventArgs e)
        {
            produtoBoo = false;
            padraoBoo = false;
            mesesBoo = true;
            load_grafico_meses();
            func_dashboard.carregarInfoMeses(label1, label2, label3, label4, meses, groupBox1,
            groupBox2, groupBox3, groupBox4, idEmpresa, parametros, mes);
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            produtoBoo = true;
            padraoBoo = false;
            mesesBoo = false;
            load_grafico_produto();
            func_dashboard.carregarInfoProdutos(label1, label2, label3, label4, meses, groupBox1,
            groupBox2, groupBox3, groupBox4, idEmpresa, parametros, mes);
        }
    }
}


