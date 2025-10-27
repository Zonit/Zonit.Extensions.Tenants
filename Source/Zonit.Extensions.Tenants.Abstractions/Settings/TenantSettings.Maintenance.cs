namespace Zonit.Extensions.Tenants;

/// <summary>
/// Maintenance setting accessor.
/// </summary>
public partial class TenantSettings
{
    private MaintenanceSettingsModel? _maintenance;

    /// <summary>
    /// Gets the maintenance settings.
    /// </summary>
    public MaintenanceSettingsModel Maintenance => _maintenance ??= provider.GetSetting<MaintenanceSetting>().Value;
}
