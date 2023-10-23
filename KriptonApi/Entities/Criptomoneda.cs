using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using KriptonApi.DTOs;

namespace KriptonApi.Entities
{
    public class Criptomoneda
    {
        public Criptomoneda()
        {

        }
        public Criptomoneda(CriptoDto criptoDto , int idCripto)
        {
            IdCripto = idCripto;
            TasaConversion = criptoDto.TasaConversion;
        }


        [Key]
        [Column("IdCripto", TypeName = "int")]
        public int IdCripto { get; set; }
        [Required]
        [Column("Nombre", TypeName = "VARCHAR (100)")]
        public string Nombre { get; set; }
        [Required]
        [Column("TasaConversion", TypeName = "decimal")]
        public double TasaConversion { get; set; }
    }
}
