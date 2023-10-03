namespace HabitBuilder2.Services;

public interface ISelectable
{
    bool Selected { get; set; }
    void SetSelected(bool selected);
}