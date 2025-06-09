using System.ComponentModel.DataAnnotations;
using Zonit.Extensions.Tenants.Abstractions.Settings;

namespace Zonit.Extensions.Tenants;

/// <summary>
/// Setting for configuring the website's core identity and metadata.
/// </summary>
public class SiteSetting : Setting<SiteSettingsModel>
{
    public override string Key => "site";
    public override string Name => "Site";
    public override string Description => "Basic website settings.";
}

/// <summary>
/// Represents core configuration settings for a website's identity and metadata.
/// </summary>
public class SiteSettingsModel
{
    /// <summary>
    /// The main title of the website, shown in the browser tab and search engines.
    /// </summary>
    [Display(Name = "Website Title", Description = "The main title of the website, displayed in the browser tab and search results.")]
    [Required(ErrorMessage = "Website title is required.")]
    [MinLength(3, ErrorMessage = "Website title must be at least 3 characters.")]
    [StringLength(30, ErrorMessage = "Website title cannot exceed 30 characters.")]
    public string Title { get; set; } = "New website";

    /// <summary>
    /// A short description of the website used in SEO and social sharing previews.
    /// </summary>
    [Display(Name = "Meta Description", Description = "A short description of the website content used in SEO and social media previews.")]
    [Required(ErrorMessage = "Meta description is required.")]
    [MinLength(10, ErrorMessage = "Meta description must be at least 10 characters.")]
    [StringLength(160, ErrorMessage = "Meta description cannot exceed 160 characters.")]
    public string MetaDescription { get; set; } = "This is a new website created";

    /// <summary>
    /// The default language of the website in ISO 639-1 format (e.g., en, pl).
    /// </summary>
    [Display(Name = "Default Language", Description = "The default language of the website (ISO 639-1 code, e.g., 'en', 'pl').")]
    [Required(ErrorMessage = "Default language is required.")]
    [MinLength(5, ErrorMessage = "Default language code must be at least 5 characters.")]
    [StringLength(10, ErrorMessage = "Default language code cannot exceed 10 characters.")]
    public string Language { get; set; } = "pl-pl";

    /// <summary>
    /// URL or path to the logo image used on the website.
    /// </summary>
    [Display(Name = "Logo URL", Description = "URL to the main logo displayed on the website.")]
    [StringLength(200, ErrorMessage = "Logo URL cannot exceed 200 characters.")]
    public string? LogoUrl { get; set; }

    /// <summary>
    /// URL or path to the favicon of the website.
    /// </summary>
    [Display(Name = "Favicon URL", Description = "URL to the favicon icon displayed in the browser tab.")]
    [StringLength(200, ErrorMessage = "Favicon URL cannot exceed 200 characters.")]
    public string? FaviconUrl { get; set; }
}