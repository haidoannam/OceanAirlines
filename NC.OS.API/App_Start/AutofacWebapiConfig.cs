using Autofac;
using Autofac.Core;
using Autofac.Integration.WebApi;
using NC.OS.Data.Context;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Data.Entity;
using NC.OS.Data.Infrastructure;
using NC.OS.Data.Repositories;
using NC.OS.Services.Services;
using System.Reflection;
using NC.OS.Services.Interface;

namespace NC.OS.API.App_Start
{
    public class AutofacWebapiConfig
    {
        public static IContainer Container;
        public static void Initialize(HttpConfiguration config)
        {
            Initialize(config, RegisterServices(new ContainerBuilder()));
        }

        public static void Initialize(HttpConfiguration config, IContainer container)
        {
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

        private static IContainer RegisterServices(ContainerBuilder builder)
        {
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            // EF HomeCinemaContext
            builder.RegisterType<OceanAirlinesContext>()
                   .As<DbContext>()
                   .InstancePerRequest();

            builder.RegisterType<DbFactory>()
                .As<IDbFactory>()
                .InstancePerRequest();

            builder.RegisterType<UnitOfWork>()
                .As<IUnitOfWork>()
                .InstancePerRequest();

            builder.RegisterGeneric(typeof(EntityBaseRepository<>))
                   .As(typeof(IEntityBaseRepository<>))
                   .InstancePerRequest();

            // Services
            builder.RegisterType<UserService>()
                .As<IUserService>()
                .InstancePerRequest();

            builder.RegisterType<OrderService>()
               .As<IOrderService>()
               .InstancePerRequest();

            builder.RegisterType<PlacesService>()
               .As<IPlacesService>()
               .InstancePerRequest();


            Container = builder.Build();

            return Container;
        }
    }
}