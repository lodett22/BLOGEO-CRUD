using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.Mvc;


namespace BLOG_DESARROLLO3
{
    public class UsuarioController : Controller
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        [HttpPost]
        public ActionResult Registro(Usuarios usuario)
        {
            if (ModelState.IsValid)
            {
                _context.Usuarios.Add(usuario);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View(usuario);
        }

        public ActionResult Registro()
        {
            return View();
        }
        // Implementación de métodos para inicio de sesión y logout utilizando _context
    }

}