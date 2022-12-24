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

        public DbSet<GerenciadorDeOperadorasMVC.Models.Operadora> Operadora { get; set; }
    }
}
