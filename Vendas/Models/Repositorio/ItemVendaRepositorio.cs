using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vendas.Persistencia;

namespace Vendas.Models.Repositorio
{
    public class ItemVendaRepositorio
    {
        private readonly VendaDbContext _db;

        public ItemVendaRepositorio()
        {
            this._db = new VendaDbContext();
        }

        public void Salvar(ItemVenda item)
        {
            _db.ItensVenda.Add(item);
            _db.SaveChanges();
        }
    }
}