using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Correios.Net;

namespace Argon.Models
{
    public class EmpresasModel
    {
        private readonly Correios correios;
        public int Id { get; set; }
        public string Nome { get; set; }
        public int CNPJ { get; set; }
        public string NomeFantasia { get; set; }
        public string Razao { get; set; }
        public string Telefone { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Ceps { get; set; }
        public string Email { get; set; }
        public int? UsuarioID { get; set; } 
        public DateTime? dataCadastro { get; set; }
        public DateTime? dataAlteracao { get; set; }

        public void buscaCep(string cep)
        {
            Address address = correios.GetAddress(cep);

            Rua = address.Street     // Avenida Euclides da Cunha
            Bairro = address.District;  // Jardim São Jorge
            Cidade = address.City;      // Paranavaí
            Estado = address.State;     // PR
            Ceps = address.Cep;       // 87710130
        }
    }
}
