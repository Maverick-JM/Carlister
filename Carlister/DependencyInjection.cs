using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Autofac.Integration.Mvc;
using System.Web.Mvc;

namespace Carlister.Web
{
    public static class DependencyInjection
    {
        private static ContainerBuilder _builder { get; set; }
        private static IContainer _container { get; set; }

        public static ILifetimeScope GetDisposableLifetimeInstance()
        {
            return _container.BeginLifetimeScope();
        }

        /// <summary>
        /// This should only be called from the global.asax.cs Application_Start method. 
        /// </summary>
        public static void InitialiseDI()
        {
            _builder = new ContainerBuilder();

            // Any controller, we just want to know where the assembly is
            _builder.RegisterControllers(typeof(Controllers.HomeController).Assembly);

            _builder.RegisterSource(new ViewRegistrationSource());

            _builder.RegisterType<DAL.CarlisterEntities>()
                .As<Common.Data.ICarlisterDataSource>()
                .As<Common.Data.ICarDataSource>()
                .As<Common.Data.IEnquiryDataSource>()
                .AsSelf();

            _container = _builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(_container));
        }
    }
}
