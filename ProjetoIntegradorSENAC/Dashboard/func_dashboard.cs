using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using ProjetoIntegradorSENAC.Classes;
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
            GroupBox Info3_dash, GroupBox Info4_dash, Dictionary<string, object> parametros, string periodo, ComboBox comboPeriodo_dash)
        {
            var periodos = carregarPeriodoComparacao(comboPeriodo_dash);
            DataTable tabela = ExecutarSelect(@"
                SELECT
   (SELECT CONCAT(
        'Atual: ',
        SUM(CASE WHEN " + periodos.mesProximo + @" THEN 1 ELSE 0 END),
        ', Passado: ',
        SUM(CASE WHEN " + periodos.mesLonge + @" THEN 1 ELSE 0 END)
    )
    FROM vendas v
    JOIN funcionarios f ON f.id = v.funcionario_id
    WHERE f.comercio_id = @idEmpresa
    ) AS quantidade_vendas,

    (SELECT CONCAT(
        'Atual: ',
        IFNULL(SUM(CASE WHEN " + periodos.mesProximo + @" THEN iv.quantidade ELSE 0 END), 0),
        ', Passado: ',
        IFNULL(SUM(CASE WHEN " + periodos.mesLonge + @" THEN iv.quantidade ELSE 0 END), 0)
    )
    FROM items_venda iv
    JOIN vendas v ON v.id = iv.vendas_id
    JOIN funcionarios f ON f.id = v.funcionario_id
    WHERE f.comercio_id = @idEmpresa
    ) AS quantidade_itens_vendidos,

    (SELECT CONCAT(
        p.nome, ' (R$ ', FORMAT(SUM(iv.quantidade * iv.preco_unitario), 2), ')'
    )
    FROM items_venda iv
    JOIN vendas v ON v.id = iv.vendas_id
    JOIN funcionarios f ON f.id = v.funcionario_id
    JOIN produtos p ON p.id = iv.produtos_id
    WHERE f.comercio_id = @idEmpresa
    AND " + periodos.mesProximo + @"
    GROUP BY p.id, p.nome
    ORDER BY SUM(iv.quantidade * iv.preco_unitario) DESC
    LIMIT 1
    ) AS produto_lider_atual,

    (SELECT CONCAT(
        p.nome, ' (R$ ', FORMAT(SUM(iv.quantidade * iv.preco_unitario), 2), ')'
    )
    FROM items_venda iv
    JOIN vendas v ON v.id = iv.vendas_id
    JOIN funcionarios f ON f.id = v.funcionario_id
    JOIN produtos p ON p.id = iv.produtos_id
    WHERE f.comercio_id = @idEmpresa
    AND " + periodos.mesLonge + @"
    GROUP BY p.id, p.nome
    ORDER BY SUM(iv.quantidade * iv.preco_unitario) DESC
    LIMIT 1
    ) AS produto_lider_passado,

    (SELECT CONCAT(
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
    AND " + periodos.mesProximo + @"
    ) AS ticket_medio_atual,

    (SELECT CONCAT(
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
    AND " + periodos.mesLonge + @"
    ) AS ticket_medio_passado
FROM DUAL; ", parametros);

            label1.Text = tabela.Rows[0]["quantidade_vendas"].ToString();
            label2.Text = tabela.Rows[0]["quantidade_itens_vendidos"].ToString();
            label3.Text = tabela.Rows[0]["produto_lider_atual"].ToString() + " X " + tabela.Rows[0]["produto_lider_passado"].ToString();
            label4.Text = tabela.Rows[0]["ticket_medio_atual"].ToString() +" X " + tabela.Rows[0]["ticket_medio_passado"].ToString();
            Info1_dash.Text = "Quantidade de vendas";
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
            (SELECT CONCAT(p.nome,' (',SUM(iv.quantidade), ', R$',ROUND(SUM(iv.preco_unitario * iv.quantidade), 2),')')
            FROM items_venda iv
            JOIN vendas v ON v.id = iv.vendas_id
            JOIN funcionarios f ON f.id = v.funcionario_id
            JOIN produtos p ON p.id = iv.produtos_id
            WHERE f.comercio_id = @idEmpresa " + periodo + @"
            GROUP BY p.id
            ORDER BY SUM(iv.preco_unitario * iv.quantidade) ASC
            LIMIT 1) AS produto_menos_vendido,

            -- Ticket médio por produto
            (SELECT ROUND(AVG(iv.preco_unitario * iv.quantidade), 2)
            FROM items_venda iv
            JOIN vendas v ON v.id = iv.vendas_id
            JOIN funcionarios f ON f.id = v.funcionario_id
            WHERE f.comercio_id = @idEmpresa " + periodo + @" ) AS ticket_medio_por_produto,

            -- Quantidade de produtos vendidos
            (SELECT 
            SUM(iv.quantidade) AS total_produtos_vendidos
            FROM items_venda iv
            JOIN vendas v ON v.id = iv.vendas_id
            JOIN funcionarios f ON f.id = v.funcionario_id
            WHERE f.comercio_id = @idEmpresa
            " + periodo + @" ) AS quantidade_produtos_vendidos,

            -- Produto mais vendido (em quantidade)
            (SELECT  CONCAT(p.nome,' (', SUM(iv.quantidade), ', R$',ROUND( SUM(iv.preco_unitario * iv.quantidade), 2),')')
            FROM items_venda iv
            JOIN vendas v ON v.id = iv.vendas_id
            JOIN funcionarios f ON f.id = v.funcionario_id
            JOIN produtos p ON p.id = iv.produtos_id
            WHERE f.comercio_id = @idEmpresa " + periodo + @"
            GROUP BY p.id
            ORDER BY SUM(iv.quantidade) DESC
            LIMIT 1) AS produto_mais_vendido;
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
                SELECT(
                -- Total de vendas

                SELECT
                CONCAT(ROUND(SUM(v.total), 2), ',' , COUNT(DISTINCT v.id))
                FROM comercios c
                JOIN funcionarios f ON f.comercio_id = c.id
                JOIN vendas v       ON v.funcionario_id = f.id
                WHERE c.id = @idEmpresa " + periodo + @" ) AS total_vendas,


                -- categoria lider

                (SELECT
                CONCAT(IFNULL(p.categoria,'Sem categoria'),' (',IFNULL(ROUND(SUM(iv.quantidade * iv.preco_unitario),2),0),',', IFNULL(SUM(iv.quantidade),0),')')
                FROM comercios c
                JOIN funcionarios f ON f.comercio_id = c.id
                JOIN vendas v       ON v.funcionario_id = f.id
                JOIN items_venda iv ON iv.vendas_id = v.id
                JOIN produtos p     ON p.id = iv.produtos_id
                WHERE c.id = @idEmpresa " + periodo + @"
                GROUP BY p.categoria
                ORDER BY
                SUM(iv.quantidade) DESC,
                SUM(iv.quantidade * iv.preco_unitario) DESC, p.categoria
                LIMIT 1) AS categoria_lider,

                -- ticket medio de vendas
                (SELECT
                CONCAT('R$ ',FORMAT(IFNULL(SUM(iv.quantidade * iv.preco_unitario) / NULLIF(COUNT(DISTINCT v.id), 0), 0),2))
                FROM comercios c
                JOIN funcionarios f ON f.comercio_id = c.id
                JOIN vendas v       ON v.funcionario_id = f.id
                JOIN items_venda iv ON iv.vendas_id = v.id
                WHERE c.id = @idEmpresa " + periodo + @") AS ticket_medio_vendas,

                -- itens por venda
                (SELECT CONCAT('Qtd: ', FORMAT(SUM(iv.quantidade) / COUNT(DISTINCT v.id),2))
                FROM comercios c
                JOIN funcionarios f ON f.comercio_id = c.id
                JOIN vendas v       ON v.funcionario_id = f.id
                JOIN items_venda iv ON iv.vendas_id = v.id
                WHERE c.id = @idEmpresa " + periodo + @" ) AS media_produtos_por_venda ;"
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
        public static string carregarPeriodo(ComboBox comboPeriodo_dash)
        {
            if (comboPeriodo_dash.SelectedIndex == 0)
            {
                return " AND DATE(v.data_venda) = CURDATE() ";
            }
            else if (comboPeriodo_dash.SelectedIndex == 1)
            {
                return " AND v.data_venda >= DATE_SUB(CURDATE(), INTERVAL 7 DAY) ";
            }
            else if (comboPeriodo_dash.SelectedIndex == 2)
            { 
                return " AND v.data_venda >= DATE_SUB(CURDATE(), INTERVAL 1 MONTH) ";
            }
            else if (comboPeriodo_dash.SelectedIndex == 3)
            {
                return " AND v.data_venda >= DATE_SUB(CURDATE(), INTERVAL 3 MONTH) ";
            }
            else if (comboPeriodo_dash.SelectedIndex == 4)
            {
                return " AND v.data_venda >= DATE_SUB(CURDATE(), INTERVAL 6 MONTH) ";
            }
            else if (comboPeriodo_dash.SelectedIndex == 5)
            {
                return " AND v.data_venda >= DATE_SUB(CURDATE(), INTERVAL 1 YEAR) ";
            }
            return "";
        }
            public static (string mesProximo, string mesLonge) carregarPeriodoComparacao(ComboBox comboPeriodo_dash)
            {
            if (comboPeriodo_dash.SelectedIndex == 0)
            {
                return (
                    " v.data_venda >= DATE_FORMAT(CURDATE(), '%Y-%m-01') ",
                    @" v.data_venda >= DATE_SUB(DATE_FORMAT(CURDATE(), '%Y-%m-01'), INTERVAL 1 MONTH)
              AND v.data_venda <  DATE_FORMAT(CURDATE(), '%Y-%m-01') "
                );
            }
            else if (comboPeriodo_dash.SelectedIndex == 1)
            {
                return (
                    @" v.data_venda >= DATE_SUB(DATE_FORMAT(CURDATE(), '%Y-%m-01'), INTERVAL 1 MONTH)
              AND v.data_venda <  DATE_FORMAT(CURDATE(), '%Y-%m-01') ",
                    @" v.data_venda >= DATE_SUB(DATE_FORMAT(CURDATE(), '%Y-%m-01'), INTERVAL 2 MONTH)
              AND v.data_venda <  DATE_SUB(DATE_FORMAT(CURDATE(), '%Y-%m-01'), INTERVAL 1 MONTH) "
                );
            }
            return ("1=0", "1=0"); // fallback seguro
        }
        public static void carregarCombo(ComboBox comboPeriodo_dash, bool comparacaoBoo, bool produtosBoo, bool vendasBoo)
        {
            if (produtosBoo == true || vendasBoo == true)
            {
                comboPeriodo_dash.Items.Clear();
                comboPeriodo_dash.Items.Add("Hoje");
                comboPeriodo_dash.Items.Add("1 Semana");
                comboPeriodo_dash.Items.Add("1 Mês");
                comboPeriodo_dash.Items.Add("3 Meses");
                comboPeriodo_dash.Items.Add("6 Meses");
                comboPeriodo_dash.Items.Add("12 Meses");
                comboPeriodo_dash.SelectedIndex = 0;
            }
            else if (comparacaoBoo == true)
            {
                comboPeriodo_dash.Items.Clear();
                comboPeriodo_dash.Items.Add("Mês Atual X Mês Passado");
                comboPeriodo_dash.Items.Add("Mês Passado X Mês Retrasado");
                comboPeriodo_dash.SelectedIndex = 0;
                
            }
        }
        public static DataTable ExecutarSelect(string query, Dictionary<string, object> IdEmpresa)
        {
            using (MySqlConnection conn = new MySqlConnection(Banco.caminho))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    if (IdEmpresa != null)
                    {
                        foreach (var p in IdEmpresa)
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
