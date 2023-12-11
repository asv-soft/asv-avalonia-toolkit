using System;
using System.Reactive;
using System.Reactive.Linq;
using Asv.Avalonia.Toolkit;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace Asv.Avalonia.ToolkitGallery.ViewModels;

public class MainViewModel : ViewModelBase
{
    private IDisposable _recordTimer;

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

        StartRecord = ReactiveCommand.Create(() =>
        {
             
            _recordTimer = Observable.Timer(TimeSpan.FromMilliseconds(100),TimeSpan.FromMilliseconds(100)).Subscribe(_ =>
            {
                StringTime = DateTime.Now.ToString("mm:ss.fff");
            });
            IsRecording = true;
            return Unit.Default;
        });
        StopRecord = ReactiveCommand.Create(() =>
        {
             _recordTimer?.Dispose();
             IsRecording = false;
            return Unit.Default;
        });
    }

    public ReactiveCommand<Unit,Unit> StopRecord { get; set; }

    [Reactive]
    public bool IsRecording { get; set; }

    public ReactiveCommand<Unit,Unit> StartRecord { get; set; }

    [Reactive]
    public string TopText { get; set; }
    
    
    [Reactive]
    public double TopValue { get; set; }

    [Reactive]
    public IndicatorStatusEnum TopStatus { get; set; }

    [Reactive]
    public string StringTime { get; set; }
}
