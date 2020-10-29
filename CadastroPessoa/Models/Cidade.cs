using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace CadastroPessoa.Models
{
    public class Cidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int IdEstado { get; set; }
        public List<Cidade> ListarCidades(int idEstado)
        {
            var cidades = new List<Cidade>
            {
                new Cidade { Id = 1, Nome = "São Paulo", IdEstado = 1 },
                new Cidade { Id = 2, Nome = "Guarulhos", IdEstado = 1 },
                new Cidade { Id = 3, Nome = "Santos", IdEstado = 1 },
                new Cidade { Id = 4, Nome = "Rio de Janeiro", IdEstado = 2 },
                new Cidade { Id = 5, Nome = "Niteroi", IdEstado = 2 },
                new Cidade { Id = 6, Nome = "Angra dos Reis", IdEstado = 2 },
            };

            return cidades.Where(x => x.IdEstado == idEstado)
                .Select(x => new Cidade
                {
                    Id = x.Id,
                    Nome = x.Nome
                }).ToList();
        }
    }
}