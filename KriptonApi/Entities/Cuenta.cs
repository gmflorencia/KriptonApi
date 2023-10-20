using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace KriptonApi.Entities
{
    public class Cuenta
    {
        [Key]
        [Column("IdCuenta", TypeName = "int")]
        public int IdCuenta { get; set; }
        
        [ForeignKey("IdTipoCuenta")]
        public TipoCuenta tipoCuenta { get; set; }
        [Required]
        [Column("Saldo", TypeName = "decimal")]
        public double Saldo { get; set; }
        [Required]
        [Column("Cbu", TypeName = "VARCHAR (100)")]
        public string Cbu { get; set; }
        [Required]
        [Column("NumeroCuenta", TypeName = "int")]
        public int NumeroCuenta { get; set; }
        [Required]
        [Column("Alias", TypeName = "VARCHAR (100)")]
        public string Alias { get; set; }
        [Required]
        [Column("UUID", TypeName = "VARCHAR (100)")]
        public string UUID { get; set; }
        [Required]
        [Column("Activo", TypeName = "bit")]
        public bool Activo { get; set; }
    }
   
}
