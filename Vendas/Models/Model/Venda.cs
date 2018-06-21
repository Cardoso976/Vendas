using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vendas.Models
{
    public class Venda
    {
        public int Id { get; set; }

        public DateTime Data { get; set; }

        public Cliente Cliente { get; set; }

        public StatusVenda Status { get; set; }
    }
}