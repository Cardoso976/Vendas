using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vendas.Persistencia;

namespace Vendas.Models.Repositorio
{
    public class ProdutoRepositorio
    {
        private readonly VendaDbContext _db;

        public ProdutoRepositorio()
        {
            _db = new VendaDbContext();
        }

        public IEnumerable<Produto> GetProdutos()
        {
            return _db.Produtos.ToList();
        }

        public Produto GetProduto(int id)
        {
            return _db.Produtos.Find(id);
        }

        public void CadastrarProduto(Produto produto)
        {
            _db.Produtos.Add(produto);
            _db.SaveChanges();
        }

        public void ExcluirProduto(int id)
        {
            var produto = GetProduto(id);
            _db.Produtos.Remove(produto);
            _db.SaveChanges();
        }

        public void AtualizarProduto(Produto produto)
        {
            var prod = GetProduto(produto.Id);
            prod.Descricao = produto.Descricao;
            prod.PrecoCusto = produto.PrecoCusto;
            prod.PrecoVenda = produto.PrecoVenda;
            _db.SaveChanges();
        }
    }
}