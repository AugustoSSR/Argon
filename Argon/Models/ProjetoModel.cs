using Argon.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Argon.Models
{
    public class ProjetoModel
    {
        public int Id { get; set; }
        public EmpresaEnums Empresa { get; set; }
        [Required(ErrorMessage = "Selecione o tipo do projeto.")]
        public string Tipo { get; set; }
        [Required(ErrorMessage = "Selecione o nome do projeto.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Digite a localidade do projeto.")]
        public string Localidade { get; set; }

        public DateTime dataCadastro { get; set; }
        public DateTime? dataAlteracao { get; set; }
    }
}
