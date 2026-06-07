using WebApplication1.Models;

namespace WebApplication1.DTOs;

public class LessonsDTO
{
    public int Id { get; set; }
    
    public string Title { get; set; } = null!;

    public int DurationMinutes { get; set; }

    public int maxScore { get; set; }

    public Lesson lesson { get; set; }

    public Course course { get; set; }

    public int submissionsCount { get; set; }
}