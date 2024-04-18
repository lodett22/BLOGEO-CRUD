using System;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;

namespace BLOG_DESARROLLO3
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Inicialización de la base de datos
            System.Data.Entity.Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseIfModelChanges<ApplicationDbContext>());

            // Configuración de rutas y bundles
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
