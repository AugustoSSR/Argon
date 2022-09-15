using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Argon.Models
{
    public class ProjetoModel
    {
        public int Id { get; set; }
        public string Empresa { get; set; }
        public string Tipo { get; set; }
        public string Nome { get; set; }
        public string Localidade { get; set; }
    }
}
