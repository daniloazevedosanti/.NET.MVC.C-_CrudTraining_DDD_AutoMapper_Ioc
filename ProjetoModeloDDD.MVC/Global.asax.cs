using Ninject;
using Ninject.Modules;
using Ninject.Web.Common.WebHost;
using ProjetoModeloDDD.MVC.AutoMapper;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ProjetoModeloDDD.MVC
{
    public class MvcApplication :  NinjectHttpApplication
    {

        /*protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AutoMapperConfig.RegisterMappings();
        }*/


        protected override void OnApplicationStarted()
        {
            base.OnApplicationStarted();

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AutoMapperConfig.RegisterMappings();
        }

        protected override IKernel CreateKernel()
        {
            var modules = new NinjectModule[] { new ModulosNinject() };
            return new StandardKernel(modules);
        }

    }
}
