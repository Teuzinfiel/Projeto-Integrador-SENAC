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
using System.Diagnostics;
using System.Globalization;
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
            GroupBox Info3_dash, GroupBox Info4_dash, Dictionary<string, object> parametros)
        {
            DataTable tabela = ExecutarSelect(@"
                SELECT
            -- ================== RECEITA ==================
            (SELECT CONCAT(
                'R$: ',
                SUM(CASE 
                    WHEN v.data_venda BETWEEN @dataInicio1Periodo AND @dataFim1Periodo 
                    THEN v.total ELSE 0 END),
                ' | R$: ',
                SUM(CASE 
                    WHEN v.data_venda BETWEEN @dataInicio2Periodo AND @dataFim2Periodo
                    THEN v.total ELSE 0 END)
            )
            FROM vendas v
            JOIN funcionarios f ON f.id = v.funcionario_id
            WHERE f.comercio_id = @idEmpresa
            ) AS receita_vendas,
            
            -- ================== QUANTIDADE ITENS ==================
            (SELECT CONCAT(
                'Qtd: ',
                IFNULL(SUM(CASE 
                    WHEN v.data_venda BETWEEN @dataInicio1Periodo AND @dataFim1Periodo
                    THEN iv.quantidade ELSE 0 END), 0),
                ' | Qtd: ',
                IFNULL(SUM(CASE 
                    WHEN v.data_venda BETWEEN @dataInicio2Periodo AND @dataFim2Periodo
                    THEN iv.quantidade ELSE 0 END), 0)
            )
            FROM items_venda iv
            JOIN vendas v ON v.id = iv.vendas_id
            JOIN funcionarios f ON f.id = v.funcionario_id
            WHERE f.comercio_id = @idEmpresa
            ) AS quantidade_itens_vendidos,
            
            -- ================== PRODUTO LÍDER ATUAL ==================
            IFNULL((
            SELECT CONCAT(
                p.nome, ' (R$ ', FORMAT(SUM(iv.quantidade * iv.preco_unitario), 2), ')'
            )
            FROM items_venda iv
            JOIN vendas v ON v.id = iv.vendas_id
            JOIN funcionarios f ON f.id = v.funcionario_id
            JOIN produtos p ON p.id = iv.produtos_id
            WHERE f.comercio_id = @idEmpresa
            AND v.data_venda BETWEEN @dataInicio1Periodo AND @dataFim1Periodo
            GROUP BY p.id, p.nome
            ORDER BY SUM(iv.quantidade * iv.preco_unitario) DESC
            LIMIT 1
            ),'Sem venda') AS produto_lider_atual,
            
            -- ================== PRODUTO LÍDER PASSADO ==================
            IFNULL((
            SELECT CONCAT(
                p.nome, ' (R$ ', FORMAT(SUM(iv.quantidade * iv.preco_unitario), 2), ')'
            )
            FROM items_venda iv
            JOIN vendas v ON v.id = iv.vendas_id
            JOIN funcionarios f ON f.id = v.funcionario_id
            JOIN produtos p ON p.id = iv.produtos_id
            WHERE f.comercio_id = @idEmpresa
            AND v.data_venda BETWEEN @dataInicio2Periodo AND @dataFim2Periodo
            GROUP BY p.id, p.nome
            ORDER BY SUM(iv.quantidade * iv.preco_unitario) DESC
            LIMIT 1
            ),'Sem venda') AS produto_lider_passado,
            
            -- ================== TICKET MÉDIO ATUAL ==================
            IFNULL((
            SELECT CONCAT(
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
            AND v.data_venda BETWEEN @dataInicio1Periodo AND @dataFim1Periodo
            ),'R$ 0,00') AS ticket_medio_atual,
            
            -- ================== TICKET MÉDIO PASSADO ==================
            IFNULL((
            SELECT CONCAT(
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
            AND v.data_venda BETWEEN @dataInicio2Periodo AND @dataFim2Periodo
            ),'R$ 0,00') AS ticket_medio_passado
            FROM DUAL;", parametros);
            if (tabela.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum dado encontrado para os períodos selecionados.");
                return;
            }
            label1.Text = tabela.Rows[0]["receita_vendas"].ToString();
            label2.Text = tabela.Rows[0]["quantidade_itens_vendidos"].ToString();
            label3.Text = tabela.Rows[0]["produto_lider_atual"].ToString() + " | " + tabela.Rows[0]["produto_lider_passado"].ToString();
            label4.Text = tabela.Rows[0]["ticket_medio_atual"].ToString() + " | " + tabela.Rows[0]["ticket_medio_passado"].ToString();
            Info1_dash.Text = "Receita das vendas";
            Info2_dash.Text = "Quantidade de itens vendidos";
            Info3_dash.Text = "Produto lider";
            Info4_dash.Text = "Ticket medio";
        }
        public static void carregarInfoProdutos(Label label1, Label label2, Label label3,
            Label label4, GroupBox Info1_dash, GroupBox Info2_dash,
            GroupBox Info3_dash, GroupBox Info4_dash, Dictionary<string, object> parametros)
        {

            string query = @"
            SELECT
            -- Produto que gerou MENOS receita
            IFNULL((SELECT CONCAT(p.nome,' (Qtd:', SUM(iv.quantidade), ', R$',ROUND(SUM(iv.preco_unitario * iv.quantidade), 2),')')
            FROM items_venda iv
            JOIN vendas v ON v.id = iv.vendas_id
            JOIN funcionarios f ON f.id = v.funcionario_id
            JOIN produtos p ON p.id = iv.produtos_id
            WHERE f.comercio_id = @idEmpresa AND DATE(v.data_venda) BETWEEN @dataInicio AND @dataFim
            GROUP BY p.id
            ORDER BY SUM(iv.preco_unitario * iv.quantidade) ASC
            LIMIT 1), 'Sem vendas (Qtd:0, R$:0,00)') AS produto_menos_vendido,

            -- Ticket médio por produto
            IFNULL((
            SELECT CONCAT('R$:', ROUND(SUM(iv.quantidade * iv.preco_unitario) / NULLIF(SUM(iv.quantidade), 0), 2))
            FROM items_venda iv
            JOIN vendas v ON v.id = iv.vendas_id
            JOIN funcionarios f ON f.id = v.funcionario_id
            WHERE f.comercio_id = @idEmpresa AND DATE(v.data_venda) BETWEEN @dataInicio AND @dataFim
            ), 'R$:0,00') AS ticket_medio_por_produto,

            -- Quantidade de produtos vendidos
            IFNULL((SELECT CONCAT('Qtd:', SUM(iv.quantidade) ) AS total_produtos_vendidos
            FROM items_venda iv
            JOIN vendas v ON v.id = iv.vendas_id
            JOIN funcionarios f ON f.id = v.funcionario_id
            WHERE f.comercio_id = @idEmpresa
            AND DATE(v.data_venda) BETWEEN @dataInicio AND @dataFim
            ),'Qtd:0') AS quantidade_produtos_vendidos,

            -- Produto mais vendido (em quantidade)
            IFNULL((SELECT CONCAT(p.nome,' (Qtd:', SUM(iv.quantidade), ', R$:',ROUND( SUM(iv.preco_unitario * iv.quantidade), 2),')')
            FROM items_venda iv
            JOIN vendas v ON v.id = iv.vendas_id
            JOIN funcionarios f ON f.id = v.funcionario_id
            JOIN produtos p ON p.id = iv.produtos_id
            WHERE f.comercio_id = @idEmpresa AND DATE(v.data_venda) BETWEEN @dataInicio AND @dataFim
            GROUP BY p.id
            ORDER BY SUM(iv.quantidade) DESC
            LIMIT 1), 'Sem venda(Qtd:0, R$:0,00)') AS produto_mais_vendido;
            ";
            try
            {
                DataTable tabela = ExecutarSelect(query, parametros);

                if (tabela.Rows.Count > 0)
                {
                    label1.Text = tabela.Rows[0]["quantidade_produtos_vendidos"].ToString();
                    label2.Text = tabela.Rows[0]["produto_menos_vendido"].ToString();
                    label3.Text = tabela.Rows[0]["ticket_medio_por_produto"].ToString();
                    label4.Text = tabela.Rows[0]["produto_mais_vendido"].ToString();
                }
                Info1_dash.Text = "Quantidade de produtos vendidos";
                Info2_dash.Text = "Produto menos vendido (Quantidade, Receita)";
                Info3_dash.Text = "Ticket medio por produto";
                Info4_dash.Text = "Produto mais vendido (Quantidade, Receita)";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro em carregarInfoProdutos: {ex.Message}");
            }
        }
        public static void carregarInfoVendas(Label label1, Label label2, Label label3,
            Label label4, GroupBox Info1_dash, GroupBox Info2_dash,
            GroupBox Info3_dash, GroupBox Info4_dash, Dictionary<string, object> parametros)
        {
            string query = @"
            SELECT
            -- Total de vendas
            IFNULL((
                SELECT CONCAT('R$:', ROUND(SUM(v.total), 2), ', Qtd:', COUNT(DISTINCT v.id))
                FROM vendas v
                JOIN funcionarios f ON f.id = v.funcionario_id
                WHERE f.comercio_id = @idEmpresa  
                AND DATE(v.data_venda) BETWEEN @dataInicio AND @dataFim
            ), 'R$:0,00, Qtd:0') AS total_vendas,
            
            -- Categoria líder (em receita e quantidade)
            IFNULL((
                SELECT CONCAT(
                    p.categoria, 
                    ' (R$:', ROUND(SUM(iv.quantidade * iv.preco_unitario), 2), 
                    ', Qtd:', SUM(iv.quantidade), ')'
                )
                FROM items_venda iv
                JOIN vendas v ON v.id = iv.vendas_id
                JOIN funcionarios f ON f.id = v.funcionario_id
                JOIN produtos p ON p.id = iv.produtos_id
                WHERE f.comercio_id = @idEmpresa  
                AND DATE(v.data_venda) BETWEEN @dataInicio AND @dataFim
                GROUP BY p.categoria
                ORDER BY SUM(iv.quantidade * iv.preco_unitario) DESC
                LIMIT 1
            ), 'Sem vendas (R$:0,00, Qtd:0)') AS categoria_lider,
            
            -- Ticket médio de vendas
            IFNULL((
                SELECT CONCAT('R$:', ROUND(SUM(iv.quantidade * iv.preco_unitario) / NULLIF(COUNT(DISTINCT v.id), 0), 2))
                FROM items_venda iv
                JOIN vendas v ON v.id = iv.vendas_id
                JOIN funcionarios f ON f.id = v.funcionario_id
                WHERE f.comercio_id = @idEmpresa  
                AND DATE(v.data_venda) BETWEEN @dataInicio AND @dataFim
            ), 'R$:0,00') AS ticket_medio_vendas,
            
            -- Itens por venda
            IFNULL((
                SELECT CONCAT('Qtd:', ROUND(SUM(iv.quantidade) / COUNT(DISTINCT v.id), 2))
                FROM items_venda iv
                JOIN vendas v ON v.id = iv.vendas_id
                JOIN funcionarios f ON f.id = v.funcionario_id
                WHERE f.comercio_id = @idEmpresa  
                AND DATE(v.data_venda) BETWEEN @dataInicio AND @dataFim
            ), 'Qtd:0') AS media_produtos_por_venda";

            try
            {
                DataTable tabela = ExecutarSelect(query, parametros);

                if (tabela.Rows.Count > 0)
                {
                    label1.Text = tabela.Rows[0]["total_vendas"].ToString();
                    label2.Text = tabela.Rows[0]["categoria_lider"].ToString();
                    label3.Text = tabela.Rows[0]["ticket_medio_vendas"].ToString();
                    label4.Text = tabela.Rows[0]["media_produtos_por_venda"].ToString();
                }
                else
                {
                    label1.Text = "R$:0,00, Qtd:0";
                    label2.Text = "Sem vendas (R$:0,00, Qtd:0)";
                    label3.Text = "R$:0,00";
                    label4.Text = "Qtd:0";
                }

                Info1_dash.Text = "Total de vendas (Receita, Quantidade)";
                Info2_dash.Text = "Categoria líder (Receita, Quantidade)";
                Info3_dash.Text = "Ticket médio de vendas";
                Info4_dash.Text = "Média de produtos vendidos por pedido";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro em carregarInfoVendas: {ex.Message}");
            }
        }
        public static bool AtualizarPeriodo(MaskedTextBox maskedInicio, MaskedTextBox maskedFim, Dictionary<string, object> param_idEmpresa)
        {

            if (!DateTime.TryParseExact(maskedInicio.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime inicio))
                return false;

            if (!DateTime.TryParseExact(maskedFim.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fim))
                return false;

            if (inicio > fim)
                return false;

            param_idEmpresa.Remove("@dataInicio");
            param_idEmpresa.Remove("@dataFim");

            param_idEmpresa["@dataInicio"] = inicio.ToString("yyyy-MM-dd");
            param_idEmpresa["@dataFim"] = fim.ToString("yyyy-MM-dd");

            return true;
        }
        public static bool AtualizarPeriodoComparacao( MaskedTextBox masked1PeriodoInicio,MaskedTextBox masked1PeriodoFim,MaskedTextBox masked2PeriodoInicio, MaskedTextBox masked2PeriodoFim,Dictionary<string, object> param_idEmpresa)
        {
            if (!DateTime.TryParseExact(masked1PeriodoInicio.Text, "dd/MM/yyyy",
                CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime inicio1Periodo))
                return false;

            if (!DateTime.TryParseExact(masked1PeriodoFim.Text, "dd/MM/yyyy",
                CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fim1Periodo))
                return false;

            if (!DateTime.TryParseExact(masked2PeriodoInicio.Text, "dd/MM/yyyy",
                CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime inicio2Periodo))
                return false;

            if (!DateTime.TryParseExact(masked2PeriodoFim.Text, "dd/MM/yyyy",
                CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fim2Periodo))
                return false;

            inicio1Periodo = inicio1Periodo.Date;
            fim1Periodo = fim1Periodo.Date.AddDays(1).AddSeconds(-1); 

            inicio2Periodo = inicio2Periodo.Date;
            fim2Periodo = fim2Periodo.Date.AddDays(1).AddSeconds(-1);


            if (inicio1Periodo > fim1Periodo)
                return false;

            if (inicio2Periodo > fim2Periodo)
                return false;

            param_idEmpresa["@dataInicio1Periodo"] = inicio1Periodo;
            param_idEmpresa["@dataFim1Periodo"] = fim1Periodo;

            param_idEmpresa["@dataInicio2Periodo"] = inicio2Periodo;
            param_idEmpresa["@dataFim2Periodo"] = fim2Periodo;

            return true;
        }

        public static void load_grafico_produtos(PlotView grafico1, PlotView grafico2, Dictionary<string, object> parametros)
        {
            // -------------------- grafico 1, PRODUTOS ---------------
            var controller = new PlotController();
            controller.UnbindAll();

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
            WHERE f.comercio_id = @idEmpresa
            AND v.data_venda >= @dataInicio
            AND v.data_venda < DATE_ADD(@dataFim, INTERVAL 1 DAY)

            GROUP BY p.id, p.nome
            ORDER BY total_vendido DESC
            LIMIT 5;
            ", parametros);
            foreach (DataRow row in tabela1.Rows)
            {
                categoryAxis1.Labels.Add(row["nome"].ToString());
                barSeries1.Items.Add(new BarItem { Value = Convert.ToInt32(row["total_vendido"]) });
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
            grafico1.Controller = controller;
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
            WHERE f.comercio_id = @idEmpresa
            AND v.data_venda >= @dataInicio
            AND v.data_venda < DATE_ADD(@dataFim, INTERVAL 1 DAY)

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
            grafico2.Controller = controller;
        }
        public static void load_grafico_vendas(PlotView grafico1, PlotView grafico2, Dictionary<string, object> parametros)
        {
            // ---------------- grafico 1, VENDAS -------------------
            var controller = new PlotController();
            controller.UnbindAll();
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
                MinorStep = 1,
                MajorStep = 1,
                StringFormat = "0",
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
            WHERE f.comercio_id = @idEmpresa
            AND v.data_venda >= @dataInicio
            AND v.data_venda < DATE_ADD(@dataFim, INTERVAL 1 DAY)

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

            for (int h = 1; h <= 23; h++)
            {
                int total = vendasPorHora.ContainsKey(h) ? vendasPorHora[h] : 0;
                linhaVendas.Points.Add(new DataPoint(h, total));
            }
            modeloLinha.Axes.Add(eixoX);
            modeloLinha.Axes.Add(eixoY);
            modeloLinha.Series.Add(linhaVendas);
            if (!linhaVendas.Points.Any(p => p.Y > 0))
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
            grafico1.Controller = controller;

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
            AND v.data_venda >= @dataInicio
            AND v.data_venda < DATE_ADD(@dataFim, INTERVAL 1 DAY)

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
            grafico2.Controller = controller;
        }
        public static void load_grafico_comparacao(PlotView grafico1, PlotView grafico2, Dictionary<string, object> parametros, Label lblproximo, Label lbllonge)
        {
            // --------------- grafico 1, COMPARACAO -----------------
            var controller = new PlotController();
            controller.UnbindAll();

            PlotModel modeloComparativo = new PlotModel
            {
                Title = "Quantidade vendas",
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
               
                SELECT '2ºPeríodo' AS periodo,
                IFNULL(COUNT(v.id),0) AS total_vendas
                FROM vendas v
                JOIN funcionarios f ON f.id = v.funcionario_id
                WHERE f.comercio_id = @idEmpresa
                AND v.data_venda BETWEEN @dataInicio2Periodo AND @dataFim2Periodo
                
                UNION ALL

                SELECT '1ºPeríodo' AS periodo,
                IFNULL(COUNT(v.id),0) AS total_vendas
                FROM vendas v
                JOIN funcionarios f ON f.id = v.funcionario_id
                WHERE f.comercio_id = @idEmpresa
                AND v.data_venda BETWEEN @dataInicio1Periodo AND @dataFim1Periodo;
            ", parametros);

            foreach (DataRow row in tabela.Rows)
            {
                eixoY.Labels.Add(row["periodo"].ToString());
                barraSeries.Items.Add(new BarItem { Value = Convert.ToDouble(row["total_vendas"]) });
            }

            bool atualSemVenda = barraSeries.Items[1].Value == 0;
            bool longeSemVenda = barraSeries.Items[0].Value == 0;

            if (atualSemVenda)
            {
                modeloComparativo.Annotations.Add(new TextAnnotation
                {
                    Text = "Sem venda",
                    TextPosition = new DataPoint(3.5, 0.85),
                    FontSize = 22,
                    TextColor = OxyColors.White
                });
            }
            else if (longeSemVenda)
            {
                modeloComparativo.Annotations.Add(new TextAnnotation
                {
                    Text = "Sem venda",
                    TextPosition = new DataPoint(3.5, -0.10),
                    FontSize = 22,
                    TextColor = OxyColors.White
                });
            }

            modeloComparativo.Axes.Add(eixoX);
            modeloComparativo.Axes.Add(eixoY);
            modeloComparativo.Series.Add(barraSeries);

            grafico1.Model = modeloComparativo;
            grafico1.Controller = controller;


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
                MinorStep = 1,
                MajorStep = 1,
                Maximum = 31,
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
                MinorStep = 1,
                MajorStep = 1,
                StringFormat = "0",
                TextColor = OxyColors.White,
                TicklineColor = OxyColors.White
            };
            var linhaAtual = new LineSeries
            {
                Title = "1ºPeríodo",
                Color = OxyColors.SkyBlue,
                StrokeThickness = 2,
                MarkerType = MarkerType.Circle
            };

            var linhaPassado = new LineSeries
            {
                Title = "2ºPeríodo",
                Color = OxyColors.Orange,
                StrokeThickness = 2,
                MarkerType = MarkerType.Square
            };
            DataTable table = func_dashboard.ExecutarSelect(@"
            SELECT
            DAY(v.data_venda) AS dia,
            'Mês Atual' AS periodo,
            IFNULL(COUNT(v.id),0) AS total_vendas
            FROM vendas v
            JOIN funcionarios f ON f.id = v.funcionario_id
            WHERE f.comercio_id = @idEmpresa
            AND v.data_venda BETWEEN @dataInicio1Periodo AND @dataFim1Periodo
            GROUP BY DAY(v.data_venda)
            
            UNION ALL
            
            SELECT
            DAY(v.data_venda) AS dia,
            'Mês Passado' AS periodo,
            IFNULL(COUNT(v.id),0) AS total_vendas
            FROM vendas v
            JOIN funcionarios f ON f.id = v.funcionario_id
            WHERE f.comercio_id = @idEmpresa
            AND v.data_venda BETWEEN @dataInicio2Periodo AND @dataFim2Periodo
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

            lblproximo.Text = temVendaAtual ? "1ºPeríodo" : "Sem venda";
            lbllonge.Text = temVendaPassado ? "2ºPeríodo" : "Sem venda";

            modeloDiario.Axes.Add(eixoDias);
            modeloDiario.Axes.Add(eixoQuantidade);
            modeloDiario.Series.Add(linhaAtual);
            modeloDiario.Series.Add(linhaPassado);
            grafico2.Model = modeloDiario;
            grafico2.Controller = controller;

        }
        public static DataTable ExecutarSelect(string query, Dictionary<string, object> Parametros)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao executar consulta: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new DataTable();
            }
        }
        public static void Update(string insert, Dictionary<string,string> parametros)
        {
            using (MySqlConnection conn = new MySqlConnection(Banco.caminho))
            {
                conn.Open();
                
                using (MySqlCommand cmd = conn.CreateCommand())
                {
                    if (parametros != null)
                    {
                        foreach (var p in parametros)
                        {
                            cmd.Parameters.AddWithValue(p.Key, p.Value);
                        }
                    }
                    cmd.CommandText = insert;
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

