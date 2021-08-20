using System.ComponentModel.DataAnnotations;
namespace DemoRest1.Models
{
    public class ConsultaCep
    {
        [Required]
        [StringLength(100)]
        public string Logradouro {get;set;}
        [Required]
        [StringLength(30)]
        public string Bairro {get;set;}
        [Required]
        [StringLength(50)]
        public string Cidade {get;set;}
        [Required]
        [RegularExpression(@"^[A-Z]{2}$")]
        public string Estado {get;set;}
        [Required]
        [RegularExpression(@"^\d{8}$", ErrorMessage = "O CEP Deve possuir 8 digitos")]
        public string Cep {get;set;}

        public override string ToString()
        {
            return $"Logradouro: {Logradouro}, Bairro: {Bairro}, Cidade: {Cidade}, Estado: {Estado}, Cep: {Cep}";
        }
    }
}