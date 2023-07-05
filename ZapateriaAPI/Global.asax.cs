using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Zapateria_Models;
using ZapateriaAPI.BussinessLayer.Services.Implementations;
using ZapateriaAPI.BussinessLayer.Services.Interfaces;
using ZapateriaAPI.DataAccessLayer.Repository.Implementations;
using ZapateriaAPI.DataAccessLayer.Repository.Interfaces;

namespace ZapateriaAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            var services = new ServiceCollection();

            // Register all your controllers and other services here:
            services.AddTransient<Controllers.StoresController>();
            services.AddTransient<Controllers.ArticlesController>();
            services.AddTransient<ShopContext>();
            services.AddScoped<IStoreService, StoreService>();
            services.AddScoped<IStoreRepository, StoreRepository>();
            services.AddScoped<IArticlesService, ArticlesService>();
            services.AddScoped<IArticlesRepository, ArticlesRepository>();

            var provider = services.BuildServiceProvider(new ServiceProviderOptions
            {
                // Prefer to keep validation on at all times
                ValidateOnBuild = true,
                ValidateScopes = true
            });

            GlobalConfiguration.Configuration.Services.Replace(
                typeof(IHttpControllerActivator),
                new MsDiHttpControllerActivator(provider));
        }
    }
}
