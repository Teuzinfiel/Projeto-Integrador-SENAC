using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using System;
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
        private static string server = "localhost";
        private static string database = "senac";
        private static string usuario = "root";
        private static string senha = "gustavo951873";

        public static string strCon = $"server={server};database={database};uid={usuario};password={senha}";


        public static void carregarInfoPadrao(Label label1, Label label2, Label label3,
            Label label4, string meses, GroupBox groupBox1, GroupBox groupBox2,
            GroupBox groupBox3, GroupBox groupBox4)
        {

            DataTable tabela = ExecutarSelect(@"
            SELECT
            -- Número de vendas do dia
            (SELECT COUNT(*) 
            FROM vendas 
            WHERE DATE(data_venda) = CURDATE()
            ) AS numero_vendas_dia,

            -- Total vendido no dia (R$)
            (SELECT ROUND(SUM(total), 2)
            FROM vendas
            WHERE DATE(data_venda) = CURDATE()
            ) AS total_vendas_dia,

            -- Ticket médio do dia (total / quantidade de vendas)
            (SELECT 
            CASE 
            WHEN COUNT(*) = 0 THEN 0
            ELSE ROUND(SUM(total) / COUNT(*), 2)
            END
            FROM vendas
            WHERE DATE(data_venda) = CURDATE()
            ) AS ticket_medio_dia,

            -- Produto mais vendido do dia (nome)
            (SELECT p.nome
            FROM items_venda iv
            JOIN vendas v ON v.id = iv.vendas_id
            JOIN produtos p ON p.id = iv.produtos_id
            WHERE DATE(v.data_venda) = CURDATE()
            GROUP BY p.id
            ORDER BY SUM(iv.quantidade) DESC
            LIMIT 1
            ) AS produto_mais_vendido_dia,

            -- Quantidade vendida do produto mais vendido
            (SELECT SUM(iv.quantidade)
            FROM items_venda iv
            JOIN vendas v ON v.id = iv.vendas_id
            WHERE DATE(v.data_venda) = CURDATE()
            GROUP BY iv.produtos_id
            ORDER BY SUM(iv.quantidade) DESC
            LIMIT 1
            ) AS quantidade_produto_mais_vendido_dia;
");


            label1.Text = tabela.Rows[0]["total_vendas_dia"].ToString() + "("+ tabela.Rows[0]["numero_vendas_dia"].ToString() +")";
            label2.Text = tabela.Rows[0]["ticket_medio_dia"].ToString();
            label3.Text = tabela.Rows[0]["produto_mais_vendido_dia"].ToString();
            label4.Text = tabela.Rows[0]["quantidade_produto_mais_vendido_dia"].ToString();
            groupBox1.Text = "Vendas do dia (receita e quantidade)";
            groupBox2.Text = "Ticket medio do dia";
            groupBox3.Text = "Produto mais vendido do dia";
            groupBox4.Text = "Quantidade de produto vendido no dia";



        }
        public static void carregarInfoProdutos(Label label1, Label label2, Label label3,
            Label label4, string meses, GroupBox groupBox1, GroupBox groupBox2,
            GroupBox groupBox3, GroupBox groupBox4)
        {

            DataTable tabela = ExecutarSelect(@"
            SELECT
            -- Produto que gerou MENOS receita
            (SELECT p.nome
            FROM items_venda iv
            JOIN produtos p ON p.id = iv.produtos_id
            GROUP BY p.id
            ORDER BY SUM(iv.preco_unitario * iv.quantidade) ASC
            LIMIT 1) AS produto_menos_receita,

            -- Ticket médio por produto
            (SELECT ROUND(AVG(iv.preco_unitario * iv.quantidade), 2)
            FROM items_venda iv) AS ticket_medio_por_produto,

            -- Produto que gerou MAIS receita
            (SELECT p.nome
            FROM items_venda iv
            JOIN produtos p ON p.id = iv.produtos_id
            GROUP BY p.id
            ORDER BY SUM(iv.preco_unitario * iv.quantidade) DESC
            LIMIT 1) AS produto_mais_receita,

            -- Produto mais vendido (em quantidade)
            (SELECT p.nome
            FROM items_venda iv
            JOIN produtos p ON p.id = iv.produtos_id
            GROUP BY p.id
            ORDER BY SUM(iv.quantidade) DESC
            LIMIT 1) AS produto_mais_vendido;
");


            label1.Text = tabela.Rows[0]["produto_mais_receita"].ToString();
            label2.Text = tabela.Rows[0]["produto_menos_receita"].ToString();
            label3.Text = tabela.Rows[0]["ticket_medio_por_produto"].ToString();
            label4.Text = tabela.Rows[0]["produto_mais_vendido"].ToString();
            groupBox1.Text = "Produto com mais receita";
            groupBox2.Text = "Produto com menos receita";
            groupBox3.Text = "Ticket medio por produto";
            groupBox4.Text = "Produto mais vendido";



        }
        public static void carregarInfoMeses(Label label1, Label label2, Label label3,
            Label label4, string meses, GroupBox groupBox1, GroupBox groupBox2,
            GroupBox groupBox3, GroupBox groupBox4)
        {

            DataTable tabela = ExecutarSelect(@"
            SELECT 
            -- Categoria mais vendida no mês (por quantidade)
            (SELECT p.categoria
            FROM items_venda iv
            JOIN vendas v ON v.id = iv.vendas_id
            JOIN produtos p ON p.id = iv.produtos_id
            WHERE MONTH(v.data_venda) = MONTH(CURDATE())
            AND YEAR(v.data_venda) = YEAR(CURDATE())
            GROUP BY p.categoria
            ORDER BY SUM(iv.quantidade) DESC
            LIMIT 1
            ) AS categoria_mais_vendida_mes,

            -- Receita total do mês
            (
            SELECT ROUND(SUM(total), 2)
            FROM vendas
            WHERE MONTH(data_venda) = MONTH(CURDATE())
            AND YEAR(data_venda) = YEAR(CURDATE())
            ) AS receita_mes,

            -- Quantidade total vendida no mês
            (
            SELECT COUNT(*)
            FROM vendas
            WHERE MONTH(data_venda) = MONTH(CURDATE())
            AND YEAR(data_venda) = YEAR(CURDATE())
            ) AS quantidade_mes,

            -- Produto mais vendido do mês (por quantidade)
            (
            SELECT p.nome
            FROM items_venda iv
            JOIN vendas v ON v.id = iv.vendas_id
            JOIN produtos p ON p.id = iv.produtos_id
            WHERE MONTH(v.data_venda) = MONTH(CURDATE())
            AND YEAR(v.data_venda) = YEAR(CURDATE())
            GROUP BY p.id
            ORDER BY SUM(iv.quantidade) DESC
            LIMIT 1
            ) AS produto_mais_vendido_mes,

            -- Quantidade do produto mais vendido no mês
            (
            SELECT SUM(iv.quantidade)
            FROM items_venda iv
            JOIN vendas v ON v.id = iv.vendas_id
            WHERE MONTH(v.data_venda) = MONTH(CURDATE())
            AND YEAR(v.data_venda) = YEAR(CURDATE())
            ) AS quantidade_produto_mais_vendido_mes;");


            label1.Text = tabela.Rows[0]["receita_mes"].ToString() + "(" + tabela.Rows[0]["quantidade_mes"].ToString() + ")";
            label2.Text = tabela.Rows[0]["categoria_mais_vendida_mes"].ToString();
            label3.Text = tabela.Rows[0]["produto_mais_vendido_mes"].ToString();
            label4.Text = tabela.Rows[0]["quantidade_produto_mais_vendido_mes"].ToString();
            groupBox1.Text = "Vendas do mês(receita e quantidade)";
            groupBox2.Text = "Categoria mais vendida do mês";
            groupBox3.Text = "Produto mais vendido do mês";
            groupBox4.Text = "Quantidade de produtos vendido no mês";



        }

        public static DataTable ExecutarSelect(string query)
        {

            using (MySqlConnection conn = new MySqlConnection(strCon))
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
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
