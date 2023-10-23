using KriptonApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace KriptonApi.DataAccess.DataBaseSeeding
{
    public class TransaccionSeeder : IEntitySeeder
    {
        public void SeedDataBase(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Transaccion>().HasData(
                new Transaccion
                {
                    IdTransaccion = 1,
                    IdCuentaOrigen = 1,
                    IdCuentaDestino = 2,
                    IdTipoTransaccion = 3,
                    Monto = 10000,
                    FechaTransaccion = DateTime.Now

                },
                new Transaccion
                {
                    IdTransaccion = 2,
                    IdCuentaOrigen = 2,
                    IdCuentaDestino = 3,
                    IdTipoTransaccion = 1,
                    Monto = 20000,
                    FechaTransaccion = DateTime.Now

                },
                new Transaccion
                {
                    IdTransaccion = 3,
                    IdCuentaOrigen = 3,
                    IdCuentaDestino = 1,
                    IdTipoTransaccion = 2,
                    Monto = 30000,
                    FechaTransaccion = DateTime.Now

                }
                );

        }
    }
}
