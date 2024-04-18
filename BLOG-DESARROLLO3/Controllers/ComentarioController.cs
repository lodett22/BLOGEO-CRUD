using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.Mvc;


namespace BLOG_DESARROLLO3
{
    public class ComentarioController : Controller
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        [HttpPost]
        public ActionResult Crear(Comentarios comentario)
        {
            if (ModelState.IsValid)
            {
                _context.Comentarios.Add(comentario);
                _context.SaveChanges();
                return RedirectToAction("Detalles", "Publicacion", new { id = comentario.PublicacionId });
            }
            return View(comentario);
        }

        // Implementación de métodos para mostrar comentarios utilizando _context
    }

}