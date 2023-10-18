using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace KriptonApi.Entities
{
    public class Usuario
    {
        [Key]
        [Column("IdUsuario", TypeName = "int")]
        public int IdUsuario { get; set; }
        [Required]
        [Column("Nombre", TypeName = "VARCHAR (100)")]
        public string Nombre { get; set; }
        [Required]
        [Column("Apellido", TypeName = "VARCHAR (100)")]
        public string Apellido { get; set; }
        [Required]
        [Column("Dni", TypeName = "int")]
        public int Dni { get; set; }
        [Required]
        [Column("Email", TypeName = "VARCHAR (100)")]
        public string Email { get; set; }
        [Required]
        [Column("CLave", TypeName = "VARCHAR (100)")]
        public string Clave { get; set; }
        [Required]
        [Column("Activo", TypeName = "bit")]
        public bool Activo { get; set; }
    }
}
