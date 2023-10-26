using KriptonApi.DTOs;
using KriptonApi.Helpers;
using KriptonApi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KriptonApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class LoginController : Controller
    {
        private TokenJwtHelper _tokenJwtHelper;
        private readonly IUnitOfWork _unitOfWork;
        public LoginController(IUnitOfWork unitOfWork, IConfiguration configuration)
        {
            _unitOfWork = unitOfWork;
            _tokenJwtHelper = new TokenJwtHelper(configuration);
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(AuthenticateDto dto)
        {
            var userCredentials = await _unitOfWork.UsuarioRepository.AuthenticateCredentials(dto);
            if (userCredentials is null) return Unauthorized("Las credenciales son incorrectas");

            var token = _tokenJwtHelper.GenerateToken(userCredentials);

            var usuario = new LoginDto()
            {
                Nombre = userCredentials.Nombre,
                Apellido = userCredentials.Apellido,
                Email = userCredentials.Email,
                Token = token
            };
            return Ok(usuario);
        }
    }
}

