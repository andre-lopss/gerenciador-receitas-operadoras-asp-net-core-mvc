using GerenciadorDeOperadorasMVC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorDeOperadorasMVC.Services
{
    public class RegistroPlanosService
    {
        private readonly GerenciadorDeOperadorasMVCContext _context;

        public RegistroPlanosService(GerenciadorDeOperadorasMVCContext context)
        {
            _context = context;
        }

        public async Task<List<RegistroPlano>> LocalizarPorDataAsync(DateTime? dataMinima, DateTime? dataMaxima)
        {
            var resultado = from obj in _context.RegistroPlano select obj;
            if (dataMinima.HasValue)
            {
                resultado = resultado.Where(x => x.Data >= dataMinima.Value);
            }
            if (dataMaxima.HasValue)
            {
                resultado = resultado.Where(x => x.Data <= dataMaxima.Value);
            }
            return await resultado
                .Include(x => x.Beneficiario)
                .Include(x => x.Beneficiario.Operadora)
                .OrderByDescending(x => x.Data)
                .ToListAsync();
        }

        public async Task<List<IGrouping<Operadora, RegistroPlano>>> LocalizarPorGrupoDeDataAsync(DateTime? dataMinima, DateTime? dataMaxima)
        {
            var resultado = from obj in _context.RegistroPlano select obj;
            if (dataMinima.HasValue)
            {
                resultado = resultado.Where(x => x.Data >= dataMinima.Value);
            }
            if (dataMaxima.HasValue)
            {
                resultado = resultado.Where(x => x.Data <= dataMaxima.Value);
            }
            return await resultado
                .Include(x => x.Beneficiario)
                .Include(x => x.Beneficiario.Operadora)
                .OrderByDescending(x => x.Data)
                .GroupBy(x => x.Beneficiario.Operadora)
                .ToListAsync();
        }
    }
}
