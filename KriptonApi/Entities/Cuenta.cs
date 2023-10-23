﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using KriptonApi.DTOs;

namespace KriptonApi.Entities
{
    public class Cuenta
    {
        public Cuenta(CuentaDto cuentaDto, int idCuenta)
        {
            IdCuenta = idCuenta;         
            Alias = cuentaDto.Alias;
            Saldo = cuentaDto.Saldo;
        }


        public Cuenta()
        {

        }


        [Key]
        [Column("IdCuenta", TypeName = "int")]
        public int IdCuenta { get; set; }

        [Required]
        [Column("IdTipoCuenta", TypeName = "int")]
        public int IdTipoCuenta { get; set; }
        [ForeignKey("IdTipoCuenta")]
        public TipoCuenta TipoCuenta { get; set; }
        [Required]
        [Column("IdUsuario", TypeName = "int")]
        public int IdUsuario { get; set; }
        [ForeignKey("IdUsuario")]
        public Usuario Usuario { get; set; }

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
