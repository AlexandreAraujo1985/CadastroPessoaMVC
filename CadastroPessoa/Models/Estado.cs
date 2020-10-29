using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace CadastroPessoa.Models
{
    public class Estado
    {
        public int IdEstado { get; set; }
        public string Nome { get; set; }

        public List<Estado> ListarEstados()
        {
            var estados = new List<Estado> { new Estado { IdEstado = 1, Nome = "SP" }, new Estado { IdEstado = 2, Nome = "RJ" } };

            //return estados.Select(x => new SelectListItem
            //{
            //    Text = x.Nome,
            //    Value = x.IdEstado.ToString()
            //}).ToList();

            return estados;
        }
    }
}