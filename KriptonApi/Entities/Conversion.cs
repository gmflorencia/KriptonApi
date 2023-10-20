using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace KriptonApi.Entities
{
    public class Conversion
    {
        [Key]
        [Column("IdConversion", TypeName = "int")]
        public int IdConversion { get; set; }
        
        [ForeignKey("IdCuenta")]
        public Cuenta IdCuentaOrigen { get; set; }
        
        [ForeignKey("IdCuenta")]
        public Cuenta IdCuentaDestino { get; set; }
        [Required]
        [Column("MontoConvertido", TypeName = "decimal")]
        public double MontoConvertido { get; set; }
        [Required]
        [Column("FechaConversion", TypeName = "Date")]
        public DateTime FechaConversion { get; set; }
        
        [ForeignKey("IdTipoConversion")]
        public TipoConversion tipoConversion { get; set; }

    }
}
