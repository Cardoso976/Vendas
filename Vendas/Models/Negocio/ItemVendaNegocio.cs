using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vendas.Models.Repositorio;
using Vendas.Persistencia;

namespace Vendas.Models.Negocio
{
    public class ItemVendaNegocio
    {
        private readonly ItemVendaRepositorio _itemVendaRepositorio;

        public ItemVendaNegocio()
        {
            this._itemVendaRepositorio  = new ItemVendaRepositorio();
        }

        public void SalvarItem(ItemVenda itens)
        {
            _itemVendaRepositorio.Salvar(itens);
        }

    }
}