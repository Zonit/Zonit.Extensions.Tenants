using System.ComponentModel.DataAnnotations;
using Zonit.Extensions.Tenants.Abstractions.Settings;

namespace Zonit.Extensions.Tenants;

public class ThemeSetting : Setting<ThemeSettingsModel>
{
    public override string Key => "theme";
    public override string Name => "Theme";
    public override string Description => "Visual theme and styling settings for the website.";
    public override IReadOnlyCollection<ThemeSettingsModel>? Templates { get; } =
    [
        // 1. Modern Blue (domyślny)
        new ThemeSettingsModel
        {
            PrimaryColor = "#3B82F6",
            SecondaryColor = "#10B981",
            SuccessColor = "#22C55E",
            WarningColor = "#F59E0B",
            ErrorColor = "#EF4444",
            BackgroundColor = "#FFFFFF",
            SurfaceColor = "#F9FAFB",
            TextColor = "#111827",
            MutedTextColor = "#6B7280",
            FontFamily = FontFamily.Inter,
            BaseFontSize = 16,
            LineHeight = 1.6,
            BorderRadius = BorderRadius.Medium,
            ShadowSize = ShadowSize.Small,
            AnimationSpeed = AnimationSpeed.Normal
        },

        // 2. Dark Corporate
        new ThemeSettingsModel
        {
            PrimaryColor = "#8B5CF6",
            SecondaryColor = "#06B6D4",
            SuccessColor = "#10B981",
            WarningColor = "#F59E0B",
            ErrorColor = "#F87171",
            BackgroundColor = "#0F172A",
            SurfaceColor = "#1E293B",
            TextColor = "#F8FAFC",
            MutedTextColor = "#94A3B8",
            FontFamily = FontFamily.Manrope,
            BaseFontSize = 15,
            LineHeight = 1.5,
            BorderRadius = BorderRadius.Large,
            ShadowSize = ShadowSize.Medium,
            AnimationSpeed = AnimationSpeed.Fast
        },

        // 3. Warm Orange
        new ThemeSettingsModel
        {
            PrimaryColor = "#EA580C",
            SecondaryColor = "#DC2626",
            SuccessColor = "#16A34A",
            WarningColor = "#D97706",
            ErrorColor = "#DC2626",
            BackgroundColor = "#FFFBEB",
            SurfaceColor = "#FFFFFF",
            TextColor = "#1C1917",
            MutedTextColor = "#78716C",
            FontFamily = FontFamily.Poppins,
            BaseFontSize = 16,
            LineHeight = 1.7,
            BorderRadius = BorderRadius.Small,
            ShadowSize = ShadowSize.Small,
            AnimationSpeed = AnimationSpeed.Normal
        },

        // 4. Fresh Green
        new ThemeSettingsModel
        {
            PrimaryColor = "#059669",
            SecondaryColor = "#0D9488",
            SuccessColor = "#10B981",
            WarningColor = "#F59E0B",
            ErrorColor = "#EF4444",
            BackgroundColor = "#F0FDF4",
            SurfaceColor = "#FFFFFF",
            TextColor = "#14532D",
            MutedTextColor = "#4B5563",
            FontFamily = FontFamily.DMSans,
            BaseFontSize = 16,
            LineHeight = 1.6,
            BorderRadius = BorderRadius.Medium,
            ShadowSize = ShadowSize.Large,
            AnimationSpeed = AnimationSpeed.Slow
        },

        // 5. Elegant Purple
        new ThemeSettingsModel
        {
            PrimaryColor = "#7C3AED",
            SecondaryColor = "#EC4899",
            SuccessColor = "#10B981",
            WarningColor = "#F59E0B",
            ErrorColor = "#EF4444",
            BackgroundColor = "#FEFCFF",
            SurfaceColor = "#F8FAFC",
            TextColor = "#1E1B4B",
            MutedTextColor = "#64748B",
            FontFamily = FontFamily.SpaceGrotesk,
            BaseFontSize = 17,
            LineHeight = 1.8,
            BorderRadius = BorderRadius.ExtraLarge,
            ShadowSize = ShadowSize.Medium,
            AnimationSpeed = AnimationSpeed.Fast
        },

        // 6. Ocean Blue
        new ThemeSettingsModel
        {
            PrimaryColor = "#0EA5E9",
            SecondaryColor = "#06B6D4",
            SuccessColor = "#22C55E",
            WarningColor = "#F59E0B",
            ErrorColor = "#EF4444",
            BackgroundColor = "#F0F9FF",
            SurfaceColor = "#FFFFFF",
            TextColor = "#0C4A6E",
            MutedTextColor = "#475569",
            FontFamily = FontFamily.Urbanist,
            BaseFontSize = 15,
            LineHeight = 1.5,
            BorderRadius = BorderRadius.Full,
            ShadowSize = ShadowSize.ExtraLarge,
            AnimationSpeed = AnimationSpeed.Normal
        },

        // 7. Minimalist Gray
        new ThemeSettingsModel
        {
            PrimaryColor = "#374151",
            SecondaryColor = "#6B7280",
            SuccessColor = "#10B981",
            WarningColor = "#F59E0B",
            ErrorColor = "#EF4444",
            BackgroundColor = "#FFFFFF",
            SurfaceColor = "#F9FAFB",
            TextColor = "#111827",
            MutedTextColor = "#9CA3AF",
            FontFamily = FontFamily.Sora,
            BaseFontSize = 14,
            LineHeight = 1.4,
            BorderRadius = BorderRadius.None,
            ShadowSize = ShadowSize.None,
            AnimationSpeed = AnimationSpeed.None
        },

        // 8. Vibrant Pink
        new ThemeSettingsModel
        {
            PrimaryColor = "#EC4899",
            SecondaryColor = "#8B5CF6",
            SuccessColor = "#10B981",
            WarningColor = "#F59E0B",
            ErrorColor = "#EF4444",
            BackgroundColor = "#FDF2F8",
            SurfaceColor = "#FFFFFF",
            TextColor = "#831843",
            MutedTextColor = "#9F1239",
            FontFamily = FontFamily.Mulish,
            BaseFontSize = 16,
            LineHeight = 1.6,
            BorderRadius = BorderRadius.Large,
            ShadowSize = ShadowSize.Small,
            AnimationSpeed = AnimationSpeed.Fast
        },

        // 9. Professional Navy
        new ThemeSettingsModel
        {
            PrimaryColor = "#1E40AF",
            SecondaryColor = "#3730A3",
            SuccessColor = "#059669",
            WarningColor = "#D97706",
            ErrorColor = "#DC2626",
            BackgroundColor = "#F8FAFC",
            SurfaceColor = "#FFFFFF",
            TextColor = "#1E293B",
            MutedTextColor = "#64748B",
            FontFamily = FontFamily.WorkSans,
            BaseFontSize = 15,
            LineHeight = 1.5,
            BorderRadius = BorderRadius.Small,
            ShadowSize = ShadowSize.Medium,
            AnimationSpeed = AnimationSpeed.Slow
        },

        // 10. Sunset Gradient
        new ThemeSettingsModel
        {
            PrimaryColor = "#F97316",
            SecondaryColor = "#EAB308",
            SuccessColor = "#84CC16",
            WarningColor = "#F59E0B",
            ErrorColor = "#EF4444",
            BackgroundColor = "#FFFBEB",
            SurfaceColor = "#FEF3C7",
            TextColor = "#92400E",
            MutedTextColor = "#A16207",
            FontFamily = FontFamily.PlusJakartaSans,
            BaseFontSize = 16,
            LineHeight = 1.7,
            BorderRadius = BorderRadius.Medium,
            ShadowSize = ShadowSize.Large,
            AnimationSpeed = AnimationSpeed.Normal
        }
    ];
}

/// <summary>
/// Available font families for the website theme
/// </summary>
public enum FontFamily
{
    [Display(Name = "Inter")]
    Inter,
    [Display(Name = "Roboto")]
    Roboto,
    [Display(Name = "Open Sans")]
    OpenSans,
    [Display(Name = "Lato")]
    Lato,
    [Display(Name = "Poppins")]
    Poppins,
    [Display(Name = "Montserrat")]
    Montserrat,
    [Display(Name = "Source Sans Pro")]
    SourceSansPro,
    [Display(Name = "Nunito")]
    Nunito,
    [Display(Name = "PT Sans")]
    PTSans,
    [Display(Name = "Ubuntu")]
    Ubuntu,
    [Display(Name = "Manrope")]
    Manrope,
    [Display(Name = "Space Grotesk")]
    SpaceGrotesk,
    [Display(Name = "DM Sans")]
    DMSans,
    [Display(Name = "Work Sans")]
    WorkSans,
    [Display(Name = "Urbanist")]
    Urbanist,
    [Display(Name = "Sora")]
    Sora,
    [Display(Name = "Mulish")]
    Mulish,
    [Display(Name = "Public Sans")]
    PublicSans,
    [Display(Name = "Be Vietnam Pro")]
    BeVietnamPro,
    [Display(Name = "Plus Jakarta Sans")]
    PlusJakartaSans
}

/// <summary>
/// Available border radius presets
/// </summary>
public enum BorderRadius
{
    [Display(Name = "None")]
    None,
    [Display(Name = "Small")]
    Small,
    [Display(Name = "Medium")]
    Medium,
    [Display(Name = "Large")]
    Large,
    [Display(Name = "Extra Large")]
    ExtraLarge,
    [Display(Name = "Full")]
    Full
}

/// <summary>
/// Available shadow presets
/// </summary>
public enum ShadowSize
{
    [Display(Name = "None")]
    None,
    [Display(Name = "Small")]
    Small,
    [Display(Name = "Medium")]
    Medium,
    [Display(Name = "Large")]
    Large,
    [Display(Name = "Extra Large")]
    ExtraLarge
}

/// <summary>
/// Available animation speeds
/// </summary>
public enum AnimationSpeed
{
    [Display(Name = "Slow")]
    Slow,
    [Display(Name = "Normal")]
    Normal,
    [Display(Name = "Fast")]
    Fast,
    [Display(Name = "None")]
    None
}

/// <summary>
/// Reprezentuje uniwersalne ustawienia motywu dla stylowania strony.
/// </summary>
public class ThemeSettingsModel
{
    // Kolory
    /// <summary>
    /// Główny kolor marki.
    /// </summary>
    [Required]
    [Display(Name = "Primary Color", Description = "Main brand color used for buttons, links, and primary elements")]
    [ColorPicker]
    public string PrimaryColor { get; set; } = "#3B82F6";

    /// <summary>
    /// Kolor akcentowy.
    /// </summary>
    [Required]
    [Display(Name = "Secondary Color", Description = "Secondary color used for accents and complementary design elements")]
    [ColorPicker]
    public string SecondaryColor { get; set; } = "#10B981";

    /// <summary>
    /// Kolor sukcesu.
    /// </summary>
    [Required]
    [Display(Name = "Success Color", Description = "Color used to indicate success states and positive feedback")]
    [ColorPicker]
    public string SuccessColor { get; set; } = "#22C55E";

    /// <summary>
    /// Kolor ostrzeżenia.
    /// </summary>
    [Required]
    [StringLength(7, MinimumLength = 4)]
    [Display(Name = "Warning Color", Description = "Color used to indicate warning states and caution")]
    [ColorPicker]
    public string WarningColor { get; set; } = "#F59E0B";

    /// <summary>
    /// Kolor błędu.
    /// </summary>
    [Required]
    [Display(Name = "Error Color", Description = "Color used to indicate error states and destructive actions")]
    [ColorPicker]
    public string ErrorColor { get; set; } = "#EF4444";

    /// <summary>
    /// Kolor tła.
    /// </summary>
    [Required]
    [StringLength(7, MinimumLength = 4)]
    [Display(Name = "Background Color", Description = "Main background color of the website")]
    [ColorPicker]
    public string BackgroundColor { get; set; } = "#FFFFFF";

    /// <summary>
    /// Kolor powierzchni (np. kart).
    /// </summary>
    [Required]
    [Display(Name = "Surface Color", Description = "Background color for cards, panels, and elevated surfaces")]
    [ColorPicker]
    public string SurfaceColor { get; set; } = "#F9FAFB";

    /// <summary>
    /// Kolor tekstu głównego.
    /// </summary>
    [Required]
    [Display(Name = "Text Color", Description = "Primary color for body text and main content")]
    [ColorPicker]
    public string TextColor { get; set; } = "#111827";

    /// <summary>
    /// Kolor tekstu pomocniczego.
    /// </summary>
    [Required]
    [Display(Name = "Muted Text Color", Description = "Color for secondary text, descriptions, and less important content")]
    [ColorPicker]
    public string MutedTextColor { get; set; } = "#6B7280";

    // Typografia
    /// <summary>
    /// Główna rodzina fontów.
    /// </summary>
    [Required]
    [Display(Name = "Font Family", Description = "Primary font family used for all text content")]
    public FontFamily FontFamily { get; set; } = FontFamily.Inter;

    /// <summary>
    /// Bazowy rozmiar fontu.
    /// </summary>
    [Range(12, 24)]
    [Display(Name = "Base Font Size", Description = "Base font size in pixels for body text (typically 14-18px)")]
    public int BaseFontSize { get; set; } = 16;

    /// <summary>
    /// Wysokość linii.
    /// </summary>
    [Range(1.2, 2.0)]
    [Display(Name = "Line Height", Description = "Line height multiplier for better text readability (1.4-1.8)")]
    public double LineHeight { get; set; } = 1.6;

    // Efekty wizualne
    /// <summary>
    /// Promień zaokrąglenia.
    /// </summary>
    [Required]
    [Display(Name = "Border Radius", Description = "Default border radius for buttons, cards, and other UI elements")]
    public BorderRadius BorderRadius { get; set; } = BorderRadius.Medium;

    /// <summary>
    /// Rozmiar cienia.
    /// </summary>
    [Required]
    [Display(Name = "Shadow Size", Description = "Default shadow size for cards, modals, and elevated surfaces")]
    public ShadowSize ShadowSize { get; set; } = ShadowSize.Small;

    /// <summary>
    /// Szybkość animacji.
    /// </summary>
    [Required]
    [Display(Name = "Animation Speed", Description = "Speed of animations and transitions throughout the interface")]
    public AnimationSpeed AnimationSpeed { get; set; } = AnimationSpeed.Normal;

    //// Zaawansowane
    ///// <summary>
    ///// Czy włączyć tryb ciemny.
    ///// </summary>
    //[Display(Name = "Enable Dark Mode", Description = "Enable automatic dark mode support based on user preference")]
    //public bool EnableDarkMode { get; set; } = true;

    ///// <summary>
    ///// Kolor tła w trybie ciemnym.
    ///// </summary>
    //[Required]
    //[Display(Name = "Dark Background Color", Description = "Background color when dark mode is active")]
    //[ColorPicker]
    //public string DarkBackgroundColor { get; set; } = "#111827";

    ///// <summary>
    ///// Kolor powierzchni w trybie ciemnym.
    ///// </summary>
    //[Required]
    //[Display(Name = "Dark Surface Color", Description = "Surface color for cards and panels in dark mode")]
    //[ColorPicker]
    //public string DarkSurfaceColor { get; set; } = "#1F2937";

    ///// <summary>
    ///// Kolor tekstu w trybie ciemnym.
    ///// </summary>
    //[Required]
    //[Display(Name = "Dark Text Color", Description = "Primary text color in dark mode")]
    //[ColorPicker]
    //public string DarkTextColor { get; set; } = "#F9FAFB";
}