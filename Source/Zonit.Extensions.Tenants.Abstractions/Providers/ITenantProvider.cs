using Zonit.Extensions.Tenants.Abstractions.Models;

namespace Zonit.Extensions.Tenants;

public interface ITenantProvider
{
    T GetSetting<T>() where T : class, ISetting, new();
    
    /// <summary>
    /// Gets strongly-typed access to all tenant settings.
    /// Usage: provider.Settings.Site.Title or provider.Settings.Theme.PrimaryColor
    /// </summary>
    TenantSettings Settings { get; }
}
