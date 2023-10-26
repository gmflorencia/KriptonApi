using Azure.Core;
using KriptonApi.DTOs;
using KriptonApi.Entities;
using KriptonApi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KriptonApi.Controllers
{
    [Route("api/Usuario")]
    [ApiController]
    [Authorize]
    public class UsuarioController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public UsuarioController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        /// <summary>
        ///  Devuelve todo los usuarios
        /// </summary>
        /// <returns>retorna todos los usuarios</returns>


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Usuario>>> GetAll()
        {
            var usuarios = await _unitOfWork.UsuarioRepository.GetAll();

            return usuarios;
        }

        [HttpGet("{idUsuario}")]
        public async Task<ActionResult<Usuario>> GetUsuarioById(int idUsuario)
        {
            var usuario = await _unitOfWork.UsuarioRepository.GetById(idUsuario);
            if (usuario == null)
            {
                return NotFound(); // Devuelve un resultado NotFound si el usuario no se encuentra.
            }
            return Ok (usuario);
        }

        /// <summary>
        ///  Registra el usuario
        /// </summary>
        /// <returns>devuelve un usuario registrado con un statusCode 201</returns>

        [HttpPost]
        [Route("Rergister")]
        public async Task<IActionResult> Register(RegisterDto dto)
        {
            await _unitOfWork.UsuarioRepository.Insert(new Usuario(dto));
            await _unitOfWork.complete();
            return Ok(true);
        }

        /// <summary>
        ///  Actualiza el usuario
        /// </summary>
        /// <returns>actualizado o un 500</returns>


        [HttpPut("{idUsuario}")]
        public async Task<IActionResult> Update([FromRoute] int IdUsuario, RegisterDto dto)
        {
            var result = await _unitOfWork.UsuarioRepository.Update(new Usuario(dto, IdUsuario));
            if (result) await _unitOfWork.complete();
            return Ok(result);
        }
        /// <summary>
        ///  Elimina el usuario
        /// </summary>
        /// <returns>Eliminado o un 500</returns>


        [HttpDelete("{idUsuario}")]

        public async Task<IActionResult> Delete([FromRoute] int idUsuario)
        {
            Usuario usuario = await _unitOfWork.UsuarioRepository.GetById(idUsuario);
            if (usuario == null)
            {
                return NotFound(); // Devuelve un resultado NotFound si el usuario no se encuentra.
            }
            var result = await _unitOfWork.UsuarioRepository.Update(new Usuario
            {
                IdUsuario = idUsuario,
                Nombre = usuario.Nombre,
                Apellido = usuario.Apellido,
                Dni = usuario.Dni,
                Email = usuario.Email,
                Clave = usuario.Clave,
                Activo = false
            });
            if (result) await _unitOfWork.complete();
            return Ok(result);
        }
    }
}
