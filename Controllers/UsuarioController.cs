using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using examen_final_desarrollo_de_software.Models;
using examen_final_desarrollo_de_software.Context;
namespace examen_final_desarrollo_de_software.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly AppDbContext context;
        public UsuarioController(AppDbContext _context)
        {
            this.context = _context;
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            return Ok(context.usuario.ToList());
        }
        [HttpGet("id", Name = "GetById")]
        public ActionResult GetById(int id)
        {
            try
            {
                var usuario = context.usuario.FirstOrDefault(usuario => usuario.id == id);
                return Ok(usuario);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public ActionResult Post([FromBody] Usuario usuario)
        {
            try
            {
                context.usuario.Add(usuario);
                context.SaveChanges();
                return CreatedAtRoute("GetById", new { usuario.id }, usuario);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }

}
