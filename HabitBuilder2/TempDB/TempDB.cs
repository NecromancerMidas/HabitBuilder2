

using HabitBuilder2.Models.Templates;

namespace HabitBuilder2.TempDB
{
    class TempDb
    {
        public static List<Template> Templates { get; set; } = new List<Template>();

        static TempDb()
        {
            InitializeData();
        }

        private static void InitializeData()
        {
            // Create some mock data
            var habit1 = new Habit
            {
                Title = "Read a book",
                Description = "Read for 30 minutes.",
                WeekDays = new Week(), // This will initialize 7 days
                CreatedAt = DateTime.Now,
                DeletedAt = null,
                ExperiencePoints = 20,
                Guid = new Guid(),
                Level = 4,
                Status = HabitStatus.InProgress,
                UpdatedAt = null,
            };

            var habit2 = new Habit
            {
                Title = "Exercise",
                Description = "Go for a jog.",
                WeekDays = new Week(), // This will initialize 7 days
                CreatedAt = DateTime.Now,
                DeletedAt = null,
                ExperiencePoints = 20,
                Guid = new Guid(),
                Level = 4,
                Status = HabitStatus.InProgress,
                UpdatedAt = null,
            };

            var template = new Template
            {
                Title = "Daily Habits",
                Description = "My daily routines",
                HabitList = new List<Habit> { habit1, habit2 },
                Id = new Guid()
            };

            Templates.Add(template);
        }
    }
}
