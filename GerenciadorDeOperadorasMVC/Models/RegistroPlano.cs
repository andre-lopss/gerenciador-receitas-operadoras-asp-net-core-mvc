using GerenciadorDeOperadorasMVC.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace GerenciadorDeOperadorasMVC.Models
{
    public class RegistroPlano
    {
        public int Id { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Data { get; set; }
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double Valor { get; set; }
        public StatusPlano Status { get; set; }
        public Beneficiario Beneficiario { get; set; }

        public RegistroPlano()
        {
        }

        public RegistroPlano(int id, DateTime data, double valor, StatusPlano status, Beneficiario beneficiario)
        {
            Id = id;
            Data = data;
            Valor = valor;
            Status = status;
            Beneficiario = beneficiario;
        }
    }
}
