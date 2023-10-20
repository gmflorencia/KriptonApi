using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KriptonApi.Entities
{
    public class Transaccion
    {
        [Key]
        [Column ("IdTransacciones", TypeName = "int") ]
        public int IdTransacciones { get; set; }
        
        [ForeignKey("IdCuenta")]
        public Cuenta IdcuentaOrigen { get; set; }
        
        [ForeignKey("IdCuenta")]
        public Cuenta IdcuentaDestino { get; set; }
        
        [ForeignKey("IdTipoTransaccion")]
        public TipoTransaccion tipoTransaccion { get; set; }
        [Required]
        [Column("Monto", TypeName = "decimal")]
        public double Monto { get; set; }
        [Required]
        [Column("FechaTransaccion", TypeName = "Date")]
        public DateTime FechaTransaccion { get; set; }


    }
}
