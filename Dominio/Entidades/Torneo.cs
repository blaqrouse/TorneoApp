using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Dominio
{
    public class Torneo
    {       
        public int Id {get; set;}

        [Required(ErrorMessage="El campo es obligatorio")]
        [MaxLength(30, ErrorMessage="{0} es de maximo {1} caracteres")]
        [MinLength(3, ErrorMessage="{0} es de minimmo {1} caracteres")]
        public string Nombre1 { get; set;}

        [Required(ErrorMessage="El campo es obligatorio")]
        [MaxLength(10, ErrorMessage="{0} es de maximo {1} caracteres")]
        [MinLength(5, ErrorMessage="{0} es de minimmo {1} caracteres")]
        public string Categoria { get; set;}

        [Required(ErrorMessage="El campo es obligatorio")]
        [MaxLength(15, ErrorMessage="{0} es de maximo {1} caracteres")]
        [MinLength(5, ErrorMessage="{0} es de minimmo {1} caracteres")]
        public string Modalidad { get; set;}

        [Required(ErrorMessage="El campo es obligatorio")]
        [DataType(DataType.Date)]
        public DateTime FechaComienzo { get; set;}

        [Required(ErrorMessage="El campo es obligatorio")]
        [DataType(DataType.Date)]
        public DateTime FechaFinal { get; set;}

        [Required(ErrorMessage="El campo es obligatorio")]
        public int Equipos { get; set;}

        [Required(ErrorMessage="El campo es obligatorio")]
        [MaxLength(20, ErrorMessage="{0} es de maximo {1} caracteres")]
        [MinLength(15, ErrorMessage="{0} es de minimmo {1} caracteres")]
        public string Fixture { get; set;}

        [Required(ErrorMessage="El campo es obligatorio")]
        public int MunicipId { get; set;}

    }
}