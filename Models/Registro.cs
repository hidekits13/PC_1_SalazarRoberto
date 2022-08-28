using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PC_1.Models
{
    public class Registro
    {
        [Display (Name = "Name")]
        public string? Name{get;set;}

        
        [Display (Name = "Matematica")]
        public bool curso1{get;set;}

        [Display (Name = "Lenguaje")]
        public bool curso2{get;set;}

        [Display (Name = "Historia")]
        public bool curso3{get;set;}

        public int creditos{get;set;}
    }
}