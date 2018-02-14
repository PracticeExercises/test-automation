using System.Web.Http;
using WebActivatorEx;
using Practice.Api;
using Swashbuckle.Application;
using Practice.Api.Auth;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]
namespace Practice.Api
{
    public static class SwaggerConfig
    {
        public static void Register()
        {
            const string name = "Practice API";
            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                    {
                        c.SingleApiVersion("v1", name);
                        c.PrettyPrint();
                        c.UseFullTypeNameInSchemaIds();
                        c.ApiKey(Constants.ApiKey)
                            .Description("API Key Authentication")
                            .Name(Constants.ApiKey)
                            .In("header");
                        c.OperationFilter<AddAuthHeader>();
                    })
                .EnableSwaggerUi(c =>
                    {
                        c.DocumentTitle(name);
                        c.EnableApiKeySupport(Constants.ApiKey, "header");
                    });
        }
    }
}
