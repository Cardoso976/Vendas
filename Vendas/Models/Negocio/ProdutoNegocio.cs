using System.Collections.Generic;
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

        public int SalvarProduto(Produto produto)
        {
            return repositorio.Salvar(produto);
        }

        public bool Deletar(int id)
        {
            return repositorio.ExcluirProduto(id);
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