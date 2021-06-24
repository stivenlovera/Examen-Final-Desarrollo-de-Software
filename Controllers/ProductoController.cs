using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using examen_final_desarrollo_de_software.Context;
using examen_final_desarrollo_de_software.Models;
namespace examen_final_desarrollo_de_software.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly AppDbContext context;
        public ProductoController(AppDbContext _context)
        {
            this.context = _context;
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            try
            {
                return Ok(context.producto.Include(producto=> producto.usuario).ToList());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
           
        }
        /*[HttpGet("id", Name = "GetById")]
        public ActionResult GetById(int id)
        {
            try
            {
                var producto = context.producto.FirstOrDefault(producto => producto.id == id);
                return Ok(producto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }*/
        [HttpPost]
        public ActionResult Post([FromBody] Producto producto)
        {
            try
            {
                context.producto.Add(producto);
                context.SaveChanges();
                return CreatedAtRoute("GetById", new { producto.id }, producto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
