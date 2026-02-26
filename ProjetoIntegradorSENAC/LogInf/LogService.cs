using ProjetoIntegradorSENAC.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegradorSENAC.LogInf
{
    internal static class LogService
    {
        public static void CriarLog(int idEmpresa, int idUsuario, string descricao)
        {
            string sql = $@"
                INSERT INTO logs (comercio_id, usuario_id, descricao)
                VALUES ({idEmpresa}, {idUsuario}, '{descricao.Replace("'", "''")}')
            ";

            Banco.Inserir(sql);
        }
    }
}
