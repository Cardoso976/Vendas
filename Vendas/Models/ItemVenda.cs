using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vendas.Models
{
    public class ItemVenda
    {
        public int Id { get; set; }

        public Produto Produto { get; set; }

        public Venda Venda { get; set; }

        public int Quantidade { get; set; }

        [Range(0, 99999999.99)]
        public decimal ValorUnitario { get; set; }

        [Range(0, 99999999.99)]
        public decimal ValorTotal { get; set; }
    }
}