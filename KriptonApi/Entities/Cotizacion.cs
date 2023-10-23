using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using KriptonApi.DTOs;

namespace KriptonApi.Entities
{
    public class Cotizacion
    {
        [Key]
        [Column("IdCotizacion", TypeName = "int")]
        public int IdCotizacion { get; set; }

        [Required]
        [Column("IdMoneda", TypeName = "int")]
        public int IdMoneda { get; set; }
        [ForeignKey("IdMoneda")]
        public Moneda Moneda { get; set; }

        [Required]
        [Column("Compra", TypeName = "money")]
        public decimal Compra { get; set; }

        [Required]
        [Column("Venta", TypeName = "money")]
        public decimal Venta { get; set; }

        [Required]
        [Column("Activo", TypeName = "bit")]
        public bool Activo { get; set; }
    }
}
