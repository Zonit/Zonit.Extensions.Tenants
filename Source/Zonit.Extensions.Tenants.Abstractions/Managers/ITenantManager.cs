namespace Zonit.Extensions.Tenants;

public interface ITenantManager
{
    Task<Tenant?> GetTenantAsync(string domain);
}