using System.ComponentModel.DataAnnotations;
using Zonit.Extensions.Tenants.Abstractions.Settings;

namespace Zonit.Extensions.Tenants;

public class ThemeSetting : Setting<ThemeSettingsModel>
{
    public override string Key => "theme";
    public override string Name => "Theme";
    public override string Description => "Visual theme and styling settings for the website.";
    public override IReadOnlyCollection<ThemeSettingsModel>? Templates { get; } = [];
}

public class ThemeSettingsModel
{
    // === BRAND COLORS ===
    [Required]
    [Display(Name = "Primary Color", Description = "Main brand color used throughout the site for buttons and key elements")]
    [ColorPicker]
    public string PrimaryColor { get; set; } = "#2563EB"; // Professional Blue

    [Required]
    [Display(Name = "Secondary Color", Description = "Supporting brand color for accents and secondary elements")]
    [ColorPicker]
    public string SecondaryColor { get; set; } = "#7C3AED"; // Deep Purple

    [Required]
    [Display(Name = "Accent Color", Description = "Highlight color for special elements and call-to-action buttons")]
    [ColorPicker]
    public string AccentColor { get; set; } = "#DC2626"; // Business Red

    // === SURFACE COLORS ===
    [Required]
    [Display(Name = "Background Color", Description = "Main page background color and sections")]
    [ColorPicker]
    public string NeutralColor { get; set; } = "#F1F5F9"; // Darker neutral background

    [Required]
    [Display(Name = "Surface Color", Description = "Background color for cards, panels and elevated elements")]
    [ColorPicker]
    public string SurfaceColor { get; set; } = "#FFFFFF"; // White surface

    [Required]
    [Display(Name = "Text Color", Description = "Primary text color for content and headings")]
    [ColorPicker]
    public string ContentColor { get; set; } = "#0F172A"; // Dark text

    // === TYPOGRAPHY ===
    [Required]
    [Display(Name = "Font Family", Description = "Main font for all text")]
    public FontFamily FontFamily { get; set; } = FontFamily.Inter;

    [Required]
    [Display(Name = "Font Scale", Description = "Overall text size scale")]
    public FontScale FontScale { get; set; } = FontScale.Normal;

    // === STYLE ===
    [Required]
    [Display(Name = "Roundness", Description = "Corner rounding intensity")]
    public Roundness Roundness { get; set; } = Roundness.Medium;

    [Required]
    [Display(Name = "Shadow", Description = "Shadow intensity for elevated elements")]
    public Shadow Shadow { get; set; } = Shadow.Small;
}

// === ENUMS ===

public enum FontFamily
{
    [Display(Name = "Inter")]
    Inter,
    [Display(Name = "Roboto")]
    Roboto,
    [Display(Name = "Open Sans")]
    OpenSans,
    [Display(Name = "Poppins")]
    Poppins,
    [Display(Name = "Montserrat")]
    Montserrat,
    [Display(Name = "Nunito")]
    Nunito,
    [Display(Name = "Plus Jakarta Sans")]
    PlusJakartaSans
}

public enum FontScale
{
    [Display(Name = "Small")]
    Small,      // base: 14px, h1: 2rem, h2: 1.75rem, etc.
    [Display(Name = "Normal")]
    Normal,     // base: 16px, h1: 2.5rem, h2: 2rem, etc.
    [Display(Name = "Large")]
    Large       // base: 18px, h1: 3rem, h2: 2.5rem, etc.
}

public enum Roundness
{
    [Display(Name = "None")]
    None,       // rounded-none
    [Display(Name = "Small")]
    Small,      // rounded-sm
    [Display(Name = "Medium")]
    Medium,     // rounded-md
    [Display(Name = "Large")]
    Large       // rounded-lg
}

public enum Shadow
{
    [Display(Name = "None")]
    None,       // shadow-none
    [Display(Name = "Small")]
    Small,      // shadow-sm
    [Display(Name = "Medium")]
    Medium,     // shadow
    [Display(Name = "Large")]
    Large       // shadow-lg
}