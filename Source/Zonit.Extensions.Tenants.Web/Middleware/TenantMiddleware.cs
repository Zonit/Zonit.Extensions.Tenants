using Microsoft.AspNetCore.Components;
using Zonit.Extensions.Tenants;

namespace Zonit.Extensions;

public static class MiddlewareExtensions
{
    public static IApplicationBuilder UseTenants(this IApplicationBuilder builder)
        => builder.UseMiddleware<TenantMiddleware>();
}

public class TenantMiddleware(RequestDelegate next, ITenantManager tenantManager)
{
    private const string TenantContextKey = "tenant";

    public async Task Invoke(HttpContext context)
    {
        // Fast path - extract domain directly without any checks
        var domain = context.Request.Host.Host;

        // Only proceed if we have a domain
        if (!string.IsNullOrEmpty(domain))
        {
            // GetTenantAsync should be cached in the implementation (e.g., decorator with IMemoryCache)
            // This middleware stays thin and delegates caching responsibility to the business layer
            var tenant = await tenantManager.GetTenantAsync(domain);

            if (tenant is not null)
            {
                context.Items[TenantContextKey] = tenant;
            }
        }

        await next(context);
    }
}