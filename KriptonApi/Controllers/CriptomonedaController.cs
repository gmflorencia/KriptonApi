using KriptonApi.DTOs;
using KriptonApi.Entities;
using KriptonApi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        /// <summary>
        ///  devuelve todos los detalles de las criptos
        /// </summary>
        /// <returns>retorna un 200</returns>


        [HttpGet]
        [Authorize]
        public async Task<ActionResult<Criptomoneda>> GetAll()
        {
            var criptos = await _unitOfWork.CriptomonedaRepository.GetAll();
            if (criptos == null)
            {
                return NotFound(); // Devuelve un resultado NotFound si la cuenta no se encuentra.
            }
            return Ok(criptos);

        }
        /// <summary>
        ///  Devuelve los datos de una cripto segun su descripcion
        /// </summary>
        /// <returns>retorna un 200</returns>

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
        /// <summary>
        ///  Actualiza la tasa de conversion de una cripto por id
        /// </summary>
        /// <returns>retorna un 200</returns>

        [HttpPut("{idCripto}")]
        public async Task<IActionResult> Update([FromRoute] int idCripto, CriptoDto dto)
        {
            var result = await _unitOfWork.CriptomonedaRepository.Update(new Criptomoneda(dto, idCripto));
            if (result) await _unitOfWork.complete();
            return Ok(result);
        }

        /// <summary>
        ///  realiza la compra de cripto
        /// </summary>
        /// <returns>retorna un 200</returns>
        [HttpPost]
        [Route("Compra")]
        public async Task<IActionResult> Compra(CompraCriptoDto dto)
        {
            var result = await _unitOfWork.CriptomonedaRepository.Compra(dto);

            var updateCuentaDestino = _unitOfWork.CuentaRepository.Update(new Cuenta
            {
                IdCuenta = dto.IdCuentaDestino,
                Saldo = _unitOfWork.CriptomonedaRepository.saldoDestino
            });
            await _unitOfWork.complete(); 

            var updateCuentaOrigen = _unitOfWork.CuentaRepository.Update(new Cuenta
            {
                IdCuenta = dto.IdCuentaOrigen,
                Saldo = _unitOfWork.CriptomonedaRepository.saldoOrigen,
            });
            await _unitOfWork.complete();
            return Ok(result);
        }
    }
}
