using HabitBuilder2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HabitBuilder2.Models.Templates;

namespace HabitBuilder2.TempDB
{
    public class TempDbDataService : IDataService
    {
        public List<Template> GetTemplates()
        {
            return TempDb.Templates; // Assuming TempDb.Templates is your mock database
        }
    }
}
