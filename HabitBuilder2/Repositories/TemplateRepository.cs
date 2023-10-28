using HabitBuilder2.Models.Templates;
using HabitBuilder2.TempDB;

namespace HabitBuilder2.Repositories;

public class TemplateRepository : IRepository<Template>
{
    public IEnumerable<Template> GetAll()
    {
        return TempDb.Templates;
    }

    // Fetch a single template by id
    public Template GetById(Guid id)
    {
        return TempDb.Templates.FirstOrDefault(template => template.Id == id);
    }

    // Add a new template
    public void Add(Template template)
    {
        TempDb.Templates.Add(template);
    }

    // Update an existing template
    public void Update(Template template)
    {
        var existing = GetById(template.Id);
        if (existing != null)
        {
            // Assuming TempDb.Templates is a List<T>
            int index = TempDb.Templates.IndexOf(existing);
            TempDb.Templates[index] = template;
        }
    }

    // Delete a template
    public void Delete(Template template)
    {
        TempDb.Templates.Remove(template);
    }
}
