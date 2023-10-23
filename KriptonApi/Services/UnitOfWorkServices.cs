using KriptonApi.DataAccess;
using KriptonApi.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;

namespace KriptonApi.Services
{
    public class UnitOfWorkServices : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public UsuarioRepository UsuarioRepository { get; set; }
        public CriptomonedaRepository CriptomonedaRepository { get; set; }
        public CuentaRepository CuentaRepository { get; set; }
        public TransaccionRepository TransaccionRepository { get; set; }
        public UnitOfWorkServices(AppDbContext context)
        {
            _context = context;
            UsuarioRepository = new UsuarioRepository(_context);
            CriptomonedaRepository = new CriptomonedaRepository(_context);
            CuentaRepository = new CuentaRepository(_context);
            TransaccionRepository = new TransaccionRepository(_context);
        }
        public Task<int> complete()
        {
            return _context.SaveChangesAsync();
        }
    }
}
