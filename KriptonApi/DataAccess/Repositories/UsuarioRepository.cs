using KriptonApi.DataAccess.Repositories.Interfaces;
using KriptonApi.Entities;
using KriptonApi.DTOs;

namespace KriptonApi.DataAccess.Repositories
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {

        public UsuarioRepository(AppDbContext context) : base(context)
        {
        }
       
    }
}
