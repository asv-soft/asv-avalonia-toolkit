using System.Windows.Input;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Interactivity;
using ReactiveCommand = ReactiveUI.ReactiveCommand;

namespace Asv.Avalonia.Toolkit.DateTime;

public class DatePickerControl : TemplatedControl
{
    public DatePickerControl()
    {
         DateValue = System.DateTime.Today;
         DayValue = DateValue.Day.ToString("00");
         MonthValue = DateValue.Month.ToString("00");
         YearValue = DateValue.Year.ToString();
         YearList = new();
         MonthList = new();
         DayList = new();
         for (int i=1; i<=31;i++) DayList.Add(i.ToString("00"));  
         for (int i=1; i<=12;i++) MonthList.Add(i.ToString("00"));   
         for (int i=DateValue.Year; i<=DateValue.Year+100;i++) YearList.Add(i.ToString("0000"));
         
    }

    public static EventHandler<SelectionChangedEventArgs> SelectionChanged;
    
    
    private List<string> _daylist;
    public static readonly DirectProperty<DatePickerControl, List<string>> DayListProperty = AvaloniaProperty.RegisterDirect<DatePickerControl, List<string>>(
        nameof(DayList), o => o.DayList, (o, v) => o.DayList = v);

    public List<string> DayList
    {
        get=>_daylist; 
        set=> SetAndRaise(DayListProperty,ref _daylist, value);
    }
    private List<string> _monthlist;
    public static readonly DirectProperty<DatePickerControl, List<string>> MonthListProperty = AvaloniaProperty.RegisterDirect<DatePickerControl, List<string>>(
        nameof(MonthList), o => o.MonthList, (o, v) => o.MonthList = v);

    public List<string> MonthList
    {
        get=>_monthlist; 
        set=> SetAndRaise(MonthListProperty,ref _monthlist, value);
    }
    private List<string> _yearlist;
    public static readonly DirectProperty<DatePickerControl, List<string>> YearListProperty = AvaloniaProperty.RegisterDirect<DatePickerControl, List<string>>(
        nameof(YearList), o => o.YearList, (o, v) => o.YearList = v);

    public List<string> YearList
    {
        get=>_yearlist; 
        set=> SetAndRaise(YearListProperty,ref _yearlist, value);
    }
    
    private System.DateTime _date;
    public static readonly DirectProperty<DatePickerControl, System.DateTime> DateValueProperty = AvaloniaProperty.RegisterDirect<DatePickerControl, System.DateTime>(
            nameof(DateValue), o => o.DateValue, (o, v) => o.DateValue = v); 
    
    public System.DateTime DateValue 
    {
        get => _date;
        set => SetAndRaise(DateValueProperty,ref _date, value);
    } 
     
    private string _day;
    public static readonly DirectProperty<DatePickerControl, string> DayValueProperty = AvaloniaProperty.RegisterDirect<DatePickerControl, string>(
        nameof(DayValue), o => o.DayValue, (o, v) => o.DayValue = v, "01"); 
    
    public string DayValue
    {
        get => _day;
        set => SetAndRaise(DayValueProperty,ref _day, value);
    }
    private string _month;
    
    public static readonly DirectProperty<DatePickerControl, string> MonthValueProperty = AvaloniaProperty.RegisterDirect<DatePickerControl, string>(
        nameof(MonthValue), o => o.MonthValue, (o, v) => o.MonthValue = v, "01"); 
    
    public string MonthValue
    {
        get => _month;
        set => SetAndRaise(MonthValueProperty,ref _month, value);
    }
    private string _year;
    
    public static readonly DirectProperty<DatePickerControl, string> YearValueProperty = AvaloniaProperty.RegisterDirect<DatePickerControl, string>(
        nameof(YearValue), o => o.YearValue, (o, v) => o.YearValue = v, "0001"); 
    
    public string YearValue
    {
        get => _year;
        set => SetAndRaise(YearValueProperty,ref _year, value);
    }

     protected override void OnPropertyChanged(AvaloniaPropertyChangedEventArgs change)
     {
         base.OnPropertyChanged(change);
         if (change.Property == DayValueProperty) DateValue.AddDays(int.Parse(DayValue));
         if (change.Property == MonthValueProperty) DateValue.AddMonths(int.Parse(MonthValue));
         if (change.Property == YearValueProperty) DateValue.AddYears(int.Parse(YearValue));
         if (change.Property == DateValueProperty)
         {
             if (DayValue == null) DayValue = DateValue.Day.ToString("00");
             if (MonthValue == null) MonthValue = DateValue.Month.ToString("00");
             if (YearValue == null) YearValue = DateValue.Year.ToString();
         }
             
     }
    
     
     
}