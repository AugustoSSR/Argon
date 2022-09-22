using Argon.Enums;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Argon.Models
{
    public class ProjetoModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Selecione a empresa do projeto.")]
        public string Empresa { get; set; }  
        [Required(ErrorMessage = "Selecione o tipo do projeto.")]
        public TiposEnum Tipo { get; set; }
        [Required(ErrorMessage = "Selecione o nome do projeto.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Selecione a concessionaria.")]
        public ConcessionariasEnums Concessionaria { get; set; }
        [Required(ErrorMessage = "Digite a localidade do projeto.")]
        public string Localidade { get; set; }
        [Required(ErrorMessage = "Selecione o engenheiro.")]
        public string Engenheiros { get; set; }
        [Required]
        public string ART { get; set; }
        [Required]
        public string Protocolo { get; set; }
        [Required]
        public string Observacao { get; set; }
        [Required]
        public DateTime dataCadastro { get; set; }
        [Required]
        public DateTime? dataAlteracao { get; set; }
        [Required]
        public string Situacao { get; set; }
    }
}
