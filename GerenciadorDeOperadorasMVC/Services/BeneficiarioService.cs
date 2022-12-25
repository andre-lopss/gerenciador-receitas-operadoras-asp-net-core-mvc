using GerenciadorDeOperadorasMVC.Models;
using GerenciadorDeOperadorasMVC.Services.Exceptions;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GerenciadorDeOperadorasMVC.Services
{
    public class BeneficiarioService
    {
        private readonly GerenciadorDeOperadorasMVCContext _context;

        public BeneficiarioService(GerenciadorDeOperadorasMVCContext context)
        {
            _context = context;
        }

        public async Task<List<Beneficiario>> FindAllAsync()
        {
            return await _context.Beneficiario.ToListAsync();
        }

        public async Task InsertAsync(Beneficiario obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<Beneficiario> FindByIdAsync(int id)
        {
            return await _context.Beneficiario.Include(obj => obj.Operadora).FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _context.Beneficiario.FindAsync(id);
                _context.Beneficiario.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                throw new IntegrityException("Não é possível excluir o beneficiário porque ele tem um Plano.");
            }
        }

        public async Task UpdateAsync(Beneficiario obj)
        {
            if (!await _context.Beneficiario.AnyAsync(x => x.Id == obj.Id))
            {
               throw new NotFoundException("Id não encontrado");
            }
            try
            {
                _context.Update(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}
