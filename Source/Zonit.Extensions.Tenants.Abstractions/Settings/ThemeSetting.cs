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
    [Display(Name = "Primary Color", Description = "Main brand color used throughout the site")]
    [ColorPicker]
    public string PrimaryColor { get; set; } = "#3B82F6";

    [Required]
    [Display(Name = "Secondary Color", Description = "Supporting brand color for accents")]
    [ColorPicker]
    public string SecondaryColor { get; set; } = "#8B5CF6";

    [Required]
    [Display(Name = "Accent Color", Description = "Highlight color for special elements")]
    [ColorPicker]
    public string AccentColor { get; set; } = "#F59E0B";

    // === NEUTRAL COLORS ===
    [Required]
    [Display(Name = "Background", Description = "Main page background")]
    [ColorPicker]
    public string BackgroundColor { get; set; } = "#FFFFFF";

    [Required]
    [Display(Name = "Surface", Description = "Background for cards and elevated content")]
    [ColorPicker]
    public string SurfaceColor { get; set; } = "#F9FAFB";

    [Required]
    [Display(Name = "Text", Description = "Main text color")]
    [ColorPicker]
    public string TextColor { get; set; } = "#111827";

    [Required]
    [Display(Name = "Text Muted", Description = "Secondary text color")]
    [ColorPicker]
    public string TextMutedColor { get; set; } = "#6B7280";

    [Required]
    [Display(Name = "Border", Description = "Color for borders and dividers")]
    [ColorPicker]
    public string BorderColor { get; set; } = "#E5E7EB";

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