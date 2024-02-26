using System;
using System.Globalization;
using Asv.Avalonia.ToolkitGallery.Tools;
using Asv.Common;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace Asv.Avalonia.ToolkitGallery.ViewModels.Pages;

public class DateTimeViewModel : DisposableReactiveObject, IShellPage
{
    public DateTimeViewModel()
    {
        SelectedDateValue = DateTimeOffset.Now;
        this.WhenAnyValue(vm => vm.SelectedDateValue,
                vm => vm.SelectedTimeValue)
            .Subscribe(complexObject =>
            {
                var (date, time) = complexObject;
                DateTimeResult = $"{date.DateTime.ToLongDateString()} {time.DateTime.ToLongTimeString()}";
            })
            .DisposeItWith(Disposable);
    }

    [Reactive] 
    public DateTimeOffset SelectedDateValue { get; set; }

    [Reactive] 
    public DateTimeOffset SelectedTimeValue { get; set; }
    
    [Reactive] 
    public string DateTimeResult { get; set; } = string.Empty;
}