using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KriptonApi.Entities
{
    public class Transaccion
    {
        [Key]
        [Column("IdTransacciones", TypeName = "int")]
        public int IdTransacciones { get; set; }

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
