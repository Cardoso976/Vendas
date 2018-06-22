using System.ComponentModel.DataAnnotations;

namespace Vendas.Models
{
    public class Produto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Preencha o nome.")]
        [MaxLength(100, ErrorMessage = "A descrição pode ter no máximo 100 caracteres.")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Preencha o preço de custo.")]
        [Range(0, 99999.99)]
        public decimal PrecoCusto { get; set; }

        [Required(ErrorMessage = "Preencha o preço de venda.")]
        [Range(0, 99999.99)]
        public decimal PrecoVenda { get; set; }
    }
}