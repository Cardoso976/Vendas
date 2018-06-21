using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Vendas.Models;

namespace Vendas.Persistencia
{
    public class VendaDbContext : DbContext
    {
        public VendaDbContext() : base("DefaultConnection")
        {
            Database.CreateIfNotExists();
        }

        DbSet<Cliente> Clientes { get; set; }

        DbSet<Produto> Produtos { get; set; }

        DbSet<Venda> Vendas { get; set; }

        DbSet<ItemVenda> ItensVenda { get; set; }
    }
}