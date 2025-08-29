using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Zonit.Extensions.Tenants;

/// <summary>
/// Attribute to mark a property as a color and validate HEX color format and length.
/// Can be used for UI rendering (e.g., color picker) and ensures the value is a valid HEX color.
/// Supports both RGB (#RRGGBB) and RGBA (#RRGGBBAA) formats, as well as short forms (#RGB and #RGBA).
/// </summary>
[AttributeUsage(AttributeTargets.Property)]
public partial class ColorPickerAttribute : ValidationAttribute
{
    private readonly StringLengthAttribute _lengthValidator;

    /// <summary>
    /// Default error message for invalid HEX color.
    /// </summary>
    public ColorPickerAttribute()
        : base("Please provide a valid HEX color (e.g., #123ABC or #123ABCFF).")
    {
        // Allow #RGB (4 chars), #RGBA (5 chars), #RRGGBB (7 chars), or #RRGGBBAA (9 chars)
        _lengthValidator = new StringLengthAttribute(9)
        {
            MinimumLength = 4,
            ErrorMessage = "Color must be in #RGB, #RGBA, #RRGGBB, or #RRGGBBAA format."
        };
    }

    /// <summary>
    /// Gets the maximum allowed length for the HEX color.
    /// </summary>
    public int MaximumLength => _lengthValidator.MaximumLength;

    /// <summary>
    /// Gets the minimum allowed length for the HEX color.
    /// </summary>
    public int MinimumLength => _lengthValidator.MinimumLength;

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
            // First validate length using StringLength validator
            var lengthResult = _lengthValidator.GetValidationResult(str, validationContext);
            if (lengthResult != ValidationResult.Success)
                return lengthResult;

            // Only accept exact lengths of 4, 5, 7, or 9 characters
            if (str.Length != 4 && str.Length != 5 && str.Length != 7 && str.Length != 9)
                return new ValidationResult("Color must be in #RGB, #RGBA, #RRGGBB, or #RRGGBBAA format.");

            // Then validate format using regex
            if (HexColorRegex().IsMatch(str))
                return ValidationResult.Success;
        }

        return new ValidationResult(ErrorMessage);
    }

    /// <summary>
    /// Regex for validating HEX color strings (#RGB, #RGBA, #RRGGBB, or #RRGGBBAA).
    /// </summary>
    [GeneratedRegex("^#([A-Fa-f0-9]{3}|[A-Fa-f0-9]{4}|[A-Fa-f0-9]{6}|[A-Fa-f0-9]{8})$")]
    private static partial Regex HexColorRegex();
}