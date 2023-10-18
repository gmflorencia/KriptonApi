using Microsoft.EntityFrameworkCore;

namespace KriptonApi.DataAccess.DataBaseSeeding
{
    public interface IEntitySeeder
    {
        void SeedDataBase(ModelBuilder modelBuilder);
    }
}
