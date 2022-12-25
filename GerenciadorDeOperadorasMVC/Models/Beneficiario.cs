using System;
using System.Collections.Generic;
using System.Linq;

namespace GerenciadorDeOperadorasMVC.Models
{
    public class Beneficiario
    {
        public int Id { get; set; }

        //[Required(ErrorMessage = "{0} required")]
        //[StringLength(60, MinimumLength = 3, ErrorMessage = "{0} size should be between {2} and {1}")]
        public string Nome { get; set; }

        //[Required(ErrorMessage = "{0} required")]
        //[EmailAddress(ErrorMessage = "Enter a valid email")]
        //[DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        //[Required(ErrorMessage = "{0} required")]
        //[Display(Name = "Birth Date")]
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Aniversario { get; set; }

        //[Required(ErrorMessage = "{0} required")]
        //[Range(100.0, 50000.0, ErrorMessage = "{0} must be from {1} to {2}")]
        //[Display(Name = "Base Salary")]
        //[DisplayFormat(DataFormatString = "{0:F2}")]
        public double ValorPlano { get; set; }

        public Operadora Operadora { get; set; }
        public int OperadoraId { get; set; }
        public ICollection<RegistroPlano> Planos { get; set; } = new List<RegistroPlano>();

        public Beneficiario()
        {
        }

        public Beneficiario(int id, string nome, string email, DateTime aniversario, double valorPlano, Operadora operadora)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Aniversario = aniversario;
            ValorPlano = valorPlano;
            Operadora = operadora;
        }

        public void AddPlanos(RegistroPlano rp)
        {
            Planos.Add(rp);
        }

        public void RemoverPlanos(RegistroPlano rp)
        {
            Planos.Remove(rp);
        }

        public double PlanosTotais(DateTime inicial, DateTime final)
        {
            return Planos.Where(rp => rp.Data >= inicial && rp.Data <= final).Sum(rp => rp.Valor);
        }
    }
}
