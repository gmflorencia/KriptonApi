using KriptonApi.DataAccess.Repositories.Interfaces;
using KriptonApi.DTOs;
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
        public double saldoOrigen { get; set; }
        public double saldoDestino { get; set; }
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
        public override async Task<bool> Compra(CompraCriptoDto compraDto)
        {
            var tipoCuenta = await _context.Cuenta.FirstOrDefaultAsync(x => x.IdCuenta == compraDto.IdCuentaOrigen && x.IdTipoCuenta == 1);
            if (tipoCuenta == null) { return false; }

            var cotizacion = await _context.Cotizacion.FirstOrDefaultAsync(x => x.IdCotizacion == 1);
            if (cotizacion == null) { return false; }

            var tasa = await _context.Criptomoneda.FirstOrDefaultAsync(x => x.IdCripto == compraDto.IdCripto);
            if (tasa == null) return false;

            var cantidad = (compraDto.Monto * cotizacion.Compra) * Convert.ToDecimal(tasa.TasaConversion);

            var cuentaDestino = await _context.Cuenta.FirstOrDefaultAsync(x => x.IdCuenta == compraDto.IdCuentaDestino && x.IdTipoCuenta == 3);
            if (cuentaDestino == null) return false;

            var saldoCtaD = cantidad + Convert.ToDecimal(cuentaDestino.Saldo);

            saldoDestino = Convert.ToDouble(saldoCtaD);
            saldoOrigen = tipoCuenta.Saldo - Convert.ToDouble(compraDto.Monto);

            return true;

        }
    }
}
