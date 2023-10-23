using KriptonApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace KriptonApi.DataAccess.DataBaseSeeding
{
    public class CriptomonedaSeeder : IEntitySeeder
    {
        public void SeedDataBase(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Criptomoneda>().HasData(
                new Criptomoneda
                {
                    IdCripto = 1,
                    Nombre = "BTC",
                    TasaConversion = 0.25,

                },
                new Criptomoneda
                {
                    IdCripto = 2,
                    Nombre = "ETH",
                    TasaConversion = 0.35
                },
                new Criptomoneda
                {
                    IdCripto = 3,
                    Nombre = "LTC",
                    TasaConversion = 0.30

                }
                );

        }
    }
}
