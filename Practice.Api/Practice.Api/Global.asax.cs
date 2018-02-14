using System.Linq;
using System.Web;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;

namespace Practice.Api
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RemoveXml(GlobalConfiguration.Configuration);

            var builder = new ContainerBuilder();
            builder.RegisterModule<ApiModule>();
            var container = builder.Build();

            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

        private static void RemoveXml(HttpConfiguration config)
        {
            var matches = config.Formatters
                .Where(f => f.SupportedMediaTypes.Any(m => m.MediaType.ToString() == "application/xml" ||
                                                           m.MediaType.ToString() == "text/xml"))
                .ToList();
            foreach (var match in matches)
                config.Formatters.Remove(match);
        }
    }
}