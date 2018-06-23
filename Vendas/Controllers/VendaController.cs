using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Vendas.Models;
using Vendas.Models.Negocio;

namespace Vendas.Controllers
{
    public class VendaController : Controller
    {
        readonly ClienteNegocio _cliente = new ClienteNegocio();
        private readonly VendaNegocio _vendaNegocio = new VendaNegocio();

        // GET: Venda
        public ActionResult Index()
        {
            ViewBag.Cliente = _cliente.GetClientes();
            var listaVendas = _vendaNegocio.GetVendas();
            return View(listaVendas);
        }

        [HttpGet]
        public JsonResult Listar()
        {
            var listaVendas = _vendaNegocio.GetVendas();
            return Json(listaVendas, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Venda(int id)
        {
            return Json(_vendaNegocio.GetVenda(id));
        }

        [HttpPost]
        public JsonResult Salvar(Venda venda)
        {
            var resultado = "OK";
            var mensagens = new List<string>();
            var idSalvo = string.Empty;

            if (!ModelState.IsValid)
            {
                resultado = "AVISO";
                mensagens = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList();
            }
            else
            {
                try
                {
                    idSalvo = _vendaNegocio.SalvarVenda(venda).ToString();
                }
                catch (Exception ex)
                {
                    resultado = "ERRO";
                }
            }

            return Json(new { Resultado = resultado, Mensagens = mensagens, IdSalvo = idSalvo });
        }

        [HttpPost]
        public JsonResult Excluir(int id)
        {
            return Json(_vendaNegocio.Deletar(id));
        }
    }
}