using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace examen_final_desarrollo_de_software.Models
{
    public class Producto
    {
        [Key]
        public int id { get; set; }
        public string nombre { get; set; }
        public int usuarioId { get; set; }
        public Usuario usuario { get; set; }
        public double precio { get; set; }
        public string descripcion { get; set; }
        public string marca { get; set; }
        public bool estado { get; set; }
    }
}
