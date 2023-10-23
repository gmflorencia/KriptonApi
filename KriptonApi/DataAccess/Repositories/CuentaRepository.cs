using KriptonApi.DataAccess.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using KriptonApi.Entities;


namespace KriptonApi.DataAccess.Repositories
{
    public class CuentaRepository : Repository<Cuenta>, ICuentaRepository
    {
        public CuentaRepository(AppDbContext context) : base(context)
        {
        }
        public override async Task<bool> Update(Cuenta updateCuenta)
        {
            var cuenta = await _context.Cuenta.FirstOrDefaultAsync(x => x.IdCuenta == updateCuenta.IdCuenta);
            if (cuenta == null) { return false; }
            cuenta.Alias = updateCuenta.Alias;
            cuenta.Saldo = updateCuenta.Saldo;

            _context.Cuenta.Update(cuenta);
            return true;
        }
        
    }
}
