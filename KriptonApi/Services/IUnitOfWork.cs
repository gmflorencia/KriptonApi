using KriptonApi.DataAccess.Repositories;

namespace KriptonApi.Services
{
    public interface IUnitOfWork
    {
        public UsuarioRepository UsuarioRepository { get; }
        Task<int> complete();
    }
}
