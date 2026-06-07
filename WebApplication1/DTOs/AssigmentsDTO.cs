using WebApplication1.Models;

namespace WebApplication1.DTOs;

public class AssigmentsDTO
{
    public int Id { get; set; }
    
    public string Title { get; set; } = null!;

    public DateTime DueDate { get; set; }

    public int MaxScore { get; set; }

    public Lesson Lessons { get; set; } = null!;

    public virtual ICollection<Submission> Submissions { get; set; } = new List<Submission>();
}