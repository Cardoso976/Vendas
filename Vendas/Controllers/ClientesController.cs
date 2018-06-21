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
            return View();
        }

        [HttpGet]
        public ActionResult Listar()
        {
            var listaClientes = clienteNegocio.GetClientes();
            return Json(listaClientes, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult Cliente(int id)
        {
            var cliente = clienteNegocio.GetCliente(id);
            return Json(cliente, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public void Cadastrar(Cliente cliente)
        {
            clienteNegocio.Cadastrar(cliente);
        }

        [HttpPut]
        public void Atualizar(Cliente cliente)
        {
            clienteNegocio.Atualizar(cliente);
        }

        [HttpDelete]
        public void Excluir(int id)
        {
            clienteNegocio.Deletar(id);
        }

    }
}
