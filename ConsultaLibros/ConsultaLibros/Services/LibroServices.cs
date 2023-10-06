using ConsultaLibros.Models.Entities;

namespace ConsultaLibros.Services
{
    public class LibroServices
    {
        public List<Libro> libros;
        public LibroServices() {
            libros = new List<Libro>() {
            new Libro() {
                Id= 1,
                Nombre="Billiken",
                Marca="Rivadavia"
            }
            };
        }
        public List<Libro> GetAll()
        {
            return libros;
        }

        public Libro? GetOne(int id)
        {
            return libros.SingleOrDefault(x => x.Id == id);
        }
    }
}
