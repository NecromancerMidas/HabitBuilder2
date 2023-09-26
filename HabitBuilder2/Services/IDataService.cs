using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HabitBuilder2.Models.Templates;

namespace HabitBuilder2.Services
{
    public interface IDataService
    {
        List<Template> GetTemplates();
    }
}
