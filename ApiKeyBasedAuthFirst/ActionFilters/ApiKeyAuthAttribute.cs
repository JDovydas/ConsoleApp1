using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ApiKeyBasedAuthFirst.ActionFilter
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class ApiKeyAuthAttribute : Attribute, IAsyncActionFilter // /// Difference between the first and this one - IAsyncActionFilter - executed afterwards
    {
        private const string ApiKeyHeaderName = "ApiKey";
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (!context.HttpContext.Request.Headers.TryGetValue(ApiKeyHeaderName, out var potentialApiKey))
            {
                context.Result = new UnauthorizedResult();
                return;
            }

            var configuration = context.HttpContext.RequestServices.GetService<IConfiguration>();
            var apiKey = configuration.GetValue<string>("ApiKey");

            if (!apiKey.Equals(potentialApiKey))
            {
                context.Result = new UnauthorizedResult();
                return;
            }

            await next();
        }



        [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)] /// Difference between the first and this one - IAsyncAuthorizationFilter - always first
        public class ApiKeyAuthAuthorizationAttribute : Attribute, IAsyncAuthorizationFilter
        {
            private const string ApiKeyHeaderName = "ApiKey";

            public async Task OnAuthorizationAsync(AuthorizationFilterContext context)
            {
                if (!context.HttpContext.Request.Headers.TryGetValue(ApiKeyHeaderName, out var potentialApiKey))
                {
                    context.Result = new UnauthorizedResult();
                    return;
                }

                var configuration = context.HttpContext.RequestServices.GetService<IConfiguration>();
                var apiKey = configuration.GetValue<string>("ApiKey");

                if (!apiKey.Equals(potentialApiKey))
                {
                    context.Result = new UnauthorizedResult();
                    return;
                }

            }

        }
    }
}
