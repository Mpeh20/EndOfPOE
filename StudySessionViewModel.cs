using StudyFlow.Models;

namespace StudyFlow.Models;

public class StudySessionViewModel
{
    public StudySession Session { get; set; } = new();
    public List<Module> Modules { get; set; } = new();
    public List<StudySession> Sessions { get; set; } = new();
}
