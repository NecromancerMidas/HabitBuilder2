

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
                Status = HabitStatus.Completed,
                UpdatedAt = null,
            };

            var habit2 = new Habit
            {
                Title = "Exercise",
                Description = "Go for a jog.",
                WeekDays = new Week(), // This will initialize 7 days
                CreatedAt = DateTime.Now,
                DeletedAt = null,
                ExperiencePoints = 10,
                Guid = new Guid(),
                Level = 2,
                Status = HabitStatus.InProgress,
                UpdatedAt = null,
            };
            var habit3 = new Habit
            {
                Title = "Exercise",
                Description = "Ivdea Delenda Est",
                WeekDays = new Week(), // This will initialize 7 days
                CreatedAt = DateTime.Now,
                DeletedAt = null,
                ExperiencePoints = 4,
                Guid = new Guid(),
                Level = 8,
                Status = HabitStatus.Frozen,
                UpdatedAt = null,
            };
            var habit4 = new Habit
            {
                Title = "Exercise",
                Description = "Take back Constantinople",
                WeekDays = new Week(), // This will initialize 7 days
                CreatedAt = DateTime.Now,
                DeletedAt = null,
                ExperiencePoints = 14,
                Guid = new Guid(),
                Level =5,
                Status = HabitStatus.InProgress,
                UpdatedAt = null,
            };

            var template = new Template
            {
                Title = "Daily Habits",
                Description = "My daily routines",
                HabitList = new List<Habit> { habit1, habit2 ,habit3,habit4},
                Id = new Guid()
            };
            var template2 = new Template()
            {
                Title = "More Daily Habits",
                Description = "Pizza",
                HabitList = new List<Habit> { habit2, habit1, habit4, habit3 },
                Id = new Guid()
            };

            Templates.Add(template);
            Templates.Add(template2);
        }
    }
}
