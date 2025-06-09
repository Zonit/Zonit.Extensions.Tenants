using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Zonit.Extensions.Tenants;

/// <summary>
/// Attribute to mark a property as a color and validate HEX color format and length.
/// Can be used for UI rendering (e.g., color picker) and ensures the value is a valid HEX color.
/// </summary>
[AttributeUsage(AttributeTargets.Property)]
public partial class ColorPickerAttribute : ValidationAttribute
{
    /// <summary>
    /// Default error message for invalid HEX color.
    /// </summary>
    public ColorPickerAttribute()
        : base("Please provide a valid HEX color (e.g., #123ABC).")
    {
    }

    /// <summary>
    /// Validates whether the value is a valid HEX color string and checks its length.
    /// </summary>
    /// <param name="value">The value to validate.</param>
    /// <param name="validationContext">The context information.</param>
    /// <returns>ValidationResult.Success if valid; otherwise, a ValidationResult with an error message.</returns>
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value is null)
            return ValidationResult.Success;

        if (value is string str)
        {
            // Accept only #RGB (4 chars) or #RRGGBB (7 chars)
            if (str.Length != 4 && str.Length != 7)
                return new ValidationResult("Color must be in #RGB or #RRGGBB format.");

            if (HexColorRegex().IsMatch(str))
                return ValidationResult.Success;
        }

        return new ValidationResult(ErrorMessage);
    }

    /// <summary>
    /// Regex for validating HEX color strings (#RGB or #RRGGBB).
    /// </summary>
    [GeneratedRegex("^#([A-Fa-f0-9]{6}|[A-Fa-f0-9]{3})$")]
    private static partial Regex HexColorRegex();
}