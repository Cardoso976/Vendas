using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Vendas.Models
{
    public class ItemVendaModelBinder : DefaultModelBinder
    {
        public override object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            if (bindingContext == null)
            {
                throw new ArgumentNullException(nameof(bindingContext));
            }

            var valores = controllerContext.HttpContext.Request.Form;

            var ret = new List<ItemVenda>();

            try
            {

                if (!string.IsNullOrEmpty(valores.Get("itens")))
                {
                    var itensDeserializeObject = JsonConvert.DeserializeObject<List<dynamic>>(valores.Get("itens"));

                    foreach (var item in itensDeserializeObject)
                    {
                       // ret.Add((int)item.);
                    }
                };
            }
            catch
            {
            }

            return ret;
        }
    }
}