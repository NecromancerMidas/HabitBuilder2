

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
                IsCompleted = true,
                IsFrozen = false,
                InProgress = true,
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
                IsCompleted = false,
                IsFrozen = false,
                InProgress = true,
                UpdatedAt = null,
            };
            var habit3 = new Habit
            {
                Title = "Latinae Lego",
                Description = "Alea iacta est",
                WeekDays = new Week(), // This will initialize 7 days
                CreatedAt = DateTime.Now,
                DeletedAt = null,
                ExperiencePoints = 4,
                Guid = new Guid(),
                Level = 8,
                IsCompleted = false,
                IsFrozen = true,
                InProgress = true,
                UpdatedAt = null,
            };
            var habit4 = new Habit
            {
                Title = "Exercise",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad " +
                              "minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in " +
                              "reprehenderit in voluptate velit esse cillum dolore eu fugiat " +
                              "nulla pariatur. Excepteur sint occaecat cupidatat non proident, " +
                              "sunt in culpa qui officia deserunt mollit anim id est laborum.",
                WeekDays = new Week(), // This will initialize 7 days
                CreatedAt = DateTime.Now,
                DeletedAt = null,
                ExperiencePoints = 14,
                Guid = new Guid(),
                Level =5,
                IsCompleted = false,
                IsFrozen = true,
                InProgress = true,
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
            var template3 = new Template()
            {
                Title = "Big ass list",
                Description = "Pizza",
                HabitList = new List<Habit> { habit2, habit1, habit4, habit3, habit2, habit1, habit4, habit3 },
                Id = new Guid()
            };

            Templates.Add(template);
            Templates.Add(template2);
            Templates.Add(template3);
        }
    }
}
