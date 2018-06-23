using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Vendas.Models;
using Vendas.Models.Negocio;

namespace Vendas.Controllers
{
    public class ItensVendaController : Controller
    {
        private readonly ProdutoNegocio _produtoNegocio = new ProdutoNegocio();

        private readonly ClienteNegocio _clienteNegocio = new ClienteNegocio();

        private readonly ItemVendaNegocio _itemVendaNegocio = new ItemVendaNegocio();

        // GET: ItensVenda
        public ActionResult Index()
        {
            ViewBag.Produtos = _produtoNegocio.GetProdutos();
            ViewBag.Clientes = _clienteNegocio.GetClientes();
            return View();
        }

        public void Salvar([ModelBinder(typeof(ItemVendaModelBinder))]ItensJson dados)
        {
            //var item = JsonConvert.DeserializeObject<List<ItemVenda.RootObject>>(itens);

            //_itemVendaNegocio.SalvarItem(Itens);
        }
    }
}

//[ModelBinder(typeof(ItemVenda))] 