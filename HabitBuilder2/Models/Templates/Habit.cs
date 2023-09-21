using HabitBuilder2;
using HabitBuilder2.Models;
using HabitBuilder2.Models.Templates;


namespace HabitBuilder2.Models.Templates;
public enum HabitStatus
{
    NotStarted,
    InProgress,
    Frozen,
    Completed,
    Paused,
}
public class Habit
{
    public HabitStatus Status { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public Guid Guid { get; set; }
    public int ExperiencePoints { get; set; }
    public int Level { get; set; }
    public Week WeekDays { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; } // Nullable, in case it hasn't been updated yet
    public DateTime? DeletedAt { get; set; } // Uncomment if you're using soft deletes

    public Habit()
    {
        CreatedAt = DateTime.Now;
    }
}