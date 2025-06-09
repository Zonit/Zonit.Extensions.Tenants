using Microsoft.AspNetCore.Components;
using Zonit.Extensions.Tenants;

namespace Zonit.Extensions;

public static class MiddlewareExtensions
{
    public static IApplicationBuilder UseTenants(this IApplicationBuilder builder)
        => builder.UseMiddleware<TenantMiddleware>();
}

public class TenantMiddleware(RequestDelegate _next, ITenantManager _tenantManager)
{
    public async Task Invoke(HttpContext context)
    {
        var endpoint = context.GetEndpoint();

        // Zmodyfikowane sprawdzenie - akceptujemy wszystkie endpointy
        // lub sprawdzamy różne typy metadanych routingu
        if (endpoint is not null)
        {
            // Sprawdzanie różnych typów metadanych związanych z routingiem
            var hasRouting = endpoint.Metadata.GetMetadata<RouteAttribute>() != null ||
                             endpoint.Metadata.GetMetadata<RouteEndpointBuilder>() != null ||
                             !string.IsNullOrEmpty(endpoint.DisplayName);

            // Dla Blazora i minimalnych API zawsze przechodzimy dalej
            var domain = context.Request.Host.Host;

            if (!string.IsNullOrEmpty(domain))
            {
                var tenant = await _tenantManager.GetTenantAsync(domain);
                context.Items["tenant"] = tenant;
            }
        }

        await _next(context);
    }
}