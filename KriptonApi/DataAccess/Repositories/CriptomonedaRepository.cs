using KriptonApi.DataAccess.Repositories.Interfaces;
using KriptonApi.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.Internal;

namespace KriptonApi.DataAccess.Repositories
{
    public class CriptomonedaRepository : Repository<Criptomoneda>, ICriptomonedaRepository
    {
        public CriptomonedaRepository(AppDbContext context) : base(context)
        {
        }
        public virtual async Task<List<Criptomoneda>> GetByDescripcion(string descripcion)
        {
            return await _context.Criptomoneda.Where(e => e.Nombre.Contains(descripcion)).ToListAsync();
        }
        public override async Task<bool> Update(Criptomoneda updateCriptomoneda)
        {
            var criptomoneda = await _context.Criptomoneda.FirstOrDefaultAsync(x => x.IdCripto == updateCriptomoneda.IdCripto);
            {
                if (criptomoneda == null) { return false; }
                criptomoneda.TasaConversion = updateCriptomoneda.TasaConversion;

                _context.Criptomoneda.Update(criptomoneda);     
                return true;
            }
        }
    }
}
