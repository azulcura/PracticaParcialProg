using ConsultaLibros.Models.Entities;
using ConsultaLibros.Services;
using Microsoft.AspNetCore.Mvc;

namespace ConsultaLibros.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibrosController : ControllerBase
    {
        private readonly LibroServices _libroServices;
        public LibrosController(LibroServices libroServices)
        {
            _libroServices = libroServices;
        }
        [HttpGet]

        public IActionResult GetAll()
        {
            return Ok(_libroServices.GetAll());
        }
        [HttpGet("{id}")]
        public IActionResult GetOne(int id) {
            Libro? libros = _libroServices.GetOne(id);
            if (libros != null)
            {
                return Ok(libros);
            }
            return BadRequest("no existe");
            
        }
    }
}
