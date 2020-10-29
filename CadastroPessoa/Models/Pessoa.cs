using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CadastroPessoa.Models
{
    public class Pessoa
    {
        [ScaffoldColumn(false)]
        public int PessoaId { get; set; }
        [Required(ErrorMessage = "Favor digite o nome")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Favor digite o email")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Favor digite o bairro")]
        public string Bairro { get; set; }
        public List<Estado> Estados { get; set; }
        public List<Cidade> Cidades { get; set; }
        [Required(ErrorMessage = "Favor digite o estado")]
        public Estado Estado { get; set; }
        [Required(ErrorMessage = "Favor digite a cidade")]
        public Cidade Cidade { get; set; }
    }
}