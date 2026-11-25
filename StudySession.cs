using System.ComponentModel.DataAnnotations;

namespace StudyFlow.Models;

public class StudySession
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Please select a module.")]
    [Range(1, int.MaxValue, ErrorMessage = "Please select a module.")]
    [Display(Name = "Module")]
    public int ModuleId { get; set; }

    [Required(ErrorMessage = "Please choose a date.")]
    [DataType(DataType.Date)]
    [Display(Name = "Date")]
    public DateTime Date { get; set; } = DateTime.Today;

    [Required(ErrorMessage = "Please enter a start time.")]
    [DataType(DataType.Time)]
    [Display(Name = "Start Time")]
    public TimeSpan StartTime { get; set; } = new TimeSpan(9, 0, 0);

    [Required(ErrorMessage = "Please enter the duration.")]
    [Range(15, 480, ErrorMessage = "Duration must be between 15 and 480 minutes.")]
    [Display(Name = "Duration (minutes)")]
    public int DurationMinutes { get; set; } = 60;

    [StringLength(200, ErrorMessage = "Notes cannot exceed 200 characters.")]
    [Display(Name = "Notes (optional)")]
    public string? Notes { get; set; }

    public bool Completed { get; set; }
}
