namespace ProjetoIntegradorSENAC.Classes
{
    public sealed class ItemVenda
    {

        public int ProdutoId { get; }
        public string NomeProduto { get; }
        public decimal PrecoUnitarioOriginal { get; }
        public decimal PrecoUnitario { get; private set; }


        private int _quantidade;
        public int Quantidade
        {
            get => _quantidade;
            private set
            {
                if (value < 1)
                    throw new ArgumentOutOfRangeException(nameof(Quantidade), "Quantidade deve ser >= 1");
                _quantidade = value;
            }
        }

        public decimal Total => Decimal.Round(PrecoUnitario * Quantidade, 2);

        public ItemVenda(int produtoId, string nomeProduto, decimal precoUnitario, int quantidade = 1)
        {
            if (produtoId <= 0) throw new ArgumentException("ProdutoId inválido.", nameof(produtoId));
            if (precoUnitario < 0) throw new ArgumentException("PrecoUnitario inválido.", nameof(precoUnitario));
            if (quantidade < 1) throw new ArgumentException("Quantidade inválida.", nameof(quantidade));


            ProdutoId = produtoId;
            NomeProduto = nomeProduto ?? throw new ArgumentNullException(nameof(nomeProduto));
            PrecoUnitarioOriginal = precoUnitario;
            PrecoUnitario = precoUnitario;
            Quantidade = quantidade;
        }

        public void Incrementar(int amount = 1) => Quantidade += amount;

        public void Decrementar(int amount = 1)
        {
            if (Quantidade - amount < 1)
                throw new InvalidOperationException("Quantidade não pode ser menor que 1.");
            Quantidade -= amount;
        }

        public void AtualizarPreco(decimal novoPreco)
        {
            if (novoPreco < 0)
                throw new ArgumentOutOfRangeException(nameof(novoPreco));
            PrecoUnitario = novoPreco;
        }
    }
}
