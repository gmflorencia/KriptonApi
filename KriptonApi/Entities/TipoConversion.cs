using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace KriptonApi.Entities
{
    public class TipoConversion
    {
        [Key]
        [Column("IdTipoConversion", TypeName = "int")]
        public int IdTipoConversion { get; set; }
        [Required]
        [Column("Descr", TypeName = "VARCHAR (100)")]
        public string Descr { get; set; }

    }
}
