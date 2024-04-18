using System.Collections.Generic;
using System.Data.Entity;


namespace BLOG_DESARROLLO3
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("DefaultConnection")
        {
        }

        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Publicaciones> Publicaciones { get; set; }
        public DbSet<Comentarios> Comentarios { get; set; }
    }
}
