using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vendas.Models.Repositorio;

namespace Vendas.Models.Negocio
{
    public class VendaNegocio
    {
        private readonly VendaRepositorio repositorio;

        public VendaNegocio()
        {
            repositorio = new VendaRepositorio();
        }

        public int SalvarVenda(Venda venda)
        {
            return repositorio.Salvar(venda);
        }

        public bool Deletar(int id)
        {
            return repositorio.ExcluirVenda(id);
        }

        public Venda GetVenda(int id)
        {
            return repositorio.GetVenda(id);
        }

        public List<Venda> GetVendas()
        {
            return repositorio.GetVendas();
        }
    }
}