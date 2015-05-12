using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Optimization;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System.Configuration;
using System.ComponentModel;
using ElysiumMagtheridon.Models;
using ElysiumMagtheridon.Controllers;

namespace ElysiumMagtheridon
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            BundleTable.EnableOptimizations = false;
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var section = (UnityConfigurationSection)ConfigurationManager.GetSection("unity");

            IUnityContainer container = new UnityContainer().LoadConfiguration(section, "Unity");

            var that = this;
        }
    }
}
