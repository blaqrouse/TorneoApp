using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Dominio
{
    public class Colegio
    {       
        
        public int Id {get; set;}

        [Required(ErrorMessage="El campo es obligatorio")]
        [MaxLength(8, ErrorMessage="{0} es de maximo {1} caracteres")]
        [MinLength(8, ErrorMessage="{0} es de minimmo {1} caracteres")]
        public string Nit{ get; set;}
        public string RazonSocial {get; set;}
        public string Direccion {get; set;}
        public string Telefono {get; set;}
        public string Modalidad {get;set;}
        public string Licencia {get;set;}
        
    }
}