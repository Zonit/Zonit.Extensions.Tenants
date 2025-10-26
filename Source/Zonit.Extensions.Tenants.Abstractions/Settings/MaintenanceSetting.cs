using System.ComponentModel.DataAnnotations;
using Zonit.Extensions.Tenants.Abstractions.Settings;

namespace Zonit.Extensions.Tenants;

/// <summary>
/// Setting for controlling website availability and maintenance mode.
/// </summary>
public class MaintenanceSetting : Setting<MaintenanceSettingsModel>
{
    public override string Key => "maintenance";
    public override string Name => "Maintenance";
    public override string Description => "Controls website availability and displays maintenance messages when the site is offline.";
}

/// <summary>
/// Represents configuration settings for website maintenance mode and availability.
/// </summary>
public class MaintenanceSettingsModel
{
    /// <summary>
    /// Indicates whether the website is active and accessible to users.
  /// When set to false, the maintenance message will be displayed instead.
 /// </summary>
    [Display(Name = "Site Active", Description = "Controls whether the website is accessible to users. When disabled, visitors will see the maintenance message.")]
    [Required]
    public bool IsActive { get; set; } = true;

    /// <summary>
    /// The message displayed to visitors when the site is in maintenance mode.
    /// </summary>
    [Display(Name = "Maintenance Message", Description = "The message shown to visitors when the website is temporarily unavailable.")]
    [MinLength(10, ErrorMessage = "Maintenance message must be at least 10 characters.")]
    [StringLength(2000, ErrorMessage = "Maintenance message cannot exceed 2000 characters.")]
    public string? MaintenanceMessage { get; set; }
}
