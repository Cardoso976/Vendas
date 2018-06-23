using System.ComponentModel.DataAnnotations;

namespace Vendas.Models
{
    public class ItemVenda
    {
        public int Id { get; set; }

        public Produto Produto { get; set; }

        public int ProdutoId { get; set; }
        
        public Venda Venda { get; set; }

        public int VendaId { get; set; }

        public int Quantidade { get; set; }

        [Range(0, 99999999.99)]
        public decimal ValorUnitario { get; set; }

        [Range(0, 99999999.99)]
        public decimal ValorTotal { get; set; }
    }
}