namespace HabitBuilder2.Models.Templates;

public class Template
{
    public string Title { get; set; }
    public string Description { get; set; }
    public Guid Id { get; set; }
    public List<Habit.Habit> HabitList { get; set; }

}