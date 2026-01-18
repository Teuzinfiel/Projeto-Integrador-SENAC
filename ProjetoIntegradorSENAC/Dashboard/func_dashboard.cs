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
            GroupBox Info3_dash, GroupBox Info4_dash, Dictionary<string, object> parametros, string periodo)
        {

            DataTable tabela = ExecutarSelect("", parametros);

            label1.Text = tabela.Rows[0][""].ToString();
            label2.Text = tabela.Rows[0][""].ToString();
            label3.Text = tabela.Rows[0][""].ToString();
            label4.Text = tabela.Rows[0][""].ToString();
            Info1_dash.Text = "";
            Info2_dash.Text = "";
            Info3_dash.Text = "";
            Info4_dash.Text = "";
        }
        public static void carregarInfoProdutos(Label label1, Label label2, Label label3,
            Label label4, GroupBox Info1_dash, GroupBox Info2_dash,
            GroupBox Info3_dash, GroupBox Info4_dash, Dictionary<string, object> parametros, string periodo)
        {

            DataTable tabela = ExecutarSelect(@"
           SELECT
            -- Produto que gerou MENOS receita
            (SELECT p.nome
            FROM items_venda iv
            JOIN vendas v ON v.id = iv.vendas_id
            JOIN funcionarios f ON f.id = v.funcionario_id
            JOIN produtos p ON p.id = iv.produtos_id
            WHERE f.comercio_id = @idEmpresa
            GROUP BY p.id
            ORDER BY SUM(iv.preco_unitario * iv.quantidade) ASC
            LIMIT 1) AS produto_menos_receita,

            -- Ticket médio por produto
            (SELECT ROUND(AVG(iv.preco_unitario * iv.quantidade), 2)
            FROM items_venda iv
            JOIN vendas v ON v.id = iv.vendas_id
            JOIN funcionarios f ON f.id = v.funcionario_id
            WHERE f.comercio_id = @idEmpresa) AS ticket_medio_por_produto,

            -- Quantidade de produtos vendidos
            (SELECT 
            SUM(iv.quantidade) AS total_produtos_vendidos
            FROM items_venda iv
            JOIN vendas v ON v.id = iv.vendas_id
            JOIN funcionarios f ON f.id = v.funcionario_id
            WHERE f.comercio_id = @idEmpresa
            " + periodo + @" ) AS quantidade_produtos_vendidos,

            -- Produto mais vendido (em quantidade)
            (SELECT p.nome
            FROM items_venda iv
            JOIN vendas v ON v.id = iv.vendas_id
            JOIN funcionarios f ON f.id = v.funcionario_id
            JOIN produtos p ON p.id = iv.produtos_id
            WHERE f.comercio_id = @idEmpresa
            GROUP BY p.id
            ORDER BY SUM(iv.quantidade) DESC
            LIMIT 1) AS produto_mais_vendido;
            ", parametros);

            label1.Text = tabela.Rows[0]["quantidade_produtos_vendidos"].ToString();
            label2.Text = tabela.Rows[0]["produto_menos_receita"].ToString();//////
            label3.Text = tabela.Rows[0]["ticket_medio_por_produto"].ToString();////////
            label4.Text = tabela.Rows[0]["produto_mais_vendido"].ToString();//////////
            Info1_dash.Text = "Quantidade de produtos vendidos"; 
            Info2_dash.Text = "Produto com menos receita";
            Info3_dash.Text = "Ticket medio por produto";
            Info4_dash.Text = "Produto mais vendido";
        }
        public static void carregarInfoVendas(Label label1, Label label2, Label label3,
            Label label4, GroupBox Info1_dash, GroupBox Info2_dash,
            GroupBox Info3_dash, GroupBox Info4_dash, Dictionary<string, object> parametros, string periodo)
        {

            DataTable tabela = ExecutarSelect(""
           ,parametros);

            label1.Text = tabela.Rows[0][""].ToString();
            label2.Text = tabela.Rows[0][""].ToString();
            label3.Text = tabela.Rows[0][""].ToString();
            label4.Text = tabela.Rows[0][""].ToString();
            Info1_dash.Text = "";
            Info2_dash.Text = "";
            Info3_dash.Text = "";
            Info4_dash.Text = "";
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
