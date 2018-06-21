using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vendas.Models.Repositorio;

namespace Vendas.Models.Negocio
{
    public class ProdutoNegocio
    {
        private readonly ProdutoRepositorio repositorio;

        public ProdutoNegocio()
        {
            repositorio = new ProdutoRepositorio();
        }

        public void Cadastrar(Produto produto)
        {
            repositorio.CadastrarProduto(produto);
        }

        public void Atualizar(Produto produto)
        {
            repositorio.AtualizarProduto(produto);
        }

        public void Deletar(int id)
        {
            repositorio.ExcluirProduto(id);
        }

        public Produto GetProduto(int id)
        {
            return repositorio.GetProduto(id);
        }

        public IEnumerable<Produto> GetProdutos()
        {
            return repositorio.GetProdutos();
        }
    }
}