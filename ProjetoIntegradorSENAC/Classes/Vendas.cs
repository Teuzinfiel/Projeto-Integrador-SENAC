using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegradorSENAC.Classes
{
    internal class Venda
    {
        private readonly List<ItemVenda> _itens = new List<ItemVenda>();

        public IReadOnlyCollection<ItemVenda> Itens => _itens.AsReadOnly();
        public int FuncionarioId { get; set; } // permitir null se necessário
        public string FormaPagamento { get; set; } = "dinheiro";
        public decimal Descontos { get; private set; } = 0m; // valor absoluto do desconto

        
        public decimal TotalBruto =>
            Decimal.Round(_itens.Sum(i => i.Total), 2);

        public decimal TotalLiquido =>
            Decimal.Round(Math.Max(0, TotalBruto - Descontos), 2);

        public Venda(int funcionarioId)
        {
            FuncionarioId = funcionarioId;
        }

        public void AdicionarItem(ItemVenda item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            var existing = _itens.FirstOrDefault(i =>
                i.ProdutoId == item.ProdutoId &&
                i.PrecoUnitario == item.PrecoUnitario);

            if (existing != null)
            {
                existing.Incrementar(item.Quantidade);
            }
            else
            {
                _itens.Add(item);
            }
        }

        public void RemoverItem(int produtoId)
        {
            _itens.RemoveAll(i => i.ProdutoId == produtoId);
        }

        public void AtualizarQuantidade(int produtoId, int novaQuantidade)
        {
            var item = _itens.FirstOrDefault(i => i.ProdutoId == produtoId);

            if (item == null)
                throw new InvalidOperationException("Item não encontrado");

            if (novaQuantidade < 1)
                throw new ArgumentOutOfRangeException(nameof(novaQuantidade));

            _itens.Remove(item);
            _itens.Add(new ItemVenda(
                item.ProdutoId,
                item.NomeProduto,
                item.PrecoUnitario,
                novaQuantidade
            ));
        }

        /// <summary>
        /// Aplica desconto absoluto (valor). Para percentuais calcule antes.
        /// </summary>
        public void AplicarDesconto(decimal valorDesconto)
        {
            if (valorDesconto < 0)
                throw new ArgumentOutOfRangeException(nameof(valorDesconto));

            Descontos = Math.Min(valorDesconto, TotalBruto);
        }

        public bool EstaVazia() => !_itens.Any();
    }
}

