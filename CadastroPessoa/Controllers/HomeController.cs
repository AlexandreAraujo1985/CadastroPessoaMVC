using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using CadastroPessoa.Models;

namespace CadastroPessoa.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var pessoa = new Pessoa();
            pessoa.Estados = CarregarEstados();
           
            return View(pessoa);
        }

        public JsonResult ListarCidades(int idEstado)
        {
            var cidades = CarregarCidades(idEstado);

            if (cidades.Count > 0)
                cidades.Insert(0, new Cidade { Nome = "Selecione a Cidade", Id = 0 });
            else
                cidades.Add(new Cidade { Nome = "Selecione a Cidade", Id = 0 });

            return Json(cidades, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Index(Pessoa pessoa)
        {
            pessoa.Estados = CarregarEstados();

            return View(pessoa);
        }

        private List<Estado> CarregarEstados()
        {
            var estado = new Estado();
            var estados = estado.ListarEstados().ToList();
            estados.Insert(0, new Estado { IdEstado = 0, Nome = "Selecione um estado" });

            return estados;
        }

        private List<Cidade> CarregarCidades(int idEstado)
        {
            var cidade = new Cidade();
            var cidades = cidade.ListarCidades(idEstado).ToList();

            return cidades;
        }
    }
}