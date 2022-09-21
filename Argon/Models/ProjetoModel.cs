using Argon.Enums;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Argon.Models
{
    [Keyless]
    public class ProjetoModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Selecione a empresa do projeto.")]
        public string Empresa { get; set; }
        public SelectList EmpresaList { get; set; }  
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
        public SelectList EngenheirosList { get; set; }
        public string? ART { get; set; }
        public string? Protocolo { get; set; }
        public string? Observacao { get; set; }
        public DateTime dataCadastro { get; set; }
        public DateTime? dataAlteracao { get; set; }
        public string? nomeCadastro { get; set; }
        public string? nomeAlteracao { get; set; }
        public SituacaoEnum? Situacao { get; set; }
    }
}
