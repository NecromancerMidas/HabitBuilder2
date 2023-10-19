namespace HabitBuilder2.Utilities.MarkupExtensions;

public class ParentBindingContextExtension : IMarkupExtension
{
    public string Path { get; set; }

    public object ProvideValue(IServiceProvider serviceProvider)
    {
        var valueProvider = serviceProvider.GetService(typeof(IProvideValueTarget)) as IProvideValueTarget;
       /* if (valueProvider?.TargetObject is BindableObject bindableObject)
        {
            return new Binding(Path, source: bindableObject.Parent?.BindingContext);
        }*/
        return null;
    }
}