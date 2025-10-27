namespace Zonit.Extensions.Tenants;

/// <summary>
/// Provides strongly-typed access to all tenant settings.
/// This is a partial class - add new setting accessors in separate files.
/// </summary>
/// <remarks>
/// Initializes a new instance of the <see cref="TenantSettings"/> class.
/// </remarks>
/// <param name="provider">The tenant provider.</param>
public partial class TenantSettings(ITenantProvider provider)
{
    // Setting properties will be added in partial files
}
