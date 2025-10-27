namespace Zonit.Extensions.Tenants;

/// <summary>
/// Site setting accessor.
/// </summary>
public partial class TenantSettings
{
    private SiteSettingsModel? _site;

    /// <summary>
    /// Gets the site settings.
    /// </summary>
    public SiteSettingsModel Site => _site ??= provider.GetSetting<SiteSetting>().Value;
}
