using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Mvc;    //readme.txt

namespace HailMary1
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Código que se ejecuta al iniciar la aplicación
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            AreaRegistration.RegisterAllAreas();    //readme.txt
            RouteConfig2.RegisterRoutes(RouteTable.Routes);    //readme.txt
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);    //readme.txt
            BundleConfig2.RegisterBundles(BundleTable.Bundles);    //readme.txt
        }
    }
}