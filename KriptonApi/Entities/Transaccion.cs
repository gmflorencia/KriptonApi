using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KriptonApi.Entities
{
    public class Transaccion
    {
        [Key]
        [Column ("IdTransacciones", TypeName = "int") ]
        public int IdTransacciones { get; set; }
        [Required]
        [ForeignKey("Cuentas")]
        public int IdCuentaOrigen { get; set; }
        [Required]
        [ForeignKey("Cuentas")]
        public int IdCuentaDestino { get; set; }
        [Required]
        [ForeignKey("TipoTransaccion")]
        public int IdTipoTransaccion { get; set; }
        [Required]
        [Column("Monto", TypeName = "decimal")]
        public double Monto { get; set; }
        [Required]
        [Column("FechaTransaccion", TypeName = "Date")]
        public DateTime FechaTransaccion { get; set; }


    }
}
