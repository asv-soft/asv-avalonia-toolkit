using System;
using System.Reactive.Linq;
using Asv.Avalonia.Toolkit;
using ReactiveUI.Fody.Helpers;

namespace Asv.Avalonia.ToolkitGallery.ViewModels;

public class MainViewModel : ViewModelBase
{
    public MainViewModel()
    {
        Observable.Timer(TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(1))
            .Subscribe(_ =>
            {
                TopText = (Random.Shared.NextDouble() * 100.0).ToString("000.00");
                TopValue = Random.Shared.NextDouble();
                if (_ % 3 == 0)
                {
                    TopStatus = (IndicatorStatusEnum)Random.Shared.Next(0, Enum.GetNames(typeof(IndicatorStatusEnum)).Length);    
                }
            });
    }
    
    [Reactive]
    public string TopText { get; set; }
    
    
    [Reactive]
    public double TopValue { get; set; }

    [Reactive]
    public IndicatorStatusEnum TopStatus { get; set; }
}
