using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace Dominio
{
    public class Municipio
    {       
        public int Id {get; set;}

        [Required(ErrorMessage="El campo es obligatorio")]
        [MaxLength(30, ErrorMessage="{0} es de maximo {1} caracteres")]
        [MinLength(3, ErrorMessage="{0} es de minimmo {1} caracteres")]
        public string Nombre1 { get; set;}

        public List<Torneo> Torneos {get;set;}
    }
}