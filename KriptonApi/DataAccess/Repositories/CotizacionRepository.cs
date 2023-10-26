using KriptonApi.DataAccess.Repositories.Interfaces;
using KriptonApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace KriptonApi.DataAccess.Repositories
{
    public class CotizacionRepository : Repository<Cotizacion>, ICotizacionRepository
    {
        public CotizacionRepository (AppDbContext context) : base(context)
        {
        }
        public override async Task<bool> Update(Cotizacion updateCotizacion)
        {
            var cotizacion = await _context.Cotizacion.FirstOrDefaultAsync(x => x.IdCotizacion == updateCotizacion.IdCotizacion);
            {
                if (cotizacion == null) { return false; }
                cotizacion.Compra = updateCotizacion.Compra;
                cotizacion.Venta = updateCotizacion.Venta;

                _context.Cotizacion.Update(cotizacion);
                return true;
            }
        }
    }
}
