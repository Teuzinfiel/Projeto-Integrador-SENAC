using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegradorSENAC.Classes
{
    public class cls_Produto
    {

        public int Id { get; set; }
        public int? FuncionarioId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Marca { get; set; }
        public string CodigoBarra { get; set; }
        public string UnidadeMedida { get; set; } // gramas ou unidade
        public string Categoria { get; set; }

        public cls_Produto() { }

        public cls_Produto(int id = 0, int? funcionarioId = 0, string nome ="", string descricao = "", string marca = "",
                       string codigoBarra = "", string unidadeMedida = "", string categoria = "")
        {
            Id = id;
            FuncionarioId = funcionarioId;
            Nome = nome;
            Descricao = descricao;
            Marca = marca;
            CodigoBarra = codigoBarra;
            UnidadeMedida = unidadeMedida;
            Categoria = categoria;
        }




    }
}
