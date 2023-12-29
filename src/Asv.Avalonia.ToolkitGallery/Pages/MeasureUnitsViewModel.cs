using System;
using System.Reactive;
using System.Reactive.Linq;
using System.Threading.Tasks;
using Asv.Avalonia.Toolkit;
using Asv.Avalonia.ToolkitGallery.Models;
using Asv.Avalonia.ToolkitGallery.ViewModels;
using Avalonia;
using Material.Icons;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace Asv.Avalonia.ToolkitGallery.Pages;

public class MeasureUnitsViewModel: ViewModelBase, IShellPage
{
    public MeasureUnitsViewModel() : base(Uri)
    {
        PointDoubleLeftTopLineEndPoint = new Point(50, 2.5);
        PointDoubleRightTopLineEndPoint = new Point(150, 2.5);
        bool isProgressRun = false;
        Observable.Timer(TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(1))
            .Subscribe(_ =>
            {
                TopText = (Random.Shared.NextDouble() * 100.0).ToString("000.00");
                TopValue = Random.Shared.NextDouble();
                if (_ % 3 == 0)
                {
                    TopStatus = (IndicatorStatusEnum)Random.Shared.Next(0,
                        Enum.GetNames(typeof(IndicatorStatusEnum)).Length);
                }
                while (isProgressRun)
                {
                    DoubleLeftTopProgress = 0;
                    DoubleRightTopProgress = 0;
                    for (var i = 0; i < 100; i++)
                    {
                        Task.Delay(50).Wait();
                        DoubleLeftTopProgress = i;
                        DoubleRightTopProgress = i;
                        RightTopStatus =
                            (IndicatorStatusEnum)Random.Shared.Next(0,
                                Enum.GetNames(typeof(IndicatorStatusEnum)).Length);
                        LeftTopStatus =
                            (IndicatorStatusEnum)Random.Shared.Next(0,
                                Enum.GetNames(typeof(IndicatorStatusEnum)).Length);
                    }
                    DoubleLeftTopProgress = 0;
                    DoubleRightTopProgress = 0;
                    for (var i = 0; i < 100; i++)
                    {
                        if (i <= 50) TopValue = 100 - i;
                        Task.Delay(50).Wait();
                        TopValue = 100 - i;
                        DoubleLeftTopProgress = 100 - i;
                        DoubleRightTopProgress = 100 - i;
                        LeftTopStatus =
                            (IndicatorStatusEnum)Random.Shared.Next(0,
                                Enum.GetNames(typeof(IndicatorStatusEnum)).Length);
                        RightTopStatus =
                            (IndicatorStatusEnum)Random.Shared.Next(0,
                                Enum.GetNames(typeof(IndicatorStatusEnum)).Length);
                    }
                    DoubleLeftTopProgress = 0;
                    DoubleRightTopProgress = 0;
                    for (var i = 0; i < 100; i++)
                    {
                        Task.Delay(50).Wait();
                        DoubleLeftTopProgress = i;
                        DoubleRightTopProgress = 100 - i;
                        LeftTopStatus =
                            (IndicatorStatusEnum)Random.Shared.Next(0,
                                Enum.GetNames(typeof(IndicatorStatusEnum)).Length);
                        RightTopStatus =
                            (IndicatorStatusEnum)Random.Shared.Next(0,
                                Enum.GetNames(typeof(IndicatorStatusEnum)).Length);
                    }

                    isProgressRun = false;
                }

                DoubleLeftTopText = (Random.Shared.NextDouble() * 100.0).ToString("000.00");
                DoubleLeftTopProgress = Random.Shared.NextDouble() + 50.0;
                if (_ % 3 == 0)
                {
                    LeftTopStatus =
                        (IndicatorStatusEnum)Random.Shared.Next(0, Enum.GetNames(typeof(IndicatorStatusEnum)).Length);
                }

                DoubleRightTopText = (Random.Shared.NextDouble() * 100.0).ToString("000.00");
                DoubleRightTopProgress = Random.Shared.NextDouble() + 50.0;
                if (_ % 3 == 0)
                {
                    RightTopStatus =
                        (IndicatorStatusEnum)Random.Shared.Next(0, Enum.GetNames(typeof(IndicatorStatusEnum)).Length);
                }
            });
    }
    public MaterialIconKind Icon { get; }
    public string Title { get; }
    public const string UriString = $"{MainViewModel.UriString}.measure-page";
    public static readonly Uri Uri = new(UriString);
    [Reactive]
    public string DoubleLeftTopText { get; set; }
    [Reactive]
    public string DoubleRightTopText { get; set; }
    [Reactive]
    public double DoubleLeftTopProgress { get; set; }
    [Reactive]
    public Point PointDoubleLeftTopLineEndPoint { get; set; } 
    [Reactive]
    public Point PointDoubleRightTopLineEndPoint { get; set; }
    [Reactive]
    public double DoubleRightTopProgress { get; set; }
    [Reactive]
    public string TopText { get; set; }
    [Reactive]
    public double TopValue { get; set; }
    [Reactive]
    public IndicatorStatusEnum LeftTopStatus { get; set; }
    [Reactive]
    public IndicatorStatusEnum RightTopStatus { get; set; }
    [Reactive]
    public IndicatorStatusEnum TopStatus { get; set; }
    }
