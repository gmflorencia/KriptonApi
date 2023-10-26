using KriptonApi.DTOs;
using KriptonApi.Entities;
using KriptonApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace KriptonApi.Controllers
{
    [Route("api/cotizacion")]
    [ApiController]
    public class CotizacionController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public CotizacionController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        /// <summary>
        ///  Devuelve la cotizacion de dolar
        /// </summary>
        /// <returns>retona un 200</returns>
        [HttpGet]
        
        public async Task<ActionResult<Cotizacion>> GetAll()
        {
            var criptos = await _unitOfWork.CotizacionRepository.GetAll();
            if (criptos == null)
            {
                return NotFound(); // Devuelve un resultado NotFound si la cuenta no se encuentra.
            }
            return Ok(criptos);

        }
        /// <summary>
        ///  actualiza la cotizacion
        /// </summary>
        /// <returns>retorna un 200</returns>
        [HttpPut("{idCotizacion}")]
        public async Task<IActionResult> Update([FromRoute] int idCotizacion, CotizacionDto dto)
        {
            var result = await _unitOfWork.CotizacionRepository.Update(new Cotizacion(dto, idCotizacion));
            if (result) await _unitOfWork.complete();
            return Ok(result);
        }
    }
}
