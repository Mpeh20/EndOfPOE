using System.ComponentModel.DataAnnotations;

namespace StudyFlow.Models;

public class Module
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Please enter the module name.")]
    [StringLength(80, ErrorMessage = "Module name cannot exceed 80 characters.")]
    [Display(Name = "Module Name")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Please choose a colour.")]
    [RegularExpression("^#[0-9A-Fa-f]{6}$", ErrorMessage = "Colour must be a valid hex code (e.g. #3B82F6).")]
    [Display(Name = "Colour")]
    public string ColourHex { get; set; } = "#3B82F6";
}
