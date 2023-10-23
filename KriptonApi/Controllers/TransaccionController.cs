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
