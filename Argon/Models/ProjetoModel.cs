using Argon.Enums;
using System.ComponentModel.DataAnnotations;

namespace Argon.Models
{
    public class ProjetoModel
    {
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
        public string? Engenheiros { get; set; }
        public int? ART { get; set; }
        public int? Protocolo { get; set; }
        public string? Observacao { get; set; }
        public DateTime dataCadastro { get; set; }
        public DateTime? dataAlteracao { get; set; }
        public int? UsuarioID { get; set; }
        public SituacaoEnum? Situacao { get; set; }
    }
}
