using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoIntegradorSENAC.Classes
{
    public sealed class Venda
    {
        private readonly List<ItemVenda> _itens = new List<ItemVenda>();

        public IReadOnlyCollection<ItemVenda> Itens => _itens.AsReadOnly();

        public int? FuncionarioId { get; set; }
        public string FormaPagamento { get; set; }

        public decimal Descontos { get; private set; } = 0m;
        public decimal TotalBruto => Decimal.Round(_itens.Sum(i => i.Total), 2);

        public Venda(int? funcionarioId = null)
        {
            FuncionarioId = funcionarioId;
        }

        // Agora só existe 1 item por produto
        public void AdicionarOuIncrimentar(int produtoId, string nome, decimal preco)
        {
            var item = _itens.FirstOrDefault(i => i.ProdutoId == produtoId);

            if (item == null)
            {
                _itens.Add(new ItemVenda(produtoId, nome, preco, 1));
            }
            else
            {
                item.Incrementar();
            }
        }

        public void Incrementar(int produtoId)
        {
            var item = _itens.First(i => i.ProdutoId == produtoId);

            item.Incrementar();
        }

        public void DecrementarOuRemover(int produtoId)
        {
            var item = _itens.First(i => i.ProdutoId == produtoId);

            if (item.Quantidade == 1)
                _itens.Remove(item);
            else
                item.Decrementar();
        }

        public void Remover(int produtoId)
        {
            _itens.RemoveAll(i => i.ProdutoId == produtoId);
        }

        public void AplicarDesconto(decimal desc, int idItem)
        {
            if (desc < 0 || desc >= 100) throw new ArgumentOutOfRangeException(nameof(desc));

            Descontos = desc;
            desc /= 100;
            var item = _itens.First(i => i.ProdutoId == idItem);
            decimal precoDesc = item.PrecoUnitarioOriginal - (desc * item.PrecoUnitarioOriginal);

            item.AtualizarPreco(precoDesc);

        }

        public bool EstaVazia() => !_itens.Any();
    }
}


