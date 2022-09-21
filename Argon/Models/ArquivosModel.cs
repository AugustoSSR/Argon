using Microsoft.AspNetCore.Mvc.Rendering;

namespace Argon.Models
{
    public class ArquivosModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string numeroCaderno { get; set; }
        public string Empresa { get; set; }
        public string Localidade { get; set; }
        public string? nomeCadastro { get; set; }
        public string? nomeAlteracao { get; set; }
        public DateTime dataCadastro { get; set; }
        public DateTime? dataAlteracao { get; set; }
    }
}
