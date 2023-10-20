using KriptonApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace KriptonApi.DataAccess.DataBaseSeeding
{
    public class TipoCuentaSeeder : IEntitySeeder
    {
        public void SeedDataBase(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TipoCuentaSeeder>().HasData(
                new TipoCuenta
                {
                    IdTipoCuenta = 1,
                    Descr = "pesos",

                },
                new TipoCuenta
                {
                    IdTipoCuenta = 2,
                    Descr = "dolares",
                },
                new TipoCuenta
                {
                    IdTipoCuenta = 3,
                    Descr = "Criptomoneda",

                }
                );

        }
    }
}
