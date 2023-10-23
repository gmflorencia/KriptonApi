using KriptonApi.DTOs;
using KriptonApi.Entities;
using KriptonApi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KriptonApi.Controllers
{
    [Route("api/criptomoneda")]
    [ApiController]
    public class CriptomonedaController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public CriptomonedaController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        //[Authorize]
        public async Task<ActionResult<Criptomoneda>> GetAll()
        {
            var criptos = await _unitOfWork.CriptomonedaRepository.GetAll();
            if (criptos == null)
            {
                return NotFound(); // Devuelve un resultado NotFound si la cuenta no se encuentra.
            }
            return Ok(criptos);

        }

        [HttpGet]
        [Route("cripto/{cripto}")]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<Criptomoneda>>> GetByDescripcion(string cripto)
        {
            var criptos = await _unitOfWork.CriptomonedaRepository.GetByDescripcion(cripto);
            if (criptos != null)
            {
                return criptos;
            }
            return NotFound();
        }
        [HttpPut("{idCripto}")]
        public async Task<IActionResult> Update([FromRoute] int idCripto, CriptoDto dto)
        {
            var result = await _unitOfWork.CriptomonedaRepository.Update(new Criptomoneda(dto, idCripto));
            if (result) await _unitOfWork.complete();
            return Ok(result);
        }

    }
}
