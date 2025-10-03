using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;

namespace ProjetoIntegradorSENAC.Classes
{
    internal class Banco
    {
        
        public static string banco = "";
        public static string senha = "";
        public static string usuario = ""; 
        public static string servidor = "";

        public static string caminho = $"server={servidor};database={banco};uid={usuario};password={senha}";

        public static void Inserir(string insert)
        {
            using (MySqlConnection conn = new MySqlConnection(caminho))
            {
                conn.Open();

                using (MySqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = insert;
        
                    cmd.ExecuteNonQuery();
                }
            }
        }


        public static DataTable Pesquisar(string query)
        {
            using (MySqlConnection conn = new MySqlConnection(caminho))
            {
                conn.Open();

                using (MySqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = query;

                    using(MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();

                        da.Fill(dataTable);

                        return dataTable;
                    }

                }
            }
        }
    }
}
