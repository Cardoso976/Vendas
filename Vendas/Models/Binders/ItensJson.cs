using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vendas.Models
{
    public class ItensJson
    {
        public int ProdutoId { get; set; }

        public int ClienteId { get; set; }

        public int  Quantidade { get; set; }
    }
}