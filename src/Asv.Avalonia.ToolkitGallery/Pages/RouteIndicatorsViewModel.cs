using System;
using System.Reactive;
using System.Reactive.Linq;
using Asv.Avalonia.Toolkit;
using Asv.Avalonia.ToolkitGallery.Models;
using Asv.Avalonia.ToolkitGallery.ViewModels;
using Avalonia;
using Material.Icons;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace Asv.Avalonia.ToolkitGallery.Pages;

public class RouteIndicatorsViewModel: ViewModelBase, IShellPage
{
    private IDisposable _recordTimer;
    public RouteIndicatorsViewModel():base(Uri)
    {
        StartRecord = ReactiveCommand.Create(() =>
        {
            Progress = 0;
            _recordTimer = Observable.Timer(TimeSpan.FromMilliseconds(100),TimeSpan.FromMilliseconds(100)).Subscribe(_ =>
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
    public MaterialIconKind Icon { get; }
    public string Title { get; }
    public const string UriString = $"{MainViewModel.UriString}.route-page";
    public static readonly Uri Uri = new(UriString);
    public ReactiveCommand<Unit,Unit> StartRecord { get; set; }
    public ReactiveCommand<Unit,Unit> StopRecord { get; set; }
    [Reactive]
    public bool IsRecording { get; set; }
    [Reactive]
    public double Progress { get; set; }
    [Reactive]
    public string StringTime { get; set; }
}