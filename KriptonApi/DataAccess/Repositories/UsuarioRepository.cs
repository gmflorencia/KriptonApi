using KriptonApi.DataAccess.Repositories.Interfaces;
using KriptonApi.Entities;
using KriptonApi.DTOs;
using KriptonApi.Helpers;
using Microsoft.EntityFrameworkCore;

namespace KriptonApi.DataAccess.Repositories
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {

        public UsuarioRepository(AppDbContext context) : base(context)
        {
        }
        public async Task<Usuario?> AuthenticateCredentials(AuthenticateDto dto)
        {
            return await _context.Usuarios.SingleOrDefaultAsync(x => x.Email == dto.Email && x.Clave == ClaveEncryptHelper.EncryptClave(dto.Clave, dto.Email));
        }
        public override async Task<bool> Update(Usuario updateUsuario)
        {
            var usuario = await _context.Usuarios.FirstOrDefaultAsync(x => x.IdUsuario == updateUsuario.IdUsuario);
            if (usuario == null) { return false; }
            usuario.Nombre = updateUsuario.Nombre;
            usuario.Apellido = updateUsuario.Apellido;
            usuario.Email = updateUsuario.Email;
            usuario.Clave = updateUsuario.Clave;
            usuario.Activo = updateUsuario.Activo;

            _context.Usuarios.Update(usuario);
            return true;
        }
        public override async Task<bool> Delete(int id)
        {
            var usuario = await _context.Usuarios.Where(x => x.IdUsuario == id).FirstOrDefaultAsync();
            if (usuario != null)
            {
                _context.Usuarios.Remove(usuario);
            }

            return true;
        }
    }
}
