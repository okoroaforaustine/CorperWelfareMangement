using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using Microsoft.AspNet.Identity;


using System.Web.Http;

using Microsoft.AspNet.Identity.EntityFramework;
using CorpersWelfareManager.Models.Repository;
using System.Reflection;
using Autofac.Integration.WebApi;

namespace CorpersWelfareManager.App_Start
{
    public class Bootstrapper
    {
 public static void Configure()
        {
            ConfigureAutofacContainer();
            
        }

        public static void ConfigureAutofacContainer()
        {

            var webApiContainerBuilder = new ContainerBuilder();
            ConfigureWebApiContainer(webApiContainerBuilder);
        }

        public static void ConfigureWebApiContainer(ContainerBuilder containerBuilder)
        {

            var builder = new ContainerBuilder();
            var config = GlobalConfiguration.Configuration;
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
           
            builder.RegisterType<CorperRepository>().As<IcorperInterface>();
            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
          
        }

    }
}


