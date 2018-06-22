using System;
using System.Collections.Generic;
using System.Linq;
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
            var listaProdutos = produtoNegocio.GetProdutos();
            return View(listaProdutos);
        }

        [HttpGet]
        public ActionResult Listar()
        {
            var listaProdutos = produtoNegocio.GetProdutos();
            return Json(listaProdutos, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Produto(int id)
        {
            return Json(produtoNegocio.GetProduto(id));
        }

        [HttpPost]
        public JsonResult Salvar()
        {
            var resultado = "OK";
            var mensagens = new List<string>();
            var idSalvo = string.Empty;

            var produto = new Produto()
            {
                Id = Int32.Parse(Request.Form["Id"]),
                Descricao = Request.Form["Descricao"],
                PrecoCusto = Decimal.Parse(Request.Form["PrecoCusto"]),
                PrecoVenda = Decimal.Parse(Request.Form["PrecoVenda"])
            };

            if (!ModelState.IsValid)
            {
                resultado = "AVISO";
                mensagens = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList();
            }
            else
            {
                try
                {
                    idSalvo = produtoNegocio.SalvarProduto(produto).ToString();
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
            return Json(produtoNegocio.Deletar(id));
        }
    }
}