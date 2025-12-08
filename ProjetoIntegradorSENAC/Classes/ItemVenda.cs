using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegradorSENAC.Classes
{
    public sealed class ItemVenda
    {
        public int ProdutoId { get; }
        public string NomeProduto { get; }
        public decimal PrecoUnitario { get; }

        private int _quantidade;
        public int Quantidade
        {
            get => _quantidade;
            set
            {
                if (value < 1)
                    throw new ArgumentOutOfRangeException(nameof(Quantidade), "Quantidade deve ser >= 1");

                _quantidade = value;
            }
        }

        public decimal Total => Decimal.Round(PrecoUnitario * Quantidade, 2);

        public ItemVenda(int produtoId, string nomeProduto, decimal precoUnitario, int quantidade = 1)
        {
            if (produtoId <= 0)
                throw new ArgumentException("produtoId inválido", nameof(produtoId));

            if (precoUnitario < 0)
                throw new ArgumentException("precoUnitario inválido", nameof(precoUnitario));

            if (quantidade < 1)
                throw new ArgumentException("quantidade inválida", nameof(quantidade));

            ProdutoId = produtoId;
            NomeProduto = nomeProduto ?? throw new ArgumentNullException(nameof(nomeProduto));
            PrecoUnitario = precoUnitario;
            _quantidade = quantidade;
        }

        public void Incrementar(int amount = 1) => Quantidade += amount;

        public void Decrementar(int amount = 1)
        {
            if (Quantidade - amount < 1)
                throw new InvalidOperationException("Quantidade não pode ser menor que 1");

            Quantidade -= amount;
        }
    }
}
