using ServiceCoursework.Services;
using System.Web.Mvc;
using System.Web.Routing;
using System.ServiceModel.Activation;

namespace ServiceCoursework.Site
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
          //  RouteTable.Routes.Add(new ServiceRoute("GuestService", new WebServiceHostFactory(), typeof(GuestService)));
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
