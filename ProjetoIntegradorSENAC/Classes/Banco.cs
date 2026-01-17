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

        public static string banco = "senac";
<<<<<<< HEAD
        public static string senha = "";
        public static string usuario = "root"; 
=======
        public static string senha = "";
        public static string usuario = "root";
>>>>>>> bd49410ffe4d2b8b7aca2f072b68a1462d10ed85
        public static string servidor = "localhost";

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

                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();

                        da.Fill(dataTable);

                        return dataTable;
                    }

                }
            }
        }
        public static void Excluir(string delete)
        {
            using (MySqlConnection conn = new MySqlConnection(caminho))
            {
                conn.Open();

                using (MySqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = delete;

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
