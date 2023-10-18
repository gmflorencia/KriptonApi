using KriptonApi.DataAccess;
using KriptonApi.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;

namespace KriptonApi.Services
{
    public class UnitOfWorkServices : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public UsuarioRepository UsuarioRepository { get; set; }
        public UnitOfWorkServices(AppDbContext context)
        {
            _context = context;
            UsuarioRepository = new UsuarioRepository(_context);
        }
        public Task<int> Complete()
        {
            return _context.SaveChangesAsync();
        }

        public Task<int> complete()
        {
            throw new NotImplementedException();
        }
    }
}
