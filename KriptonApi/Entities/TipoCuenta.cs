﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace KriptonApi.Entities
{
    public class TipoCuenta
    {
        [Key]
        [Column("IdTipoCuenta", TypeName = "int")]
        public int IdTipoCuenta { get; set; }
        [Required]
        [Column("Descr", TypeName = "VARCHAR (100)")]
        public string Descr { get; set; }
    }
}
