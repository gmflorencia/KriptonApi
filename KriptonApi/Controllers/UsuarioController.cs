using Azure.Core;
using KriptonApi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KriptonApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class UsuarioController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public UsuarioController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var usuarios = await _unitOfWork.UsuarioRepository.GetAll();
            return Ok(usuarios);
        }

        [HttpGet("{IdUsuario}")]
        public async Task<IActionResult> GetUsuarioById(int IdUsuario)
        {
            var usuario = await _unitOfWork.UsuarioRepository.GetById(IdUsuario);
            if (usuario == null)
            {
                return NotFound();
            }
            return Ok (usuario);
        }


    }
}
