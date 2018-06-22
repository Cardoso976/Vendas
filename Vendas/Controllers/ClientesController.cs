using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Vendas.Models;

namespace Vendas.Controllers
{
    public class ClientesController : Controller
    {
        private ClienteNegocio clienteNegocio = new ClienteNegocio();

        // GET: Clientes
        public ActionResult Index()
        {
            var listaClientes = clienteNegocio.GetClientes();
            return View(listaClientes);
        }

        [HttpGet]
        public ActionResult Listar()
        {
            var listaClientes = clienteNegocio.GetClientes();
            return Json(listaClientes, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Cliente(int id)
        {
            return Json(clienteNegocio.GetCliente(id));
        }

        [HttpPost]
        public JsonResult Salvar(Cliente cliente)
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
                    idSalvo = clienteNegocio.SalvarCliente(cliente).ToString();
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
            return Json(clienteNegocio.Deletar(id));
        }

    }
}
