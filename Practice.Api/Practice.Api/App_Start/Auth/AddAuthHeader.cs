using System.Collections.Generic;
using System.Web.Http.Description;
using Swashbuckle.Swagger;

namespace Practice.Api.Auth
{
    public class AddAuthHeader : IOperationFilter
    {
        public void Apply(Operation operation, SchemaRegistry schemaRegistry, ApiDescription apiDescription)
        {
            if (operation.parameters == null)
                operation.parameters = new List<Parameter>();

            operation.parameters.Add(new Parameter
            {
                name = Constants.ApiKey,
                @in = "header",
                type = "string",
                required = false,
                @default = new AuthConfig().ApiKey
            });
        }
    }
}