using DocumentFormat.OpenXml.Wordprocessing;
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
using ProjetoIntegradorSENAC.personalizado;
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
        public static void carregarInfoComparacao(Label label1, Label label2, Label label3,Label label4, 
            Dictionary<string, object> parametros)
        {
            DataTable tabela = ExecutarSelect(@"
                SELECT
            -- ================== Lucro ==================
            IFNULL((SELECT CAST(CONCAT(
                'R$: ',
                SUM(CASE 
                    WHEN v.data_venda >= @dataInicio1Periodo
                AND v.data_venda < DATE_ADD(@dataFim1Periodo, INTERVAL 1 DAY) 
                    THEN v.lucro ELSE 0 END),
                ' | R$: ',
                SUM(CASE 
                    WHEN v.data_venda >= @dataInicio2Periodo
                AND v.data_venda < DATE_ADD(@dataFim2Periodo, INTERVAL 1 DAY)
                    THEN v.lucro ELSE 0 END)
            ) AS CHAR)
            FROM vendas v
            JOIN funcionarios f ON f.id = v.funcionario_id
            WHERE f.comercio_id = @idEmpresa
            ),'R$: 0,00 | R$: 0,00') AS lucro_vendas,
            
            -- ================== QUANTIDADE ITENS ==================
            (SELECT CONCAT(
                'Qtd: ',
                IFNULL(SUM(CASE 
                    WHEN v.data_venda >= @dataInicio1Periodo
                AND v.data_venda < DATE_ADD(@dataFim1Periodo, INTERVAL 1 DAY)
                    THEN iv.quantidade ELSE 0 END), 0),
                ' | Qtd: ',
                IFNULL(SUM(CASE 
                    WHEN v.data_venda >= @dataInicio2Periodo
                AND v.data_venda < DATE_ADD(@dataFim2Periodo, INTERVAL 1 DAY)
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
                p.nome, ' (R$ ', SUM(iv.lucro), ')'
            )
            FROM items_venda iv
            JOIN vendas v ON v.id = iv.vendas_id
            JOIN funcionarios f ON f.id = v.funcionario_id
            JOIN produtos p ON p.id = iv.produtos_id
            WHERE f.comercio_id = @idEmpresa
            AND v.data_venda >= @dataInicio1Periodo
                AND v.data_venda < DATE_ADD(@dataFim1Periodo, INTERVAL 1 DAY)
            GROUP BY p.id, p.nome
            ORDER BY SUM(iv.lucro) DESC
            LIMIT 1
            ),'Sem venda') AS produto_lider_atual,
            
            -- ================== PRODUTO LÍDER PASSADO ==================
            IFNULL((
            SELECT CONCAT(
                p.nome, ' (R$ ', SUM(iv.lucro), ')'
            )
            FROM items_venda iv
            JOIN vendas v ON v.id = iv.vendas_id
            JOIN funcionarios f ON f.id = v.funcionario_id
            JOIN produtos p ON p.id = iv.produtos_id
            WHERE f.comercio_id = @idEmpresa
            AND v.data_venda >= @dataInicio2Periodo
                AND v.data_venda < DATE_ADD(@dataFim2Periodo, INTERVAL 1 DAY)
            GROUP BY p.id, p.nome
            ORDER BY SUM(iv.lucro) DESC
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
            AND v.data_venda >= @dataInicio1Periodo
                AND v.data_venda < DATE_ADD(@dataFim1Periodo, INTERVAL 1 DAY)
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
            AND v.data_venda >= @dataInicio2Periodo
                AND v.data_venda < DATE_ADD(@dataFim2Periodo, INTERVAL 1 DAY)
            ),'R$ 0,00') AS ticket_medio_passado
            FROM DUAL;", parametros);
            if (tabela.Rows.Count == 0)
            {
                var opa = new caixaMensagem("Nenhum dado encontrado para os períodos selecionados.", "Falha ❌");
                opa.ShowDialog();
                return;
            }
            label1.Text = tabela.Rows[0]["lucro_vendas"].ToString();
            label2.Text = tabela.Rows[0]["quantidade_itens_vendidos"].ToString();
            label3.Text = tabela.Rows[0]["produto_lider_atual"].ToString() + " | " + tabela.Rows[0]["produto_lider_passado"].ToString();
            label4.Text = tabela.Rows[0]["ticket_medio_atual"].ToString() + " | " + tabela.Rows[0]["ticket_medio_passado"].ToString();

        }
        public static void carregarInfoProdutos(Label label1, Label label2, Label label3,Label label4, 
            Dictionary<string, object> parametros)
        {
            string query = @"
            SELECT
            
            -- Total de produtos cadastrados
            IFNULL((
                SELECT CAST(CONCAT('Qtd:', COUNT(*)) AS CHAR)
                FROM produtos p
                WHERE p.comercio_id = @idEmpresa
            ),'Qtd:0') AS total_produtos,
            
            -- Produto mais caro
            IFNULL((
                SELECT CONCAT(p.nome,' (R$:', FORMAT(p.preco,2),')')
                FROM produtos p
                WHERE p.comercio_id = @idEmpresa
                ORDER BY p.preco DESC
                LIMIT 1
            ),'Sem produto') AS produto_mais_caro,
            
            -- Produto mais barato
            IFNULL((
                SELECT CONCAT(p.nome,' (R$:', FORMAT(p.preco,2),')')
                FROM produtos p
                WHERE p.comercio_id = @idEmpresa
                ORDER BY p.preco ASC
                LIMIT 1
            ),'Sem produto') AS produto_mais_barato,
            
            -- Produto com melhor margem de lucro
            IFNULL((
                SELECT CONCAT(
                    p.nome,
                    ' (',
                    ROUND(((p.preco - p.custo) / p.custo) * 100, 2),
                    '%, R$:',ROUND(p.preco - p.custo,2),')'
                )
                FROM produtos p
                WHERE p.comercio_id = @idEmpresa
                  AND p.preco > 0
                ORDER BY ((p.preco - p.custo) / p.custo) DESC
                LIMIT 1
            ),'Sem produto') AS melhor_margem;
            ";
            try
            {
                DataTable tabela = ExecutarSelect(query, parametros);

                if (tabela.Rows.Count > 0)
                {
                    var valor = tabela.Rows[0]["total_produtos"];
                    label1.Text = valor.ToString();
                    label2.Text = tabela.Rows[0]["produto_mais_caro"].ToString();
                    label3.Text = tabela.Rows[0]["produto_mais_barato"].ToString();
                    label4.Text = tabela.Rows[0]["melhor_margem"].ToString();
                }
            }
            catch (Exception ex)
            {
                var opa = new caixaMensagem($"Erro em carregar Informações de Produtos: {ex.Message}", "Falha ❌");
                opa.ShowDialog();
            }
        }
        public static void carregarInfoVendas(Label label1, Label label2, Label label3,Label label4, 
            Dictionary<string, object> parametros)
        {
            string query = @"
            SELECT
            -- Total de vendas
            IFNULL((
                SELECT CAST(CONCAT('R$:', SUM(v.lucro), ', Qtd:', COUNT(DISTINCT v.id)) AS CHAR)
                FROM vendas v
                JOIN funcionarios f ON f.id = v.funcionario_id
                WHERE f.comercio_id = @idEmpresa  
                AND v.data_venda >= @dataInicio
                AND v.data_venda < DATE_ADD(@dataFim, INTERVAL 1 DAY)
            ), 'R$:0,00 (Qtd:0)') AS total_vendas,
            
            -- Categoria líder financeiro(em receita e quantidade)
            IFNULL((
                SELECT CONCAT(
                    c.nome, 
                    ' (R$: ', 
                    ROUND(SUM(iv.lucro), 2), 
                    ', Qtd: ', 
                    SUM(iv.quantidade), 
                    ')'
                )
                FROM items_venda iv
                JOIN vendas v       ON v.id = iv.vendas_id
                JOIN funcionarios f ON f.id = v.funcionario_id
                JOIN produtos p     ON p.id = iv.produtos_id
                JOIN categorias c   ON c.id = p.categoria_id
                WHERE f.comercio_id = @idEmpresa  
                  AND v.data_venda >= @dataInicio
                  AND v.data_venda < DATE_ADD(@dataFim, INTERVAL 1 DAY)
                GROUP BY c.id, c.nome
                ORDER BY SUM(iv.lucro) DESC
                LIMIT 1
            ), 'Sem vendas (R$: 0,00, Qtd: 0)') AS categoria_lider,
            
            -- Ticket médio de vendas
            IFNULL(
            (
                SELECT CONCAT('R$:', FORMAT(SUM(v.total) / COUNT(v.id), 2))
                FROM vendas v
                JOIN funcionarios f ON f.id = v.funcionario_id
                WHERE f.comercio_id = @idEmpresa
                AND v.data_venda >= @dataInicio
                AND v.data_venda < DATE_ADD(@dataFim, INTERVAL 1 DAY)
            ),
            'R$:0,00'
            ) AS ticket_medio_vendas  ,
            
            -- Itens por venda
            IFNULL((
                SELECT CONCAT('Qtd:', ROUND(SUM(iv.quantidade) / COUNT(DISTINCT v.id), 2))
                FROM items_venda iv
                JOIN vendas v ON v.id = iv.vendas_id
                JOIN funcionarios f ON f.id = v.funcionario_id
                WHERE f.comercio_id = @idEmpresa  
                AND v.data_venda >= @dataInicio
                AND v.data_venda < DATE_ADD(@dataFim, INTERVAL 1 DAY)
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
            }
            catch (Exception ex)
            {
                var opa = new caixaMensagem($"Erro em carregar Informações de Vendas: {ex.Message}", "Falha ❌");
                opa.ShowDialog();
            }
        }
        public static void carregarInfoEstoque(Label label1, Label label2, Label label3, Label label4, 
            Dictionary<string, object> parametros)
        {
            string query = @"
            SELECT

            -- ================= TOTAL DE ITENS =================
            IFNULL((
                SELECT SUM(e.quantidade_atual)
                FROM estoque e
                JOIN produtos p ON p.id = e.produto_id
                WHERE p.comercio_id = @idEmpresa
            ), 0) AS total_itens,
            
            -- ================= CUSTO TOTAL =================
            IFNULL((
                SELECT ROUND(SUM(e.quantidade_atual * p.custo), 2)
                FROM estoque e
                JOIN produtos p ON p.id = e.produto_id
                WHERE p.comercio_id = @idEmpresa
            ), 0) AS custo_estoque,
            
            -- ================= LUCRO TOTAL DO ESTOQUE =================
            IFNULL((
                SELECT CONCAT(ROUND(SUM(e.quantidade_atual * (p.preco - p.custo)), 2),'(')
                FROM estoque e
                JOIN produtos p ON p.id = e.produto_id
                WHERE p.comercio_id = @idEmpresa
            ), 0) AS lucro_total_estoque,
            
            -- ================= MARGEM DE LUCRO (%) =================
            IFNULL((
                SELECT CONCAT(ROUND(
                    (
                        (SUM(e.quantidade_atual * p.preco)
                       - SUM(e.quantidade_atual * p.custo))
                        / NULLIF(SUM(e.quantidade_atual * p.custo), 0)
                    ) * 100,
                    2
                )
                , '%)')
                FROM estoque e
                JOIN produtos p ON p.id = e.produto_id
                WHERE p.comercio_id = @idEmpresa
            ), '(0%)') AS margem_lucro_estoque,
            
            -- ================= PRODUTO COM MAIOR ESTOQUE =================
            IFNULL((
                SELECT CONCAT(
                    p.nome,
                    ' (Qtd: ',
                    e.quantidade_atual,
                    ')'
                )
                FROM estoque e
                JOIN produtos p ON p.id = e.produto_id
                WHERE p.comercio_id = @idEmpresa
                ORDER BY e.quantidade_atual DESC
                LIMIT 1
            ), 'Sem estoque') AS produto_parado";

            try
            {
                DataTable tabela = ExecutarSelect(query, parametros);

                if (tabela.Rows.Count > 0)
                {
                    label1.Text = tabela.Rows[0]["total_itens"].ToString();
                    label2.Text = tabela.Rows[0]["custo_estoque"].ToString();
                    label3.Text = tabela.Rows[0]["lucro_total_estoque"].ToString()+ tabela.Rows[0]["margem_lucro_estoque"].ToString();
                    label4.Text = tabela.Rows[0]["produto_parado"].ToString();
                }
            }
            catch (Exception ex)
            {
                var opa = new caixaMensagem($"Erro em carregar Informações de Vendas: {ex.Message}", "Falha ❌");
                opa.ShowDialog();
            }
        }
        public static void load_grafico_produtos(PlotView grafico1, PlotView grafico2, Dictionary<string, object> parametros, Label lbTituloGrafico1, Label lbTituloGrafico2)
        {
            // -------------------- grafico 1, PRODUTOS ---------------
            var controller = new PlotController();
            controller.UnbindAll();
            lbTituloGrafico1.Text = "Top 5 produtos mais vendidos";
            lbTituloGrafico2.Text = "Top 5 produtos com maior margem de lucro";

            PlotModel modeloTopVenda = new PlotModel
            {
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
                FontWeight = FontWeights.Bold,
                FontSize = 14,
                LabelPlacement = LabelPlacement.Inside,
                LabelFormatString = "Qtd: {0}"
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
                FontWeight = FontWeights.Bold,
                FontSize = 14,
                LabelPlacement = LabelPlacement.Inside,
                LabelFormatString = "{0:N2}%"
            };
            DataTable tabela2 = func_dashboard.ExecutarSelect(@"
            SELECT
                p.id AS produto_id,
                p.nome AS produto,
                ROUND((p.preco - p.custo) / p.custo * 100, 2) AS margem_lucro
            FROM items_venda iv
            JOIN produtos p     ON p.id = iv.produtos_id
            JOIN vendas v       ON v.id = iv.vendas_id
            JOIN funcionarios f ON f.id = v.funcionario_id
            WHERE f.comercio_id = @idEmpresa
            GROUP BY p.id, p.nome, p.preco, p.custo
            ORDER BY (p.preco - p.custo) / p.custo DESC
            LIMIT 5;

            ", parametros);
            foreach (DataRow row in tabela2.Rows)
            {
                categoryAxis2.Labels.Add(row["produto"].ToString());
                barSeries2.Items.Add(new BarItem { Value = Convert.ToDouble(row["margem_lucro"]) });
            }

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
            modeloTopReceita.Axes.Add(categoryAxis2);
            modeloTopReceita.Axes.Add(linearAxis2);
            modeloTopReceita.Series.Add(barSeries2);
            
            grafico2.Model = modeloTopReceita;
            grafico2.Controller = controller;
        }
        public static void load_grafico_estoque(PlotView grafico1, PlotView grafico2, Dictionary<string, object> parametros, Label lbTituloGrafico1, Label lbTituloGrafico2)
        {
            // -------------------- grafico 1, ESTOQUE ---------------
            var controller = new PlotController();
            controller.UnbindAll();
            lbTituloGrafico1.Text = "Top 5 categorias com maior lucro no estoque";
            lbTituloGrafico2.Text = "Top 5 produtos com menor quantidade no estoque ";

            PlotModel modeloTopVenda = new PlotModel
            {
                TextColor = OxyColors.White,
                PlotAreaBorderColor = OxyColors.White
            };
            var categoryAxis1 = new CategoryAxis
            {
                Position = AxisPosition.Left,
                Title = "Categorias",
                TitleFontSize = 14,
                TitleFontWeight = FontWeights.Bold,
                TicklineColor = OxyColors.White,
                TextColor = OxyColors.White
            };
            var linearAxis1 = new LinearAxis
            {
                Position = AxisPosition.Bottom,
                Title = "Quantidade no estoque",
                TitleFontSize = 14,
                TitleFontWeight = FontWeights.Bold,
                TicklineColor = OxyColors.White,
                TextColor = OxyColors.White,
                MinimumPadding = 0,
                AbsoluteMinimum = 0
            };
            var barSeries1 = new BarSeries
            {
                Title = "Quantidade",
                FillColor = OxyColors.RoyalBlue,
                FontWeight = FontWeights.Bold,
                FontSize = 14,
                LabelPlacement = LabelPlacement.Inside,
                LabelFormatString = "R$: {0}"
            };
            DataTable tabela1 = func_dashboard.ExecutarSelect(@"SELECT 
                c.nome AS categoria,
                SUM( (p.preco - p.custo) * e.quantidade_atual ) AS lucro_potencial
            FROM categorias c
            JOIN produtos p 
                ON p.categoria_id = c.id
            JOIN estoque e 
                ON e.produto_id = p.id
            WHERE c.comercio_id = @idEmpresa
            GROUP BY c.id, c.nome
            ORDER BY lucro_potencial DESC
            LIMIT 5;
            ", parametros);
            foreach (DataRow row in tabela1.Rows)
            {
                categoryAxis1.Labels.Add(row["categoria"].ToString());
                barSeries1.Items.Add(new BarItem { Value = Convert.ToInt32(row["lucro_potencial"]) });
            }

            modeloTopVenda.Axes.Add(categoryAxis1);
            modeloTopVenda.Axes.Add(linearAxis1);
            modeloTopVenda.Series.Add(barSeries1);
            if (!barSeries1.Items.Any())
            {
                modeloTopVenda.Annotations.Add(new TextAnnotation
                {
                    Text = "Sem estoque",
                    TextPosition = new DataPoint(0.25, -0.05),

                    FontSize = 28,
                    FontWeight = FontWeights.Bold,
                    TextColor = OxyColors.White
                });
            }
            grafico1.Model = modeloTopVenda;
            grafico1.Controller = controller;
            //----------- grafico 2  ESTOQUE --------------

            PlotModel modeloTopReceita = new PlotModel
            {
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
                Title = "Estoque",
                TitleFontSize = 14,
                TitleFontWeight = FontWeights.Bold,
                TicklineColor = OxyColors.White,
                TextColor = OxyColors.White,
                MinimumPadding = 0,
                AbsoluteMinimum = 0
            };
            var barSeries2 = new BarSeries
            {
                Title = "quantidade",
                FillColor = OxyColors.RoyalBlue,
                FontWeight = FontWeights.Bold,
                FontSize = 14,
                LabelPlacement = LabelPlacement.Inside,
                LabelFormatString = "Qtd: {0}"
            };
            DataTable tabela2 = func_dashboard.ExecutarSelect(@"
            SELECT 
                p.id,
                p.nome,
                e.quantidade_atual
            FROM produtos p
            JOIN estoque e 
                ON e.produto_id = p.id
            WHERE p.comercio_id = @idEmpresa
              AND p.status = 'ativo'
            ORDER BY e.quantidade_atual ASC
            LIMIT 5;

            ", parametros);
            foreach (DataRow row in tabela2.Rows)
            {
                categoryAxis2.Labels.Add(row["nome"].ToString());
                barSeries2.Items.Add(new BarItem { Value = Convert.ToDouble(row["quantidade_atual"]) });
            }

            if (!barSeries2.Items.Any())
            {
                modeloTopReceita.Annotations.Add(new TextAnnotation
                {
                    Text = "Sem estoque",
                    TextPosition = new DataPoint(0.25, -0.05),

                    FontSize = 28,
                    FontWeight = FontWeights.Bold,
                    TextColor = OxyColors.White
                });
            }
            modeloTopReceita.Axes.Add(categoryAxis2);
            modeloTopReceita.Axes.Add(linearAxis2);
            modeloTopReceita.Series.Add(barSeries2);

            grafico2.Model = modeloTopReceita;
            grafico2.Controller = controller;
        }
        public static void load_grafico_vendas(PlotView grafico1, PlotView grafico2, Dictionary<string, object> parametros, Label lbTituloGrafico1, Label lbTituloGrafico2)
        {
            // ---------------- grafico 1, VENDAS -------------------
            var controller = new PlotController();
            controller.UnbindAll();

            lbTituloGrafico1.Text = "Vendas por hora do dia";
            lbTituloGrafico2.Text = "Categorias mais vendidas";
            PlotModel modeloLinha = new PlotModel
            {
                TextColor = OxyColors.White,
                PlotAreaBorderColor = OxyColors.White
            };
            var eixoX = new LinearAxis
            {
                Position = AxisPosition.Bottom,
                Title = "Hora do dia",
                TitleFontSize = 14,
                TitleFontWeight = FontWeights.Bold,
                Minimum = 0,
                Maximum = 23,
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
                MarkerFill = OxyColors.White,
                MarkerStrokeThickness = 5
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

            for (int h = 0; h <= 23; h++)
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
                FontWeight = FontWeights.Bold,
                FontSize = 14,
                LabelPlacement = LabelPlacement.Inside,
                LabelFormatString = "{0}"
            };
            DataTable table = func_dashboard.ExecutarSelect(@"
            SELECT
                c.nome,
                SUM(iv.quantidade) AS total_vendido
            FROM items_venda iv
            JOIN produtos p     ON p.id = iv.produtos_id
            JOIN vendas v       ON v.id = iv.vendas_id
            JOIN funcionarios f ON f.id = v.funcionario_id
            JOIN categorias c ON c.id = p.categoria_id
            WHERE f.comercio_id = @idEmpresa
            AND v.data_venda >= @dataInicio
            AND v.data_venda < DATE_ADD(@dataFim, INTERVAL 1 DAY)
            GROUP BY c.nome
            ORDER BY total_vendido DESC;
            ", parametros);

            foreach (DataRow row in table.Rows)
            {
                eixoCategorias.Labels.Add(row["nome"].ToString());
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
        public static void load_grafico_comparacao(PlotView grafico1, PlotView grafico2, Dictionary<string, object> parametros, Label lb1periodo, Label lb2periodo, Label lbTituloGrafico1, Label lbTituloGrafico2)
        {
            // --------------- grafico 1, COMPARACAO -----------------
            var controller = new PlotController();
            controller.UnbindAll();
            lbTituloGrafico1.Text = "Comparação de quantidade de vendas";
            lbTituloGrafico2.Text = "Comparação de vendas por dia do mês";
            PlotModel modeloComparativo = new PlotModel
            {
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
                FontSize = 14,
                LabelPlacement = LabelPlacement.Inside,
                FontWeight = FontWeights.Bold,
                LabelFormatString = "{0}"
            };
            DataTable tabela = func_dashboard.ExecutarSelect(@"
               
                SELECT '2ºPeríodo' AS periodo,
                IFNULL(COUNT(v.id),0) AS total_vendas
                FROM vendas v
                JOIN funcionarios f ON f.id = v.funcionario_id
                WHERE f.comercio_id = @idEmpresa
                AND v.data_venda >= @dataInicio2Periodo
                AND v.data_venda < DATE_ADD(@dataFim2Periodo, INTERVAL 1 DAY)
                
                UNION ALL

                SELECT '1ºPeríodo' AS periodo,
                IFNULL(COUNT(v.id),0) AS total_vendas
                FROM vendas v
                JOIN funcionarios f ON f.id = v.funcionario_id
                WHERE f.comercio_id = @idEmpresa
                AND v.data_venda >= @dataInicio1Periodo
                AND v.data_venda < DATE_ADD(@dataFim1Periodo, INTERVAL 1 DAY)
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
                COUNT(v.id) AS total_vendas
            FROM vendas v
            JOIN funcionarios f ON f.id = v.funcionario_id
            WHERE f.comercio_id = @idEmpresa
            AND v.data_venda >= @dataInicio1Periodo
            AND v.data_venda < DATE_ADD(@dataFim1Periodo, INTERVAL 1 DAY)
            GROUP BY DAY(v.data_venda)
            
            UNION ALL
            
            SELECT
                DAY(v.data_venda) AS dia,
                'Mês Passado' AS periodo,
                COUNT(v.id) AS total_vendas
            FROM vendas v
            JOIN funcionarios f ON f.id = v.funcionario_id
            WHERE f.comercio_id = @idEmpresa
            AND v.data_venda >= @dataInicio2Periodo
            AND v.data_venda < DATE_ADD(@dataFim2Periodo, INTERVAL 1 DAY)
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
                var opa = new caixaMensagem($"Erro ao executar consulta: {ex.Message}", "Falha ❌");
                opa.ShowDialog();
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
        public static void EstilizarGrafico(OxyPlot.WindowsForms.PlotView plot1, OxyPlot.WindowsForms.PlotView plot2)
        {
            PlotView[] plot = { plot1, plot2};
            foreach (var grafico in plot)
            {
                if (grafico.Model == null) return;

                var model = grafico.Model;

                // Fundo
                model.Background = OxyColors.Transparent;
                model.PlotAreaBorderColor = OxyColors.Transparent;

                // Texto
                model.TextColor = OxyColors.White;
                model.TitleColor = OxyColors.White;

                // Eixos
                foreach (var axis in model.Axes)
                {
                    axis.TextColor = OxyColors.White;
                    axis.AxislineColor = OxyColors.Gray;

                    axis.MajorGridlineStyle = LineStyle.Solid;
                    axis.MajorGridlineColor = OxyColor.FromAColor(40, OxyColors.White);

                    axis.MinorGridlineStyle = LineStyle.None;
                }

                // Séries (somente LineSeries para evitar erro)
                foreach (var s in model.Series)
                {
                    if (s is LineSeries)
                    {
                        var line = (LineSeries)s;

                        line.Color = OxyColor.Parse("#1E90FF"); // Azul moderno
                        line.StrokeThickness = 3;

                        line.MarkerType = MarkerType.Circle;
                        line.MarkerSize = 4;
                        line.MarkerFill = OxyColor.Parse("#1E90FF");
                    }
                }

                grafico.InvalidatePlot(true);
            }
        }
    }
}

