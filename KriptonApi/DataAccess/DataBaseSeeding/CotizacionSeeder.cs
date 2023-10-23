using KriptonApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace KriptonApi.DataAccess.DataBaseSeeding
{
    public class CotizacionSeeder : IEntitySeeder
    {
        public void SeedDataBase(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cotizacion>().HasData(
                new Cotizacion
                {
                    IdCotizacion = 1,
                    IdMoneda = 1,
                    Compra = 347.50M,
                    Venta = 365.5M,
                    Activo =  true,
                },
                new Cotizacion
                {
                    IdCotizacion = 2,
                    IdMoneda = 2,
                    Compra = 369.89M,
                    Venta = 370.47M,
                    Activo = true,
                });
        }
    }
}
