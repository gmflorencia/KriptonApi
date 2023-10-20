using KriptonApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace KriptonApi.DataAccess.DataBaseSeeding
{
    public class ConversionesSeeder : IEntitySeeder
    {
        public void SeedDataBase(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ConversionesSeeder>().HasData(
                new Conversion
                {
                    IdConversion = 1,
                    IdCuentaOrigen = 1,
                    IdCuentaDestino = 2,
                    MontoConvertido = 30000,
                    FechaConversion = DateTime.Now,
                    IdTipoConversion = 1

                },
                new Conversion
                {

                    IdConversion = 2,
                    IdCuentaOrigen = 2,
                    IdCuentaDestino = 3,
                    MontoConvertido = 20000,
                    FechaConversion = DateTime.Now,
                    IdTipoConversion = 2
                },
                new Conversion
                {

                    IdConversion = 3,
                    IdCuentaOrigen = 3,
                    IdCuentaDestino = 1,
                    MontoConvertido = 15000,
                    FechaConversion = DateTime.Now,
                    IdTipoConversion = 3

                }
                );

        }
    }
}
