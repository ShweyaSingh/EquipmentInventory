using AutoMapper;
using EquipmentInventory.Data;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Unity;

namespace EquipmentInventory.Presentation
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            UnityConfig.RegisterComponents();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            IUnityContainer container = IoCDependencyProvider.InitializeContainer("unityContainer");
            DependencyResolver.SetResolver(new Unity.Mvc5.UnityDependencyResolver(container));

            new InitializeAutoMapper().InitializeMappings();
        }
    }
}
