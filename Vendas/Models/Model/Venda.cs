using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Vendas.JsonConverter;

namespace Vendas.Models
{
    public class Venda
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime Data { get; set; }

        public Cliente Cliente { get; set; }

        public int ClienteId { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public StatusVenda Status { get; set; }
    }
}