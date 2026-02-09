using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Mysqlx.Session;
using OxyPlot;
using OxyPlot.Annotations;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using ProjetoIntegradorSENAC.Classes;
using ProjetoIntegradorSENAC.Empresa;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace ProjetoIntegradorSENAC.Dashboard
{
    internal class func_dashboard
    {
     
        

        public static void carregarInfoComparacao(Label label1, Label label2, Label label3,
            Label label4, GroupBox Info1_dash, GroupBox Info2_dash,
            GroupBox Info3_dash, GroupBox Info4_dash, Dictionary<string, object> parametros, string periodoInicial, string periodoFim)
        {
            DataTable tabela = ExecutarSelect(@"
                SELECT
                -- receita de vendas

                (SELECT CONCAT(
                    'R$:',
                    SUM(CASE WHEN " + periodoInicial + @" THEN v.total ELSE 0 END),
                    ' | R$:',
                    SUM(CASE WHEN " + periodoFim + @" THEN v.total ELSE 0 END)
                )
                FROM vendas v
                JOIN funcionarios f ON f.id = v.funcionario_id
                WHERE f.comercio_id = @idEmpresa
                ) AS receita_vendas,

                -- quantidade de itens vendidos

                (SELECT CONCAT(
                    'Qtd:',
                    IFNULL(SUM(CASE WHEN " + periodoInicial + @" THEN iv.quantidade ELSE 0 END), 0),
                    ' | Qtd:',
                    IFNULL(SUM(CASE WHEN " + periodoFim + @" THEN iv.quantidade ELSE 0 END), 0)
                )
                FROM items_venda iv
                JOIN vendas v ON v.id = iv.vendas_id
                JOIN funcionarios f ON f.id = v.funcionario_id
                WHERE f.comercio_id = @idEmpresa
                ) AS quantidade_itens_vendidos,
             
                IFNULL((SELECT CONCAT(
                    p.nome, ' (R$ ', FORMAT(SUM(iv.quantidade * iv.preco_unitario), 2), ')'
                )
                FROM items_venda iv
                JOIN vendas v ON v.id = iv.vendas_id
                JOIN funcionarios f ON f.id = v.funcionario_id
                JOIN produtos p ON p.id = iv.produtos_id
                WHERE f.comercio_id = @idEmpresa
                AND " + periodoInicial + @"
                GROUP BY p.id, p.nome
                ORDER BY SUM(iv.quantidade * iv.preco_unitario) DESC
                LIMIT 1
                ),'Sem venda') AS produto_lider_atual,
             
                IFNULL((SELECT CONCAT(
                    p.nome, ' (R$ ', FORMAT(SUM(iv.quantidade * iv.preco_unitario), 2), ')'
                )
                FROM items_venda iv
                JOIN vendas v ON v.id = iv.vendas_id
                JOIN funcionarios f ON f.id = v.funcionario_id
                JOIN produtos p ON p.id = iv.produtos_id
                WHERE f.comercio_id = @idEmpresa
                AND " + periodoFim + @"
                GROUP BY p.id, p.nome
                ORDER BY SUM(iv.quantidade * iv.preco_unitario) DESC
                LIMIT 1
                ),'Sem venda') AS produto_lider_passado,
             
                IFNULL((SELECT CONCAT(
                    'R$ ',
                    FORMAT(
                        SUM(iv.quantidade * iv.preco_unitario) /
                               NULLIF(COUNT(DISTINCT v.id), 0),
                        2
                    )
                )
                FROM items_venda iv
                JOIN vendas v ON v.id = iv.vendas_id
                JOIN funcionarios f ON f.id = v.funcionario_id
                WHERE f.comercio_id = @idEmpresa
                AND " + periodoInicial + @"
                ),'R$:0,00') AS ticket_medio_atual,
             
                IFNULL((SELECT CONCAT(
                    'R$ ',
                    FORMAT(
                        IFNULL(SUM(iv.quantidade * iv.preco_unitario) /
                               NULLIF(COUNT(DISTINCT v.id), 0), 0),
                        2
                    )
                )
                FROM items_venda iv
                JOIN vendas v ON v.id = iv.vendas_id
                JOIN funcionarios f ON f.id = v.funcionario_id
                WHERE f.comercio_id = @idEmpresa
                AND " + periodoFim + @"
                ),'R$:0,00') AS ticket_medio_passado
                FROM DUAL; ", parametros);

            label1.Text = tabela.Rows[0]["receita_vendas"].ToString();
            label2.Text = tabela.Rows[0]["quantidade_itens_vendidos"].ToString();
            label3.Text = tabela.Rows[0]["produto_lider_atual"].ToString() + " | " + tabela.Rows[0]["produto_lider_passado"].ToString();
            label4.Text = tabela.Rows[0]["ticket_medio_atual"].ToString() +" | " + tabela.Rows[0]["ticket_medio_passado"].ToString();
            Info1_dash.Text = "Receita das vendas";
            Info2_dash.Text = "Quantidade de itens vendidos";
            Info3_dash.Text = "Produto lider";
            Info4_dash.Text = "Ticket medio";
        }
        public static void carregarInfoProdutos(Label label1, Label label2, Label label3,
            Label label4, GroupBox Info1_dash, GroupBox Info2_dash,
            GroupBox Info3_dash, GroupBox Info4_dash, Dictionary<string, object> parametros, string periodo)
        {

            DataTable tabela = ExecutarSelect(@"
            SELECT
            -- Produto que gerou MENOS receita
            IFNULL((SELECT CONCAT(p.nome,' (Qtd:', SUM(iv.quantidade), ', R$',ROUND(SUM(iv.preco_unitario * iv.quantidade), 2),')')
            FROM items_venda iv
            JOIN vendas v ON v.id = iv.vendas_id
            JOIN funcionarios f ON f.id = v.funcionario_id
            JOIN produtos p ON p.id = iv.produtos_id
            WHERE f.comercio_id = @idEmpresa " + periodo + @"
            GROUP BY p.id
            ORDER BY SUM(iv.preco_unitario * iv.quantidade) ASC
            LIMIT 1), 'Sem vendas (Qtd:0, R$:0,00)') AS produto_menos_vendido,

            -- Ticket médio por produto
            IFNULL((SELECT CONCAT('R$:', ROUND(AVG(iv.preco_unitario * iv.quantidade), 2))
            FROM items_venda iv
            JOIN vendas v ON v.id = iv.vendas_id
            JOIN funcionarios f ON f.id = v.funcionario_id
            WHERE f.comercio_id = @idEmpresa " + periodo + @" ),'R$:0,00') AS ticket_medio_por_produto,

            -- Quantidade de produtos vendidos
            IFNULL((SELECT CONCAT('Qtd:', SUM(iv.quantidade) ) AS total_produtos_vendidos
            FROM items_venda iv
            JOIN vendas v ON v.id = iv.vendas_id
            JOIN funcionarios f ON f.id = v.funcionario_id
            WHERE f.comercio_id = @idEmpresa
            " + periodo + @" ),'Qtd:0') AS quantidade_produtos_vendidos,

            -- Produto mais vendido (em quantidade)
            IFNULL((SELECT CONCAT(p.nome,' (Qtd:', SUM(iv.quantidade), ', R$:',ROUND( SUM(iv.preco_unitario * iv.quantidade), 2),')')
            FROM items_venda iv
            JOIN vendas v ON v.id = iv.vendas_id
            JOIN funcionarios f ON f.id = v.funcionario_id
            JOIN produtos p ON p.id = iv.produtos_id
            WHERE f.comercio_id = @idEmpresa " + periodo + @"
            GROUP BY p.id
            ORDER BY SUM(iv.quantidade) DESC
            LIMIT 1), 'Sem venda(Qtd:0, R$:0,00)') AS produto_mais_vendido;
            ", parametros);

            label1.Text = tabela.Rows[0]["quantidade_produtos_vendidos"].ToString();
            label2.Text = tabela.Rows[0]["produto_menos_vendido"].ToString();
            label3.Text = tabela.Rows[0]["ticket_medio_por_produto"].ToString();
            label4.Text = tabela.Rows[0]["produto_mais_vendido"].ToString() ;
            Info1_dash.Text = "Quantidade de produtos vendidos"; 
            Info2_dash.Text = "Produto menos vendido (Quantidade, Receita)";
            Info3_dash.Text = "Ticket medio por produto";
            Info4_dash.Text = "Produto mais vendido (Quantidade, Receita)";
        }
        public static void carregarInfoVendas(Label label1, Label label2, Label label3,
            Label label4, GroupBox Info1_dash, GroupBox Info2_dash,
            GroupBox Info3_dash, GroupBox Info4_dash, Dictionary<string, object> parametros, string periodo)
        {

            DataTable tabela = ExecutarSelect(@"
                SELECT
                -- Total de vendas

                IFNULL((SELECT
                CONCAT('R$:', ROUND(SUM(v.total), 2), ', ' , 'Qtd:',COUNT(DISTINCT v.id))
                FROM comercios c
                JOIN funcionarios f ON f.comercio_id = c.id
                JOIN vendas v       ON v.funcionario_id = f.id
                WHERE c.id = @idEmpresa " + periodo + @" ),'R$:0,00 , Qtd: 0' ) AS total_vendas,
                -- categoria lider

                IFNULL(
                (
                    SELECT
                    CONCAT(                                                              
                        p.categoria,                                     
                        ' (R$: ',                                                        
                        ROUND(SUM(iv.quantidade * iv.preco_unitario),2),       
                        ', Qtd: ',                                                       
                        SUM(iv.quantidade),                                   
                        ')'                                                              
                    )                                                                    
                    FROM comercios c                                                     
                    JOIN funcionarios f ON f.comercio_id = c.id                          
                    JOIN vendas v       ON v.funcionario_id = f.id              
                    JOIN items_venda iv ON iv.vendas_id = v.id                           
                    JOIN produtos p     ON p.id = iv.produtos_id                         
                    WHERE c.id = @idEmpresa " + periodo + @"                             
                    GROUP BY p.categoria                                                 
                    ORDER BY                                                             
                        SUM(iv.quantidade) DESC,
                        SUM(iv.quantidade * iv.preco_unitario) DESC,
                        p.categoria
                    LIMIT 1
                ),'Sem vendas (R$: 0, Qtd: 0)') AS categoria_lider,

                -- ticket medio de vendas
                IFNULL((SELECT
                CONCAT('R$: ',FORMAT(SUM(iv.quantidade * iv.preco_unitario) / NULLIF(COUNT(DISTINCT v.id), 0),2))
                FROM comercios c
                JOIN funcionarios f ON f.comercio_id = c.id
                JOIN vendas v       ON v.funcionario_id = f.id
                JOIN items_venda iv ON iv.vendas_id = v.id
                WHERE c.id = @idEmpresa " + periodo + @"),'R$:0,00') AS ticket_medio_vendas,

                -- itens por venda
                IFNULL((SELECT CONCAT('Qtd: ', FORMAT(SUM(iv.quantidade) / COUNT(DISTINCT v.id),2))
                FROM comercios c
                JOIN funcionarios f ON f.comercio_id = c.id
                JOIN vendas v       ON v.funcionario_id = f.id
                JOIN items_venda iv ON iv.vendas_id = v.id
                WHERE c.id = @idEmpresa " + periodo + @" ),'Qtd:0') AS media_produtos_por_venda ;"
                , parametros);

            label1.Text = tabela.Rows[0]["total_vendas"].ToString();
            label2.Text = tabela.Rows[0]["categoria_lider"].ToString();
            label3.Text = tabela.Rows[0]["ticket_medio_vendas"].ToString();
            label4.Text = tabela.Rows[0]["media_produtos_por_venda"].ToString();
            Info1_dash.Text = "Total de vendas(Receita, Quantidade)";
            Info2_dash.Text = "Categoria lider(Receita, Quantidade)";
            Info3_dash.Text = "Ticket medio de vendas";
            Info4_dash.Text = "Media de produtos vendidos por pedido";
        }
        
        public static (string inicio, string fim) carregarPeriodoComparacao(ComboBox comboPeriodo_dash)
        {
            if (comboPeriodo_dash.SelectedIndex == 0)
            {
                return (
                    " v.data_venda >= DATE_FORMAT(CURDATE(), '%Y-%m-01') ",
                    @" v.data_venda >= DATE_SUB(DATE_FORMAT(CURDATE(), '%Y-%m-01'), INTERVAL 1 MONTH)
                    AND v.data_venda <  DATE_FORMAT(CURDATE(), '%Y-%m-01') ");
            }
            else if (comboPeriodo_dash.SelectedIndex == 1)
            {
                return (
                    @" v.data_venda >= DATE_SUB(DATE_FORMAT(CURDATE(), '%Y-%m-01'), INTERVAL 1 MONTH)
                    AND v.data_venda <  DATE_FORMAT(CURDATE(), '%Y-%m-01') ",
                    @" v.data_venda >= DATE_SUB(DATE_FORMAT(CURDATE(), '%Y-%m-01'), INTERVAL 2 MONTH)
                    AND v.data_venda <  DATE_SUB(DATE_FORMAT(CURDATE(), '%Y-%m-01'), INTERVAL 1 MONTH) ");
            }
            else if (comboPeriodo_dash.SelectedIndex == 2)
            {
                return (
                    @" v.data_venda >= DATE_FORMAT(CURDATE(), '%Y-01-01')",
                    @"v.data_venda >= DATE_SUB(DATE_FORMAT(CURDATE(), '%Y-01-01'), INTERVAL 1 YEAR)
                    AND v.data_venda < DATE_FORMAT(CURDATE(), '%Y-01-01')
 ");
            }
            else if (comboPeriodo_dash.SelectedIndex == 3)
            {
                return (
                    @" v.data_venda >= DATE_SUB(DATE_FORMAT(CURDATE(), '%Y-01-01'), INTERVAL 1 YEAR)
                    AND v.data_venda <  DATE_FORMAT(CURDATE(), '%Y-01-01')",
                    @" v.data_venda >= DATE_SUB(DATE_FORMAT(CURDATE(), '%Y-01-01'), INTERVAL 2 YEAR)
                    AND v.data_venda <  DATE_SUB(DATE_FORMAT(CURDATE(), '%Y-01-01'), INTERVAL 1 YEAR)");
            }
            return ("1=0", "1=0"); 
        }
        public static string carregarPeriodoIntervalo(MaskedTextBox maskedInicio,MaskedTextBox maskedFim,Dictionary<string, object> parametros)
        {
            if (!DateTime.TryParse(maskedInicio.Text, out DateTime dataInicio))
                return "";

            if (!DateTime.TryParse(maskedFim.Text, out DateTime dataFim))
                return "";

            if (dataFim < dataInicio)
                throw new Exception("Data final não pode ser menor que a inicial.");

            parametros["@dataInicio"] = dataInicio;
            parametros["@dataFim"] = dataFim.AddDays(1);

            return " AND v.data_venda >= @dataInicio AND v.data_venda < @dataFim ";
        }

        public static void load_grafico_produtos( PlotView grafico1, PlotView grafico2, Dictionary<string, object> parametros, string periodo)
        {
            // -------------------- grafico 1, PRODUTOS ---------------
            PlotModel modeloTopVenda = new PlotModel
            {
                Title = "Top 5 produtos mais vendidos",
                TitleFontWeight = FontWeights.Bold,
                TitleFontSize = 20,
                TextColor = OxyColors.White,
                PlotAreaBorderColor = OxyColors.White
            };
            var categoryAxis1 = new CategoryAxis
            {
                Position = AxisPosition.Left,
                Title = "Produtos",
                TitleFontSize = 14,
                TitleFontWeight = FontWeights.Bold,
                TicklineColor = OxyColors.White,
                TextColor = OxyColors.White
            };
            var linearAxis1 = new LinearAxis
            {
                Position = AxisPosition.Bottom,
                Title = "Quantidade vendida",
                TitleFontSize = 14,
                TitleFontWeight = FontWeights.Bold,
                TicklineColor = OxyColors.White,
                TextColor = OxyColors.White,
                MinimumPadding = 0,
                AbsoluteMinimum = 0
            };
            var barSeries1 = new BarSeries
            {
                Title = "Vendas",
                FillColor = OxyColors.RoyalBlue,
                LabelPlacement = LabelPlacement.Inside,
                LabelFormatString = "Qnt: {0}"
            };
            DataTable tabela1 = func_dashboard.ExecutarSelect(@"SELECT 
            p.id,
            p.nome,
            SUM(iv.quantidade) AS total_vendido
            FROM items_venda iv
            JOIN produtos p ON p.id = iv.produtos_id
            JOIN vendas v ON v.id = iv.vendas_id
            JOIN funcionarios f ON f.id = v.funcionario_id
            WHERE f.comercio_id = @idEmpresa "+ periodo +@" 
            GROUP BY p.id, p.nome
            ORDER BY total_vendido DESC
            LIMIT 5;
            ", parametros);
            foreach (DataRow row in tabela1.Rows)
            {
                categoryAxis1.Labels.Add(row["nome"].ToString());
                barSeries1.Items.Add(new BarItem { Value = Convert.ToInt32(row["total_vendido"]) } );
            }

            modeloTopVenda.Axes.Add(categoryAxis1);
            modeloTopVenda.Axes.Add(linearAxis1);
            modeloTopVenda.Series.Add(barSeries1);
            if (!barSeries1.Items.Any()) 
            {
                modeloTopVenda.Annotations.Add(new TextAnnotation
                {
                    Text = "Sem vendas",
                    TextPosition = new DataPoint(0.25, -0.05),

                    FontSize = 28,
                    FontWeight = FontWeights.Bold,
                    TextColor = OxyColors.White
                });
            }


            grafico1.Model = modeloTopVenda;
            //----------- grafico 2  PRODUTOS --------------

            PlotModel modeloTopReceita = new PlotModel
            {
                Title = "Top 5 produtos com mais receita",
                TitleFontSize = 20,
                TitleFontWeight = FontWeights.Bold,
                TextColor = OxyColors.White,
                PlotAreaBorderColor = OxyColors.White
            };
            var categoryAxis2 = new CategoryAxis
            {
                Position = AxisPosition.Left,
                Title = "Produtos",
                TitleFontSize = 14,
                TitleFontWeight = FontWeights.Bold,
                TicklineColor = OxyColors.White,
                TextColor = OxyColors.White
            };
            var linearAxis2 = new LinearAxis
            {
                Position = AxisPosition.Bottom,
                Title = "Receita total",
                TitleFontSize = 14,
                TitleFontWeight = FontWeights.Bold,
                TicklineColor = OxyColors.White,
                TextColor = OxyColors.White,
                MinimumPadding = 0,
                AbsoluteMinimum = 0
            };
            var barSeries2 = new BarSeries
            {
                Title = "receita",
                FillColor = OxyColors.RoyalBlue,
                LabelPlacement = LabelPlacement.Inside,
                LabelFormatString = "R$: {0:0.00}"
            };
            DataTable tabela2 = func_dashboard.ExecutarSelect(@"
            SELECT
                p.id AS produto_id,
                p.nome AS produto,
                SUM(iv.quantidade * iv.preco_unitario) AS receita_total
            FROM items_venda iv
            JOIN produtos p       ON p.id = iv.produtos_id
            JOIN vendas v         ON v.id = iv.vendas_id
            JOIN funcionarios f   ON f.id = v.funcionario_id
            WHERE f.comercio_id = @idEmpresa "+ periodo + @"
            GROUP BY p.id, p.nome
            ORDER BY receita_total DESC
            LIMIT 5;

            ", parametros);
            foreach (DataRow row in tabela2.Rows)
            {
                categoryAxis2.Labels.Add(row["produto"].ToString());
                barSeries2.Items.Add(new BarItem { Value = Convert.ToDouble(row["receita_total"]) });
            }

            modeloTopReceita.Axes.Add(categoryAxis2);                                                      
            modeloTopReceita.Axes.Add(linearAxis2);                                                        
            modeloTopReceita.Series.Add(barSeries2);
            if (!barSeries2.Items.Any())
            {
                modeloTopReceita.Annotations.Add(new TextAnnotation
                {
                    Text = "Sem vendas",
                    TextPosition = new DataPoint(0.25, -0.05),

                    FontSize = 28,
                    FontWeight = FontWeights.Bold,
                    TextColor = OxyColors.White
                });
            }

            grafico2.Model = modeloTopReceita;                                                             
        }
        public static void load_grafico_vendas(PlotView grafico1, PlotView grafico2, Dictionary<string, object> parametros, string periodo)
        {
            // ---------------- grafico 1, VENDAS -------------------
            PlotModel modeloLinha = new PlotModel
            {
                Title = "Quantidade de vendas por horário",
                TitleFontSize = 20,
                TitleFontWeight = FontWeights.Bold,
                TextColor = OxyColors.White,
                PlotAreaBorderColor = OxyColors.White
            };
            var eixoX = new LinearAxis
            {
                Position = AxisPosition.Bottom,
                Title = "Hora do dia",
                TitleFontSize = 14,
                TitleFontWeight = FontWeights.Bold,
                Minimum = 1,
                Maximum = 24,
                MajorStep = 1,
                MinorStep = 1,
                TextColor = OxyColors.White,
                TicklineColor = OxyColors.White,
                LabelFormatter = h => $"{h:0}"
            };
            var eixoY = new LinearAxis
            {
                Position = AxisPosition.Left,
                Title = "Quantidade de vendas",
                TitleFontSize = 14,
                TitleFontWeight = FontWeights.Bold,
                Minimum = 0,
                TextColor = OxyColors.White,
                TicklineColor = OxyColors.White
            };
            var linhaVendas = new LineSeries
            {
                Title = "Vendas",
                Color = OxyColors.RoyalBlue,
                StrokeThickness = 2,
                MarkerType = MarkerType.Circle,
                MarkerSize = 4,
                MarkerFill = OxyColors.White
            };
            DataTable tabela = func_dashboard.ExecutarSelect(@"
            SELECT
                HOUR(v.data_venda) AS hora,
                COUNT(v.id) AS total_vendas
            FROM vendas v
            JOIN funcionarios f ON f.id = v.funcionario_id
            WHERE f.comercio_id = @idEmpresa "+ periodo +@"
            GROUP BY HOUR(v.data_venda)
            ORDER BY hora;
            ", parametros);
            Dictionary<int, int> vendasPorHora = new Dictionary<int, int>();

            foreach (DataRow row in tabela.Rows)
            {
                int hora = Convert.ToInt32(row["hora"]);
                int total = Convert.ToInt32(row["total_vendas"]);
                vendasPorHora[hora] = total;
            }

            for (int h = 1; h < 24; h++)
            {
                int total = vendasPorHora.ContainsKey(h) ? vendasPorHora[h] : 0;
                linhaVendas.Points.Add(new DataPoint(h, total));
            }
            modeloLinha.Axes.Add(eixoX);
            modeloLinha.Axes.Add(eixoY);
            modeloLinha.Series.Add(linhaVendas);
            if (!linhaVendas.Points.Any(p=> p.Y >0))
            {
                modeloLinha.Annotations.Add(new TextAnnotation
                {
                    Text = "Sem vendas",
                    TextPosition = new DataPoint(12, 0.21),

                    FontSize = 28,
                    FontWeight = FontWeights.Bold,
                    TextColor = OxyColors.White
                });
            }
            grafico1.Model = modeloLinha;

            // ---------------------  Grafico 2, VENDAS -------------------

            PlotModel modeloCategorias = new PlotModel
            {
                Title = "Categorias mais vendidas",
                TitleFontSize = 20,
                TitleFontWeight = FontWeights.Bold,
                TextColor = OxyColors.White,
                PlotAreaBorderColor = OxyColors.White
            };
            var eixoCategorias = new CategoryAxis
            {
                Position = AxisPosition.Left,
                Title = "Categorias",
                TitleFontSize = 14,
                TitleFontWeight = FontWeights.Bold,
                TextColor = OxyColors.White,
                TicklineColor = OxyColors.White
            };

            var eixoQuantidade = new LinearAxis
            {
                Position = AxisPosition.Bottom,
                Title = "Quantidade vendida",
                TitleFontSize = 14,
                TitleFontWeight = FontWeights.Bold,
                Minimum = 0,
                TextColor = OxyColors.White,
                TicklineColor = OxyColors.White
            };
            var barSeries = new BarSeries
            {
                Title = "Vendas",
                FillColor = OxyColors.RoyalBlue,
                LabelPlacement = LabelPlacement.Inside,
                LabelFormatString = "{0}"
            };
            DataTable table = func_dashboard.ExecutarSelect(@"
            SELECT
                p.categoria,
                SUM(iv.quantidade) AS total_vendido
            FROM items_venda iv
            JOIN produtos p     ON p.id = iv.produtos_id
            JOIN vendas v       ON v.id = iv.vendas_id
            JOIN funcionarios f ON f.id = v.funcionario_id
            WHERE f.comercio_id = @idEmpresa
              AND p.categoria IS NOT NULL "+ periodo +@"
            GROUP BY p.categoria
            ORDER BY total_vendido DESC;
            ", parametros);

            foreach (DataRow row in table.Rows)
            {
                eixoCategorias.Labels.Add(row["categoria"].ToString());
                barSeries.Items.Add(new BarItem
                {
                    Value = Convert.ToDouble(row["total_vendido"])
                });
            }
            modeloCategorias.Axes.Add(eixoCategorias);
            modeloCategorias.Axes.Add(eixoQuantidade);
            modeloCategorias.Series.Add(barSeries);
            if (!barSeries.Items.Any())
            {
                modeloCategorias.Annotations.Add(new TextAnnotation
                {
                    Text = "Sem vendas",
                    TextPosition = new DataPoint(0.25, -0.05),

                    FontSize = 28,
                    FontWeight = FontWeights.Bold,
                    TextColor = OxyColors.White
                });
            }

            grafico2.Model = modeloCategorias;
        }
        public static void load_grafico_comparacao(PlotView grafico1, PlotView grafico2, Dictionary<string, object> parametros, string periodoAtual, string periodoPassado, Label lblproximo, Label lbllonge)
        {
            // --------------- grafico 1, COMPARACAO -----------------
            

            PlotModel modeloComparativo = new PlotModel
            {
                Title = "Quantidade vendas(Atual x Passado)",
                TitleFontSize = 20,
                TitleFontWeight = FontWeights.Bold,
                TextColor = OxyColors.White,
                PlotAreaBorderColor = OxyColors.White
            };
            var eixoY = new CategoryAxis
            {
                Position = AxisPosition.Left,
                Title = "Período",
                TitleFontSize = 14,
                TitleFontWeight = FontWeights.Bold,
                TextColor = OxyColors.White,
                TicklineColor = OxyColors.White
            };

            var eixoX = new LinearAxis
            {
                Position = AxisPosition.Bottom,
                Title = "Quantidade de vendas",
                TitleFontSize = 14,
                TitleFontWeight = FontWeights.Bold,
                Minimum = 0,
                TextColor = OxyColors.White,
                TicklineColor = OxyColors.White
            };

            var barraSeries = new BarSeries
            {
                Title = "Vendas",
                FillColor = OxyColors.RoyalBlue,
                LabelPlacement = LabelPlacement.Inside,
                LabelFormatString = "{0}"
            };
            DataTable tabela = func_dashboard.ExecutarSelect(@"
                SELECT
                'Atual' AS periodo,
                COUNT(v.id) AS total_vendas
            FROM vendas v
            JOIN funcionarios f ON f.id = v.funcionario_id
            WHERE f.comercio_id = @idEmpresa
              AND "+ periodoAtual+@"
            
            UNION ALL
            
            SELECT
                'Passado' AS periodo,
                COUNT(v.id) AS total_vendas
            FROM vendas v
            JOIN funcionarios f ON f.id = v.funcionario_id
            WHERE f.comercio_id = @idEmpresa
              AND "+ periodoPassado+@"
            
            ", parametros);

            foreach (DataRow row in tabela.Rows)
            {
                eixoY.Labels.Add(row["periodo"].ToString());
                barraSeries.Items.Add(new BarItem{ Value = Convert.ToDouble(row["total_vendas"])});
            }

            bool atualSemVenda = barraSeries.Items[0].Value == 0;
            bool longeSemVenda = barraSeries.Items[1].Value == 0;
            if (atualSemVenda)
            {
                modeloComparativo.Annotations.Add(new TextAnnotation
                {
                    Text = "Sem venda",
                    TextPosition = new DataPoint(3.50, -0.10),
                    FontSize = 22,
                    TextColor = OxyColors.White
                });
            }
            else if (longeSemVenda)
            {
                modeloComparativo.Annotations.Add(new TextAnnotation
                {
                    Text = "Sem venda",
                    TextPosition = new DataPoint(3.5, 0.85),
                    FontSize = 22,
                    TextColor = OxyColors.White
                });
            }

            modeloComparativo.Axes.Add(eixoX);
            modeloComparativo.Axes.Add(eixoY);
            modeloComparativo.Series.Add(barraSeries);

            grafico1.Model = modeloComparativo;

            // -------------------- grafico 2, COMPARACAO -------------------

            PlotModel modeloDiario = new PlotModel
            {
                Title = "Comparação de vendas por dia do mês",
                TitleFontSize = 20,
                TitleFontWeight = FontWeights.Bold,
                TextColor = OxyColors.White,
                PlotAreaBorderColor = OxyColors.White
            };

            var eixoDias = new LinearAxis
            {
                Position = AxisPosition.Bottom,
                Title = "Dia do mês",
                TitleFontSize = 14,
                TitleFontWeight = FontWeights.Bold,
                Minimum = 1,
                Maximum = 31,
                MajorStep = 1,
                MinorStep = 1,
                TextColor = OxyColors.White,
                TicklineColor = OxyColors.White
            };
            var eixoQuantidade = new LinearAxis
            {
                Position = AxisPosition.Left,
                Title = "Quantidade de vendas",
                TitleFontSize = 14,
                TitleFontWeight = FontWeights.Bold,
                Minimum = 0,
                TextColor = OxyColors.White,
                TicklineColor = OxyColors.White
            };
            var linhaAtual = new LineSeries
            {
                Title = "Atual",
                Color = OxyColors.SkyBlue,
                StrokeThickness = 2,
                MarkerType = MarkerType.Circle
            };

            var linhaPassado = new LineSeries
            {
                Title = "Passado",
                Color = OxyColors.Orange,
                StrokeThickness = 2,
                MarkerType = MarkerType.Square
            };
            DataTable table = func_dashboard.ExecutarSelect(@"
            SELECT
                DAY(v.data_venda) AS dia,
                'Mês Atual' AS periodo,
                COUNT(v.id) AS total_vendas
            FROM vendas v
            JOIN funcionarios f ON f.id = v.funcionario_id
            WHERE f.comercio_id = @idEmpresa
              AND "+ periodoAtual+ @"
            GROUP BY DAY(v.data_venda)

            UNION ALL

            SELECT
                DAY(v.data_venda) AS dia,
                'Mês Passado' AS periodo,
                COUNT(v.id) AS total_vendas
            FROM vendas v
            JOIN funcionarios f ON f.id = v.funcionario_id
            WHERE f.comercio_id = @idEmpresa
              AND "+ periodoPassado+@"
            GROUP BY DAY(v.data_venda)
            ORDER BY dia, periodo;
            ", parametros);

            Dictionary<int, int> Atual = new();
            Dictionary<int, int> Passado = new();

            foreach (DataRow row in table.Rows)
            {
                int dia = Convert.ToInt32(row["dia"]);
                int total = Convert.ToInt32(row["total_vendas"]);
                string tempo = row["periodo"].ToString();

                if (tempo == "Mês Atual")
                    Atual[dia] = total;
                else
                    Passado[dia] = total;
            }

            for (int d = 1; d <= 31; d++)
            {
                linhaAtual.Points.Add(
                    new DataPoint(d, Atual.ContainsKey(d) ? Atual[d] : 0)
                );

                linhaPassado.Points.Add(
                    new DataPoint(d, Passado.ContainsKey(d) ? Passado[d] : 0)
                );
            }

            bool temVendaAtual = linhaAtual.Points.Any(p => p.Y > 0);
            bool temVendaPassado = linhaPassado.Points.Any(p => p.Y > 0);

            lblproximo.Text = temVendaAtual ? "Data Inicio" : "Sem venda";
            lbllonge.Text = temVendaPassado ? "Data Fim" : "Sem venda";

            modeloDiario.Axes.Add(eixoDias);
            modeloDiario.Axes.Add(eixoQuantidade);
            modeloDiario.Series.Add(linhaAtual);
            modeloDiario.Series.Add(linhaPassado);
            grafico2.Model = modeloDiario;
        }
        
        public static DataTable ExecutarSelect(string query, Dictionary<string, object> Parametros)         
    {                                                                                                  
        using (MySqlConnection conn = new MySqlConnection(Banco.caminho))                              
        {                                                                                              
            conn.Open();                                                                               
            using (MySqlCommand cmd = new MySqlCommand(query, conn))                                   
            {
                if (Parametros != null)
                {
                    foreach (var p in Parametros)
                    {
                        cmd.Parameters.AddWithValue(p.Key, p.Value);
                    }
                }
                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        DataTable tabela = new DataTable();
                        da.Fill(tabela);
                        return tabela;
                    }
                }
            }
        }
    }
}
