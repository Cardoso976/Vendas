using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Vendas.JsonConverter;

namespace Vendas.Models
{
    public class Venda
    {
        public int Id { get; set; }

        [JsonConverter(typeof(JsonDateConverter))]
        [DataType(DataType.Date)]
        public DateTime Data { get; set; }

        public Cliente Cliente { get; set; }

        public int ClienteId { get; set; }

        public StatusVenda Status { get; set; }
    }
}