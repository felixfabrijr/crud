class Program
{
    static void Main(string[] args)
    {
        var produtoRepository = new ProdutoRepository();

        // Adicionar um produto
        produtoRepository.Adicionar(new Produto { Nome = "Produto 1", Preco = 19.99m });

        // Obter todos os produtos
        var produtos = produtoRepository.ObterTodos();
        Console.WriteLine("Produtos:");

        foreach (var produto in produtos)
        {
            Console.WriteLine($"ID: {produto.Id}, Nome: {produto.Nome}, Preço: {produto.Preco:C}");
        }

        // Atualizar um produto
        var produtoParaAtualizar = produtoRepository.ObterPorId(1);
        if (produtoParaAtualizar != null)
        {
            produtoParaAtualizar.Nome = "Produto Atualizado";
            produtoParaAtualizar.Preco = 29.99m;
            produtoRepository.Atualizar(produtoParaAtualizar);
            Console.WriteLine("Produto atualizado.");
        }

        // Remover um produto
        produtoRepository.Remover(1);
        Console.WriteLine("Produto removido.");

        Console.ReadLine();
    }
}

