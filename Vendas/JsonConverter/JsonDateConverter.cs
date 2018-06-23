using Newtonsoft.Json.Converters;

namespace Vendas.JsonConverter
{
    public class JsonDateConverter : IsoDateTimeConverter
    {
        public JsonDateConverter()
        {
            DateTimeFormat = "yyyy-MM-dd";
        }
    }
}