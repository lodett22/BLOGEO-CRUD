using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BLOG_DESARROLLO3
{
    public class Publicaciones
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public string Contenido { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public virtual Usuarios Usuario { get; set; }
    }
}