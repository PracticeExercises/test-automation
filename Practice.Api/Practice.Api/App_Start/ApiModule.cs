using Autofac;
using Autofac.Integration.WebApi;
using Practice.Api.Auth;

namespace Practice.Api
{
    public class ApiModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var assembly = typeof(WebApiConfig).Assembly;
            builder.RegisterApiControllers(assembly);
            builder.RegisterType<AuthConfig>().AsSelf();
            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces();
            base.Load(builder);
        }
    }
}