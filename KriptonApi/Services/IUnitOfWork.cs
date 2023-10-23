using KriptonApi.DataAccess.Repositories;

namespace KriptonApi.Services
{
    public interface IUnitOfWork
    {
        public UsuarioRepository UsuarioRepository { get; }
        public CuentaRepository CuentaRepository { get; set; }
        public CriptomonedaRepository CriptomonedaRepository { get; set; }
        public TransaccionRepository TransaccionRepository { get; set; }
        Task<int> complete();
    }
}
