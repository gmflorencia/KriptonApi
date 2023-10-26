using KriptonApi.DTOs;
using KriptonApi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using KriptonApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace KriptonApi.Controllers
{
    [Route("api/transaccion")]
    [ApiController]
    [Authorize]
    public class TransaccionController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public TransaccionController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        /// <summary>
        ///  realiza una transaccion, puede ser tranferencia, o deposito
        /// </summary>
        /// <returns>Eliminado o un 500</returns>

        [HttpPost]
        [Route("transaccion")]
        public async Task<IActionResult> Tranferencia(TransaccionDto dto)
        {
            var transferencia = await _unitOfWork.TransaccionRepository.Insert(new Transaccion(dto));
            if (!transferencia)
            {
                return NotFound("El usuario emisor no se encontró.");
            }
            await _unitOfWork.complete();
            return Ok(transferencia);

        }

        /// <summary>
        ///  Devuelve todos los movimientos de una cuenta por id
        /// </summary>
        /// <returns>retorna un 200</returns>

        [HttpGet]
        [Route("movimientos/{idCuenta}")]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<Transaccion>>> GetByIdCuenta(int idCuenta)
        {
            var transacciones = await _unitOfWork.TransaccionRepository.GetByIdCuenta(idCuenta);
            if (transacciones != null)
            {
                return transacciones;
            }
            return NotFound();
        }

    }
}
