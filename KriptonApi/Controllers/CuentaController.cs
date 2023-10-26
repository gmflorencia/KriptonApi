using KriptonApi.DTOs;
using KriptonApi.Entities;
using KriptonApi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KriptonApi.Controllers
{
    [Route("api/cuenta")]
    [ApiController]
    [Authorize]
    public class CuentaController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public CuentaController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        /// <summary>
        ///  Devuelve el detalle de una cuenta por id
        /// </summary>
        /// <returns>retorna un 200</returns>


        [HttpGet("{idCuenta}")]
        [Authorize]
        public async Task<ActionResult<Cuenta>> GetCuentaById(int idCuenta)
        {
            var cuenta = await _unitOfWork.CuentaRepository.GetById(idCuenta);
            if (cuenta == null)
            {
                return NotFound(); // Devuelve un resultado NotFound si la cuenta no se encuentra.
            }
            return Ok(cuenta);

        }
        /// <summary>
        ///  Actualiza la cuenta, alias y saldo
        /// </summary>
        /// <returns> actualizada o un 500</returns>


        [HttpPut("{idCuenta}")]
        public async Task<IActionResult> Update([FromRoute] int idCuenta, CuentaDto dto)
        {
            var result = await _unitOfWork.CuentaRepository.Update(new Cuenta(dto, idCuenta));
            if (result) await _unitOfWork.complete();
            return Ok(result);
        }


    }
}
