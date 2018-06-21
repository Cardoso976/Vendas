using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vendas.Models
{
    public class Produto
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Descricao { get; set; }

        [Range(0, 99999999.99)]
        public decimal PrecoCusto { get; set; }

        [Range(0, 99999999.99)]
        public decimal PrecoVenda { get; set; }
    }
}