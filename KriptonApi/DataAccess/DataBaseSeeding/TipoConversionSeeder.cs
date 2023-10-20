using KriptonApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace KriptonApi.DataAccess.DataBaseSeeding
{
    public class TipoConversionSeeder : IEntitySeeder
    {
        public void SeedDataBase(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TipoConversionSeeder>().HasData(
                new TipoConversion
                {
                    IdTipoConversion = 1,
                    Descr = "pesosADolares",

                },
                new TipoConversion
                {
                    IdTipoConversion = 2,
                    Descr = "DolaresACripto",
                },
                new TipoConversion
                {
                    IdTipoConversion = 3,
                    Descr = "PesosADolares",

                }
                );

        }
    }
}
