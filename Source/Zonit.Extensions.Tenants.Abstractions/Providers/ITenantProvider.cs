using Zonit.Extensions.Tenants.Abstractions.Settings;

namespace Zonit.Extensions.Tenants;

public interface ITenantProvider
{
    T GetSetting<T>() where T : class, ISetting, new();
}
