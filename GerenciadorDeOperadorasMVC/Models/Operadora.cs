using System;
using System.Collections.Generic;
using System.Linq;

namespace GerenciadorDeOperadorasMVC.Models
{
    public class Operadora
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Beneficiario> Beneficiarios { get; set; } = new List<Beneficiario>();

        public Operadora()
        {
        }

        public Operadora(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public void AddBeneficiario(Beneficiario beneficiario)
        {
            Beneficiarios.Add(beneficiario);
        }

        public double PlanosTotais(DateTime inicial, DateTime final)
        {
            return Beneficiarios.Sum(beneficiario => beneficiario.PlanosTotais(inicial, final));
        }
    }
}
