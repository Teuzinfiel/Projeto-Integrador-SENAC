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

        public static string strCon= $"server={server};database={database};uid={usuario};password={senha}";


        public static void carregarInfoPadrao(Label label1, Label label2, Label label3, 
            Label label4, string meses, GroupBox groupBox1, GroupBox groupBox2,
            GroupBox groupBox3, GroupBox groupBox4)
        {
           
            DataTable tabela = ExecutarSelect("SELECT " +
            " (SELECT SUM(v.total) FROM vendas v) AS receita_total, " +
            " (SELECT SUM(iv.quantidade) FROM items_venda iv) AS quantidade_total_vendida, " +
            " (SELECT p.nome FROM items_venda iv JOIN produtos p ON p.id = iv.produtos_id " +
            " GROUP BY p.id ORDER BY SUM(iv.quantidade) DESC LIMIT 1) AS produto_mais_vendido, " +
            " (SELECT p.nome FROM items_venda iv JOIN produtos p ON p.id = iv.produtos_id " +
            " GROUP BY p.id ORDER BY SUM(iv.quantidade * iv.preco_unitario) DESC LIMIT 1) AS produto_maior_receita;");


            label1.Text = tabela.Rows[0]["receita_total"].ToString();
            label2.Text = tabela.Rows[0]["quantidade_total_vendida"].ToString();
            label3.Text = tabela.Rows[0]["produto_mais_vendido"].ToString();
            label4.Text = tabela.Rows[0]["produto_maior_receita"].ToString(); 
            groupBox1.Text = "Receita Total";
            groupBox2.Text = "Quantidade Total Vendida";
            groupBox3.Text = "Produto Mais Vendido";
            groupBox4.Text = "Produto com Maior Receita";
                        
            

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
