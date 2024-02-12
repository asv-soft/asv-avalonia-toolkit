using Avalonia;

namespace Asv.Avalonia.Toolkit.DateTime;

public class TimePickerControl : IndicatorBase
{
    
    public TimePickerControl()
    {
        
        CurrentTime = System.DateTime.Now;
        SelectedTimeValue = CurrentTime.TimeOfDay; 
        SelectedMinutes = CurrentTime.Minute.ToString("00");
        SelectedHours = CurrentTime.Hour.ToString("00");
        MinutesList = new List<string>();
        MinutesList.Add("00");
        for (int i = 1; i <= 59; i++)
        {
            MinutesList.Add(i.ToString("00"));
        }
        HoursList = new List<string>();
        HoursList.Add("00");
        for (int i = 1; i <= 23; i++)
        {
            HoursList.Add(i.ToString("00"));
        }
    }

    private bool _isCurrentTimeSelected ;
    
    public static readonly DirectProperty<TimePickerControl, bool> IsCurrentTimeSelectedProperty = AvaloniaProperty.RegisterDirect<TimePickerControl, bool>(
        nameof(IsCurrentTimeSelected), o => o.IsCurrentTimeSelected, (o, v) => o.IsCurrentTimeSelected = v);

    
    public bool IsCurrentTimeSelected
    {
        get => _isCurrentTimeSelected;
        private set => SetAndRaise(IsCurrentTimeSelectedProperty, ref _isCurrentTimeSelected, value);
    }

    public System.DateTime CurrentTime;
    
    private List<string> _minutesList;
    
    public static readonly DirectProperty<TimePickerControl, List<string>> MinutesListProperty = AvaloniaProperty.RegisterDirect<TimePickerControl, List<string>>(
        nameof(MinutesList), o => o.MinutesList, (o, v) => o.MinutesList = v);

    public List<string> MinutesList
    {
        get => _minutesList;
        private set => SetAndRaise(MinutesListProperty, ref _minutesList, value);
    }
    
    private TimeSpan _selectedTimeValue ;
    
    public static readonly DirectProperty<TimePickerControl, TimeSpan> SelectedTimeValueProperty = AvaloniaProperty.RegisterDirect<TimePickerControl, TimeSpan>(
        nameof(SelectedTimeValue), o => o.SelectedTimeValue, (o, v) => o.SelectedTimeValue = v);

    
    public TimeSpan SelectedTimeValue
    {
        get => _selectedTimeValue;
        private set => SetAndRaise(SelectedTimeValueProperty, ref _selectedTimeValue, value);
    }
    
    private List<string> _hoursList;
    
    public static readonly DirectProperty<TimePickerControl, List<string>> HoursListProperty = AvaloniaProperty.RegisterDirect<TimePickerControl, List<string>>(
        nameof(HoursList), o => o.HoursList, (o, v) => o.HoursList = v);
    
    public List<string> HoursList
    {
        get => _hoursList;
        private set => SetAndRaise(HoursListProperty, ref _hoursList, value);
    }
    
    private string _selectedMinutes;
    
    public static readonly DirectProperty<TimePickerControl, string> SelectedMinutesProperty = AvaloniaProperty.RegisterDirect<TimePickerControl, string>(
        nameof(SelectedMinutes), o => o.SelectedMinutes, (o, v) => o.SelectedMinutes = v);
    
    public string SelectedMinutes
    {
        get => _selectedMinutes;
        private set => SetAndRaise(SelectedMinutesProperty, ref _selectedMinutes, value);
    }
    
    private string _selectedHours;

    public static readonly DirectProperty<TimePickerControl, string> SelectedHoursProperty = AvaloniaProperty.RegisterDirect<TimePickerControl, string>(
        nameof(SelectedHours), o => o.SelectedHours, (o, v) => o.SelectedHours = v);

    public string SelectedHours
    {
        get => _selectedHours;
        private set => SetAndRaise(SelectedHoursProperty, ref _selectedHours, value);
    }
    
    protected override void OnPropertyChanged(AvaloniaPropertyChangedEventArgs change)
    {
       
        base.OnPropertyChanged(change);
       
           if (change.Property == SelectedHoursProperty || change.Property == SelectedMinutesProperty)
           {
               if (SelectedHours == null) SelectedHours = "00";
               if(SelectedMinutes == null) SelectedMinutes = "00";
               SelectedTimeValue = new TimeSpan(int.Parse(SelectedHours),int.Parse(SelectedMinutes),0);
           }

           if (change.Property == IsCurrentTimeSelectedProperty)
           {
               SelectedMinutes = null;
               SelectedHours = null;
           }
    }
   
}