using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorDeOperadorasMVC.Models
{
    public class GerenciadorDeOperadorasMVCContext : DbContext
    {
        public GerenciadorDeOperadorasMVCContext (DbContextOptions<GerenciadorDeOperadorasMVCContext> options)
            : base(options)
        {
        }

        public DbSet<Operadora> Operadora { get; set; }
        public DbSet<Beneficiario> Beneficiario { get; set; }
        public DbSet<RegistroPlano> RegistroPlano { get; set; }
    }
}
