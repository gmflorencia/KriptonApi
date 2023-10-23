using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using KriptonApi.DTOs;

namespace KriptonApi.Entities
{
    public class Transaccion
    {
        public Transaccion(TransaccionDto transferenciaDto)
        {
            IdCuentaOrigen = transferenciaDto.IdCuentaOrigen;
            IdCuentaDestino = transferenciaDto.IdCuentaDestino;
            IdTipoTransaccion = transferenciaDto.IdTipoTransaccion;
            Monto = transferenciaDto.Monto;
            FechaTransaccion = transferenciaDto.FechaTransferencia;
        }
        public Transaccion()
        {

        }

        [Key]
        [Column("IdTransaccion", TypeName = "int")]
        public int IdTransaccion { get; set; }

        [Required]
        [Column("IdCuentaOrigen", TypeName = "int")]
        public int IdCuentaOrigen { get; set; }

        [Required]
        [Column("IdCuentaDestino", TypeName = "int")]
        public int IdCuentaDestino { get; set; }

        [Required]
        [Column("IdTipoTransaccion", TypeName = "int")]
        public int IdTipoTransaccion { get; set; }
        [ForeignKey("IdTipoTransaccion")]
        public TipoTransaccion TipoTransaccion { get; set; }

        [Required]
        [Column("Monto", TypeName = "decimal")]
        public double Monto { get; set; }
        [Required]
        [Column("FechaTransaccion", TypeName = "Date")]
        public DateTime FechaTransaccion { get; set; }

        [ForeignKey("IdCuentaOrigen")]
        public Cuenta CuentaOrigen { get; set; }

        [ForeignKey("IdCuentaDestino")]
        public Cuenta CuentaDestino { get; set; }


    }
}
