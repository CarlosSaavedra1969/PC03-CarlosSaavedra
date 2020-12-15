using System;
using System.ComponentModel.DataAnnotations;

namespace PC03_CarlosSaavedra.Models
{
    public class Productos
    {
        public int id{get;set;}
        [Required]
        public string nombre{get;set;}
        [Required]
        public string imagen{get;set;}
        [Required]
        public string descripcion{get;set;}
        [Required]
        public double precio{get;set;}
        [Required]
        public string  nrocel{get;set;}
        [Required]
        public string sitiocompra{get;set;}
        [Required]
        public string id{get;set;}
        [Required]

    }

}