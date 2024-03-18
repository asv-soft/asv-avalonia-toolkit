using System;
using System.Globalization;
using Asv.Avalonia.ToolkitGallery.Tools;
using Asv.Common;
using DynamicData.Binding;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace Asv.Avalonia.ToolkitGallery.ViewModels.Pages;

public class DateTimeViewModel : DisposableReactiveObject, IShellPage
{
    public DateTimeViewModel()
    {
        SelectedDateValue = DateTimeOffset.Now;
        SelectedTimeValue = SelectedDateValue.TimeOfDay;
        this.WhenAnyValue(x => x.SelectedDateValue).Subscribe(_ =>
        {
            DateTimeResult = $"{SelectedDateValue} {SelectedTimeValue}";
        });
        this.WhenAnyValue(x => x.SelectedTimeValue).Subscribe(_ =>
        {
            DateTimeResult = $"{SelectedDateValue.Date} {SelectedTimeValue}";
        });
    }

    [Reactive] 
    public DateTimeOffset SelectedDateValue { get; set; }
    [Reactive]
    public TimeSpan SelectedTimeValue { get; set; }
    
    [Reactive] 
    public string DateTimeResult { get; set; } = string.Empty;
}