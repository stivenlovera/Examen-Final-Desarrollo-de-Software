using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace examen_final_desarrollo_de_software.Models
{
    public class Usuario
    {
        [Key]
        public int id { get; set; }
        public string correo { get; set; }
        public string password { get; set; }
        public string username { get; set; }
        public bool estado { get; set; }
    }
}
