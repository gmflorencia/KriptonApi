using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace KriptonApi.Entities
{
    public class TipoTransaccion
    {
        [Key]
        [Column("IdTipoTransaccion", TypeName = "int")]
        public int IdTipoTransaccion { get; set; }
        [Required]
        [Column("Descr", TypeName = "VARCHAR (100)")]
        public string Descr { get; set; }

    }
}
