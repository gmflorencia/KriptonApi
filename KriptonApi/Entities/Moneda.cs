using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using KriptonApi.DTOs;

namespace KriptonApi.Entities
{
    public class Moneda
    {
        [Key]
        [Column("IdMoneda", TypeName = "INT")]
        public int IdMoneda { get; set; }
        
        [Required]
        [Column("Descripcion", TypeName = "VARCHAR(20)")]
        public string Descripcion { get; set; }

        [Required]
        [Column("Simbolo", TypeName = "VARCHAR(5)")]
        public string Simbolo { get; set; }

        [Required]
        [Column("Activo", TypeName = "BIT")]
        public bool Activo { get; set; }
    }
}
