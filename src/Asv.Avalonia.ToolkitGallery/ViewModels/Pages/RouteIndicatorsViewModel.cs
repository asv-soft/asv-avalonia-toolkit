using System;
using System.Reactive;
using System.Reactive.Linq;
using Asv.Avalonia.ToolkitGallery.Tools;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace Asv.Avalonia.ToolkitGallery.ViewModels.Pages;

public class RouteIndicatorsViewModel : DisposableReactiveObject, IShellPage
{
    private IDisposable _recordTimer;

    public RouteIndicatorsViewModel()
    {
        StartRecord = ReactiveCommand.Create(() =>
        {
            Progress = 0;
            _recordTimer = Observable
                .Timer(TimeSpan.FromMilliseconds(100), TimeSpan.FromMilliseconds(100))
                .Subscribe(_ =>
                {
                    StringTime = DateTime.Now.ToString("mm:ss.fff");
                    Progress += 0.01;
                    if (Progress >= 1.0)
                    {
                        Progress = 1;
                    }
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

    public ReactiveCommand<Unit, Unit> StartRecord { get; set; }
    public ReactiveCommand<Unit, Unit> StopRecord { get; set; }

    [Reactive]
    public bool IsRecording { get; set; }

    [Reactive]
    public double Progress { get; set; }

    [Reactive]
    public string StringTime { get; set; }
}
