using KriptonApi.Entities;
using Microsoft.EntityFrameworkCore;


namespace KriptonApi.DataAccess.DataBaseSeeding
{
    public class CuentaSeeder : IEntitySeeder
    {
        public void SeedDataBase(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cuenta>().HasData(
                new Cuenta
                {
                    IdCuenta = 1,
                    IdTipoCuenta = 1,
                    IdUsuario = 1,
                    Saldo = 50000,
                    Cbu = "01702046600000087865",
                    Alias = "Patria.gorro.Caucho",
                    NumeroCuenta = 204878658,
                    UUID = "12345678123456781234567812345678",
                    Activo = true,


                },
                new Cuenta
                {
                    IdCuenta = 2,
                    IdTipoCuenta = 2,
                    IdUsuario = 2,
                    Saldo = 80000,
                    Cbu = "0290000100000000058382",
                    Alias = "Raiz.Arbol.Planta",
                    NumeroCuenta = 5838,
                    UUID = "123456781234-56781234567812345678",
                    Activo = true,
                },
                new Cuenta
                {
                    IdCuenta = 3,
                    IdTipoCuenta = 3,
                    IdUsuario= 3,
                    Saldo = 90000,
                    Cbu = "0110599520000001235579",
                    Alias = "Alfil.Oslo.Rima",
                    NumeroCuenta = 123557,
                    UUID = "123456781234-56781234567812785643",
                    Activo = true,

                }
                );
                
        }
    }
}
