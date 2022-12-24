using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorDeOperadorasMVC.Models
{
    public class Operadora
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Operadora()
        {
        }
        public Operadora(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

    }
}
