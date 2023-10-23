using Microsoft.EntityFrameworkCore;
using KriptonApi.DataAccess.Repositories.Interfaces;
using KriptonApi.Entities;
using KriptonApi.DTOs;
using KriptonApi.Helpers;

namespace KriptonApi.DataAccess.Repositories
{
    public class TransaccionRepository : Repository<Transaccion>, ITransaccionRepository
    {
        public TransaccionRepository(AppDbContext context) : base(context)
        {
        }
        public virtual async Task<List<Transaccion>> GetByIdCuenta(int idCuenta)
        {
            return await _context.Transaccion.Where(e => e.IdCuentaOrigen == idCuenta).ToListAsync();
        }
    }
}
