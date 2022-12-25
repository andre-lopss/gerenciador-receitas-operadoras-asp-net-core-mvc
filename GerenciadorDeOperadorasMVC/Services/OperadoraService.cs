using GerenciadorDeOperadorasMVC.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorDeOperadorasMVC.Services
{
    public class OperadoraService
    {
        private readonly GerenciadorDeOperadorasMVCContext _context;

        public OperadoraService(GerenciadorDeOperadorasMVCContext context)
        {
            _context = context;
        }

        public async Task<List<Operadora>> FindAllAsync()
        {
            return await _context.Operadora.OrderBy(x => x.Nome).ToListAsync();
        }
    }
}
