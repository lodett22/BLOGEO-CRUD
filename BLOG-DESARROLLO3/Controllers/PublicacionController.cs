using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc; // Agrega esta línea para importar el espacio de nombres de MVC
using System.Web.ModelBinding;

namespace BLOG_DESARROLLO3
{
    public class PublicacionController : Controller
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        [HttpPost] // Asegúrate de que esta línea esté ahora disponible con el espacio de nombres correcto
        public ActionResult Crear(Publicaciones publicacion)
        {
            if (ModelState.IsValid)
            {
                _context.Publicaciones.Add(publicacion);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View(publicacion);
        }

        // Implementación de métodos para mostrar publicaciones utilizando _context
    }
}
