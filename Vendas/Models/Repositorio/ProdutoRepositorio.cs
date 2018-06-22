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
            this._db = new VendaDbContext();
        }

        public Produto GetProduto(int id)
        {
            return _db.Produtos.Find(id);
        }

        public List<Produto> GetProdutos()
        {
            return _db.Produtos.ToList();
        }

        public void Cadastrar(Produto produto)
        {
            _db.Produtos.Add(produto);
            _db.SaveChanges();
        }

        public bool ExcluirProduto(int id)
        {
            bool ret;
            try
            {
                var produto = GetProduto(id);
                _db.Produtos.Remove(produto);
                _db.SaveChanges();
                ret = true;
            }
            catch
            {
                ret = false;
            }
            return ret;
        }

        public int Salvar(Produto produto)
        {
            if (produto.Id == 0)
            {
                _db.Produtos.Add(produto);
            }
            else
            {
                var prod = GetProduto(produto.Id);
                prod.Descricao = produto.Descricao;
                prod.PrecoCusto = produto.PrecoCusto;
                prod.PrecoVenda = produto.PrecoVenda;
            }

            _db.SaveChanges();

            return produto.Id;
        }

    }
}
