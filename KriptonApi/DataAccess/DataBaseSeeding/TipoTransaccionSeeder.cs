using KriptonApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace KriptonApi.DataAccess.DataBaseSeeding
{
    public class TipoTransaccionSeeder : IEntitySeeder
    {
        public void SeedDataBase(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TipoTransaccionSeeder>().HasData(
                new TipoTransaccion
                {
                    IdTipoTransaccion= 1,
                    Descr = "Tranferencia",

                },
                new TipoTransaccion
                {
                    IdTipoTransaccion = 2,
                    Descr = "CompraCripto",
                },
                new TipoTransaccion
                {
                    IdTipoTransaccion = 3,
                    Descr = "Deposito",

                }
                );

        }

    }
}
