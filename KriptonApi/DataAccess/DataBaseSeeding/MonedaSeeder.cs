using KriptonApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace KriptonApi.DataAccess.DataBaseSeeding
{
    public class MonedaSeeder : IEntitySeeder
    {
        public void SeedDataBase(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Moneda>().HasData(
                new Moneda
                {
                    IdMoneda = 1,
                    Descripcion = "Dólar",
                    Simbolo = "u$s",
                    Activo = true,
                },
                new Moneda
                {
                    IdMoneda = 2,
                    Descripcion = "Euro",
                    Simbolo = "€",
                    Activo = true,
                }
                );
        }
    }
}
