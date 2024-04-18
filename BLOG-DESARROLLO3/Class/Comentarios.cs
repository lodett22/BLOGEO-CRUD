using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BLOG_DESARROLLO3
{
    public class Comentarios
    {
        public int Id { get; set; }
        public int PublicacionId { get; set; }
        public int UsuarioId { get; set; }
        public string Contenido { get; set; }
        public DateTime FechaComentario { get; set; }
        public virtual Publicaciones Publicacion { get; set; }
        public virtual Usuarios Usuario { get; set; }
    }
}