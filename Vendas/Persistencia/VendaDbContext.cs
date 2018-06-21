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

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Venda> Vendas { get; set; }

        public DbSet<ItemVenda> ItensVenda { get; set; }
    }
}