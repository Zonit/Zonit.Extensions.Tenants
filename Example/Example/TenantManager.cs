using System.Text.Json;
using Zonit.Extensions.Tenants;

namespace Example;

public class TenantManager : ITenantManager
{
    public async Task<Tenant?> GetTenantAsync(string domain)
    {
        var site = new SiteSettingsModel { 
            Title = "Zonit"
        };

        var model = new Tenant
        {
            Id = Guid.NewGuid(),
            Domain = domain,
            Variables = [
                new Variable { Key = "site", Value = JsonSerializer.Serialize(site) }
            ]
        };

        return await Task.FromResult(model);
    }
}
