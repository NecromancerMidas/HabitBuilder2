using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HabitBuilder2.Models.Templates;
using HabitBuilder2.Utilities.Converter.HabitBar;
using HabitBuilder2.ViewModels.DataModels.Templates;
using HabitBuilder2.ViewModels.UiModels.MainPage.Components;

namespace HabitBuilder2.Views.MainPage.Components.DetailedViewComponents.SpecificHabitOverviewComponents;

public partial class DetailsBar : ContentView
{
    private HabitBarWidthConverter _converter;
    public static readonly BindableProperty Metric1Property = BindableProperty.Create(
        nameof(Metric1), typeof(int), typeof(DetailsBar), default(int),
        propertyChanged: OnMetric1Changed);
    public static readonly BindableProperty Metric2Property = BindableProperty.Create(
        nameof(Metric2), typeof(int), typeof(DetailsBar), default(int),
        propertyChanged: OnMetric2Changed);
    public static readonly BindableProperty TitleProperty = BindableProperty.Create(
        nameof(Title), typeof(string), typeof(DetailsBar), default(string),
        propertyChanged: OnTitleChanged);
    public DetailsBar()
    {
        InitializeComponent();
    }

    public string Title
    {
        get => (string)GetValue(TitleProperty);
        set => SetValue(TitleProperty, value);
    }
    public int Metric2
    {
        get => (int)GetValue(Metric2Property);
        set => SetValue(Metric2Property, value);
    }
    public int Metric1
    {
        get => (int)GetValue(Metric1Property);
        set => SetValue(Metric1Property, value);
    }
    private static void OnMetric1Changed(BindableObject bindable, object oldValue, object newValue)
    {
        var viewModel = ((DetailsBar)bindable).BindingContext as DetailsBarViewModel;
        if (viewModel != null)
        {
            viewModel.Metric1 = (int)newValue;
        }
    }
    private static void OnMetric2Changed(BindableObject bindable, object oldValue, object newValue)
    {
        var viewModel = ((DetailsBar)bindable).BindingContext as DetailsBarViewModel;
        if (viewModel != null)
        {
            viewModel.Metric2 = (int)newValue;
        }
    }
    private static void OnTitleChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var viewModel = ((DetailsBar)bindable).BindingContext as DetailsBarViewModel;
        if (viewModel != null)
        {
            viewModel.Title = (string)newValue;
        }
    }
    protected override void OnSizeAllocated(double width, double height)
    {
        base.OnSizeAllocated(width, height);
        SetStatus();
        UpdateLoadingBarWidth();

    }
    protected override void OnBindingContextChanged()
    {
        base.OnBindingContextChanged();

        if (BindingContext is INotifyPropertyChanged notifyPropertyChanged)
        {
            notifyPropertyChanged.PropertyChanged += ViewModel_PropertyChanged;
        }
    }
    private void ViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName == "Metric1")
        {
            UpdateLoadingBarWidth();
        }

        if (e.PropertyName == "Status" || e.PropertyName == "Selected")
        {

            SetStatus();
        }

    }

    /* private void BarSelected(object sender, EventArgs e)
     {
         Debug.WriteLine("Tapped");
         if (BindingContext is HabitViewModel viewModel)
         {
             viewModel.Status = HabitStatus.Selected;
         }

     }*/
    private void SetStatus()
    {
        if (BindingContext is HabitViewModel viewModel)
        {
            if (viewModel.Selected)
            {
                Status.Text = "Selected";
                StatusColor.BackgroundColor = Color.FromArgb("#a403aa");
                return;
            }
            switch (viewModel.Status)
            {
                case HabitStatus.InProgress:
                    Status.Text = "In Progress";
                    StatusColor.BackgroundColor = Color.FromArgb("#ff960f");
                    break;
                case HabitStatus.Frozen:
                    Status.Text = "Frozen";
                    StatusColor.BackgroundColor = Color.FromArgb("#3499FE");
                    break;
                case HabitStatus.Completed:
                    Status.Text = "Completed";
                    StatusColor.BackgroundColor = Color.FromArgb("#008000");
                    break;

                default:
                    Status.Text = "error";
                    StatusColor.BackgroundColor = Color.FromArgb("#8000ff");
                    break;
            }
        }

    }


    /*public string HabitTitle
    {
        get => (string)GetValue(HabitTitleProp);
        set => SetValue(HabitTitleProp,value);
    }

    public int HabitLevel
    {
        get => (int)GetValue(HabitLevelProp);
        set => SetValue(HabitLevelProp, value);
    }*/
    /* public int HabitStreak
     {
         get => (int)GetValue(HabitStreakProp);
         set
         {
             SetValue(HabitStreakProp, value);
             UpdateLoadingBarWidth();
             System.Diagnostics.Debug.WriteLine("HabitStreak set: " + value);
         }
     }*/
    /*  public void AnimateWidth(RoundRectangle loadingBar, double startWidth, double endWidth, uint duration)
      {
          loadingBar.Animate("WidthAnimation", d => loadingBar.WidthRequest = d, startWidth, endWidth, length: duration);
      }
  */
    public void UpdateLoadingBarWidth()
    {
        if (BindingContext is HabitViewModel viewModel)
        {

            var converterValue = _converter.Convert(viewModel.ExperiencePoints, typeof(double), null, CultureInfo.CurrentCulture);
            if (converterValue is double value)
            {
                var width = (150 / 21) * value;
                LoadingRectangle.Animate("Progress",
                    d => LoadingRectangle.WidthRequest = d,
                    LoadingRectangle.WidthRequest,
                    width,
                    16,
                    6000,
                    Easing.Linear);

            }
        }
    }
}