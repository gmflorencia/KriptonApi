using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace KriptonApi.Entities
{
    public class Conversion
    {
        [Key]
        [Column("IdConversion", TypeName = "int")]
        public int IdConversion { get; set; }

        [Required]
        [Column("IdCuentaOrigen", TypeName = "int")]
        public int IdCuentaOrigen { get; set; }

        [Required]
        [Column("IdCuentaDestino", TypeName = "int")]
        public int IdCuentaDestino { get; set; }

        [Required]
        [Column("MontoConvertido", TypeName = "decimal")]
        public double MontoConvertido { get; set; }
        [Required]
        [Column("FechaConversion", TypeName = "Date")]
        public DateTime FechaConversion { get; set; }

        [Required]
        [Column("IdTipoConversion", TypeName = "int")]
        public int IdTipoConversion { get; set; }
        [ForeignKey("IdTipoConversion")]
        public TipoConversion TipoConversion  { get; set; }

        [ForeignKey("IdCuentaOrigen")]
        public Cuenta CuentaOrigen { get; set; }

        [ForeignKey("IdCuentaDestino")]
        public Cuenta CuentaDestino { get; set; }

    }
}
