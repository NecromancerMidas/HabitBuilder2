using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HabitBuilder2.Models.Templates;
using HabitBuilder2.Services;


namespace HabitBuilder2.Models
{
    public class MainPageModel
    {
        
        public List<Template> Templates { get; set; }
        public MainPageModel(IDataService dataService)
        {
            Templates = dataService.GetTemplates();
        }
        

    }
}
