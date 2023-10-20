using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
        [ForeignKey("Cuentas")]
        public int IdCuentaOrigen { get; set; }
        [Required]
        [ForeignKey("Cuentas")]
        public int IdCuentaDestino { get; set; }
        [Required]
        [Column("MontoConvertido", TypeName = "decimal")]
        public double MontoConvertido { get; set; }
        [Required]
        [Column("FechaConversion", TypeName = "Date")]
        public DateTime FechaConversion { get; set; }
        [Required]
        [ForeignKey("TipoConversion")]
        public int IdTipoConversion { get; set; }

    }
}
