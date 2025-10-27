namespace Zonit.Extensions.Tenants;

/// <summary>
/// Social media setting accessor.
/// </summary>
public partial class TenantSettings
{
    private SocialMediaModel? _socialMedia;

    /// <summary>
    /// Gets the social media settings.
    /// </summary>
    public SocialMediaModel SocialMedia => _socialMedia ??= provider.GetSetting<SocialMediaSetting>().Value;
}
