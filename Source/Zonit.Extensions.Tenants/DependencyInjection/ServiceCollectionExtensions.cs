using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Zonit.Extensions.Tenants;
using Zonit.Extensions.Tenants.Services;

namespace Zonit.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddTenantsExtension(this IServiceCollection services)
    {
        services.TryAddScoped<ITenantProvider, TenantService>();

        return services;
    }
}
