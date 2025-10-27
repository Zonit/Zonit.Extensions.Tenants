namespace Zonit.Extensions.Tenants;

/// <summary>
/// Theme setting accessor.
/// </summary>
public partial class TenantSettings
{
    private ThemeSettingsModel? _theme;

    /// <summary>
    /// Gets the theme settings.
    /// </summary>
    public ThemeSettingsModel Theme => _theme ??= provider.GetSetting<ThemeSetting>().Value;
}
