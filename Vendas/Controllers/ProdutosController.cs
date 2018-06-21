using System.Web.Mvc;
using Vendas.Models;
using Vendas.Models.Negocio;

namespace Vendas.Controllers
{
    public class ProdutosController : Controller
    {
        private ProdutoNegocio produtoNegocio = new ProdutoNegocio();

        // GET: Produtos
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Lista()
        {
            var lista = produtoNegocio.GetProdutos();
            return Json(lista, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult Cliente(int id)
        {
            var produto = produtoNegocio.GetProduto(id);
            return Json(produto, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public void Cadastrar(Produto produto)
        {
            produtoNegocio.Cadastrar(produto);
        }

        [HttpPost]
        public void Excluir(Produto produto)
        {
            produtoNegocio.Deletar(produto.Id);
        }

        [HttpPost]
        public void Alterar(Produto produto)
        {
            produtoNegocio.Atualizar(produto);
        }
    }
}