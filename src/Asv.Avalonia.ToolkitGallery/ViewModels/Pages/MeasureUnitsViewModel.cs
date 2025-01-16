using System;
using System.Reactive.Linq;
using System.Threading.Tasks;
using Asv.Avalonia.Toolkit.UI.Controls.Indicators;
using Asv.Avalonia.ToolkitGallery.Tools;
using Avalonia;
using ReactiveUI.Fody.Helpers;

namespace Asv.Avalonia.ToolkitGallery.ViewModels.Pages;

public class MeasureUnitsViewModel : DisposableReactiveObject, IShellPage
{
    public MeasureUnitsViewModel()
    {
        bool isProgressRun = true;
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
