using System.ComponentModel.DataAnnotations;

namespace Vendas.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [MaxLength(255)]
        public string Nome { get; set; }

        [MaxLength(100)]
        public string Email { get; set; }
    }
}