using System.ComponentModel.DataAnnotations;
using Zonit.Extensions.Tenants.Abstractions.Models;

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
    /// Indicates whether maintenance mode is active. When set to true, the maintenance message will be displayed to visitors.
    /// </summary>
    [Display(Name = "Maintenance Active", Description = "Controls whether maintenance mode is active. When enabled, visitors will see the maintenance message.")]
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
