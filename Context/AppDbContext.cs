using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using examen_final_desarrollo_de_software.Models;
namespace examen_final_desarrollo_de_software.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Usuario> usuario { get; set; }
        public DbSet<Producto> producto { get; set; }
    }
}
