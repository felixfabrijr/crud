using System;
using System.Collections.Generic;
using System.Linq;

public class ProdutoRepository
{
    private List<Produto> produtos = new List<Produto>();
    private int proximoId = 1;

    // Create
    public void Adicionar(Produto produto)
    {
        produto.Id = proximoId++;
        produtos.Add(produto);
    }

    // Read (Obter todos os produtos)
    public List<Produto> ObterTodos()
    {
        return produtos;
    }

    // Read (Obter um produto por ID)
    public Produto ObterPorId(int id)
    {
        return produtos.FirstOrDefault(p => p.Id == id);
    }

    // Update
    public void Atualizar(Produto produtoAtualizado)
    {
        var produtoExistente = produtos.FirstOrDefault(p => p.Id == produtoAtualizado.Id);
        if (produtoExistente != null)
        {
            produtoExistente.Nome = produtoAtualizado.Nome;
            produtoExistente.Preco = produtoAtualizado.Preco;
        }
    }

    // Delete
    public void Remover(int id)
    {
        var produtoExistente = produtos.FirstOrDefault(p => p.Id == id);
        if (produtoExistente != null)
        {
            produtos.Remove(produtoExistente);
        }
    }
}
