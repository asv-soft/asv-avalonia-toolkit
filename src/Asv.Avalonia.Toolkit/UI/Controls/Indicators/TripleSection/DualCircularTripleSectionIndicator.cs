using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Metadata;

namespace Asv.Avalonia.Toolkit.UI.Controls.Indicators;

[PseudoClasses(RightBottomRightCritical, RightBottomRightWarning, RightBottomRightSuccess, RightBottomRightUnknown,
    RightBottomLeftCritical, RightBottomLeftWarning, RightBottomLeftSuccess, RightBottomLeftUnknown,
    RightTopCritical, RightTopWarning, RightTopSuccess, RightTopUnknown,
    LeftBottomRightCritical, LeftBottomRightWarning, LeftBottomRightSuccess, LeftBottomRightUnknown,
    LeftBottomLeftCritical, LeftBottomLeftWarning, LeftBottomLeftSuccess, LeftBottomLeftUnknown,
    LeftTopCritical, LeftTopWarning, LeftTopSuccess, LeftTopUnknown, BottomStatusCritical, BottomStatusWarning, 
    BottomStatusSuccess, BottomStatusUnknown,LeftTopProgressWarning,LeftTopProgressSuccess,LeftTopProgressUnknown,
    LeftTopProgressCritical,RightTopProgressWarning,RightTopProgressSuccess,RightTopProgressUnknown,RightTopProgressCritical)]

public class DualCircularTripleSectionIndicator : IndicatorBase
{
    private double _topLeftProgressAngle;
    private double _topRightProgressAngle;
    private Point _topRightProgressLinePoint;
    private Point _topLeftProgressLinePoint;

    #region Consts
    
    public const string RightBottomRightCritical = ":rbr-critical";
    public const string RightBottomRightWarning = ":rbr-warning";
    public const string RightBottomRightSuccess = ":rbr-success";
    public const string RightBottomRightUnknown = ":rbr-unknown";
    public const string RightBottomLeftCritical = ":rbl-critical";
    public const string RightBottomLeftWarning = ":rbl-warning";
    public const string RightBottomLeftSuccess = ":rbl-success";
    public const string RightBottomLeftUnknown = ":rbl-unknown";
    public const string RightTopCritical = ":rt-critical";
    public const string RightTopWarning = ":rt-warning";
    public const string RightTopSuccess = ":rt-success";
    public const string RightTopUnknown = ":rt-unknown";
    public const string LeftBottomRightCritical = ":lbr-critical";
    public const string LeftBottomRightWarning = ":lbr-warning";
    public const string LeftBottomRightSuccess = ":lbr-success";
    public const string LeftBottomRightUnknown = ":lbr-unknown";
    public const string LeftBottomLeftCritical = ":lbl-critical";
    public const string LeftBottomLeftWarning = ":lbl-warning";
    public const string LeftBottomLeftSuccess = ":lbl-success";
    public const string LeftBottomLeftUnknown = ":lbl-unknown";
    public const string LeftTopProgressWarning = ":ltp-warning";
    public const string LeftTopProgressSuccess = ":ltp-success";
    public const string LeftTopProgressUnknown = ":ltp-unknown";
    public const string LeftTopProgressCritical = ":ltp-critical";
    public const string RightTopProgressWarning = ":rtp-warning";
    public const string RightTopProgressSuccess = ":rtp-success";
    public const string RightTopProgressUnknown = ":rtp-unknown";
    public const string RightTopProgressCritical = ":rtp-critical";
    public const string LeftTopCritical = ":lt-critical";
    public const string LeftTopWarning = ":lt-warning";
    public const string LeftTopSuccess = ":lt-success";
    public const string LeftTopUnknown = ":lt-unknown";
    public const string BottomStatusCritical = ":bottom-critical";
    public const string BottomStatusWarning = ":bottom-warning";
    public const string BottomStatusSuccess = ":bottom-success";
    public const string BottomStatusUnknown = ":bottom-unknown";
    
    #endregion
    
    #region Top Progress Value Props
    public static readonly StyledProperty<double> TopLeftProgressValueProperty = AvaloniaProperty.Register<DualCircularTripleSectionIndicator, double>(
        nameof(TopLeftProgressValue));

    public double TopLeftProgressValue
    {
        get => GetValue(TopLeftProgressValueProperty);
        set => SetValue(TopLeftProgressValueProperty, value);
    }
    
    public static readonly StyledProperty<double> TopRightProgressValueProperty = AvaloniaProperty.Register<DualCircularTripleSectionIndicator, double>(
        nameof(TopRightProgressValue));
    
    public double TopRightProgressValue
    {
        get => GetValue(TopRightProgressValueProperty);
        set => SetValue(TopRightProgressValueProperty, value);
    }
    
    #endregion
    #region Top Left Progress Arc Props

    public static readonly StyledProperty<double> TopLeftMinProperty = AvaloniaProperty.Register<DualCircularTripleSectionIndicator, double>(
        nameof(TopLeftMin), 0);

    public double TopLeftMin
    {
        get => GetValue(TopLeftMinProperty);
        set => SetValue(TopLeftMinProperty, value);
    }

    public static readonly StyledProperty<double> TopLeftMaxProperty = AvaloniaProperty.Register<DualCircularTripleSectionIndicator, double>(
        nameof(TopLeftMax));

    public double TopLeftMax
    {
        get => GetValue(TopLeftMaxProperty);
        set => SetValue(TopLeftMaxProperty, value);
    }
    
    public static readonly DirectProperty<DualCircularTripleSectionIndicator, double> TopLeftProgressAngleProperty =
        AvaloniaProperty.RegisterDirect<DualCircularTripleSectionIndicator, double>(
            nameof(TopLeftProgressAngle),
            p => p.TopLeftProgressAngle,
            (p, o) => p.TopLeftProgressAngle = o);

    public double TopLeftProgressAngle
    {
        get => _topLeftProgressAngle;
        private set => SetAndRaise(TopLeftProgressAngleProperty, ref _topLeftProgressAngle, value * -1);
    }
    
    #endregion
    
    #region Top Right Arc Props

    public static readonly StyledProperty<double> TopRightMinProperty = AvaloniaProperty.Register<DualCircularTripleSectionIndicator, double>(
        nameof(TopRightMin), 0);

    public double TopRightMin
    {
        get => GetValue(TopRightMinProperty);
        set => SetValue(TopRightMinProperty, value);
    }

    public static readonly StyledProperty<double> TopRightMaxProperty = AvaloniaProperty.Register<DualCircularTripleSectionIndicator, double>(
        nameof(TopRightMax));

    public double TopRightMax
    {
        get => GetValue(TopRightMaxProperty);
        set => SetValue(TopRightMaxProperty, value);
    }

    public static readonly StyledProperty<double> TopRightValueProperty = AvaloniaProperty.Register<DualCircularTripleSectionIndicator, double>(
        nameof(TopRightValue));

    public double TopRightValue
    {
        get => GetValue(TopRightValueProperty);
        set => SetValue(TopRightValueProperty, value);
    }
    
    public static readonly DirectProperty<DualCircularTripleSectionIndicator, double> TopRightProgressAngleProperty =
        AvaloniaProperty.RegisterDirect<DualCircularTripleSectionIndicator, double>(
            nameof(TopRightProgressAngle),
            p => p.TopRightProgressAngle,
            (p, o) => p.TopRightProgressAngle = o);

    public double TopRightProgressAngle
    {
        get => _topRightProgressAngle;
        private set => SetAndRaise(TopRightProgressAngleProperty, ref _topRightProgressAngle, value);
    }
    
    #endregion

    #region Top Left Progress Line props
    
    public static readonly DirectProperty<DualCircularTripleSectionIndicator, Point> TopLeftProgressLinePointProperty =
        AvaloniaProperty.RegisterDirect<DualCircularTripleSectionIndicator, Point>(
            nameof(TopLeftProgressLinePoint),
            p => p.TopLeftProgressLinePoint,
            (p, o) => p.TopLeftProgressLinePoint = o);
    
    public Point TopLeftProgressLinePoint
    {
        get => _topLeftProgressLinePoint;
        private set => SetAndRaise(TopLeftProgressLinePointProperty, ref _topLeftProgressLinePoint, value );
    }
    
    public static readonly StyledProperty<IndicatorStatusEnum> TopLeftStatusProperty = AvaloniaProperty.Register<DualCircularTripleSectionIndicator, IndicatorStatusEnum>(
        nameof(TopLeftStatus));
    
    public IndicatorStatusEnum TopLeftStatus
    {
        get => GetValue(TopLeftStatusProperty);
        set => SetValue(TopLeftStatusProperty, value);
    }
    
    public static readonly StyledProperty<Point> TopLeftProgressLineMinProperty = AvaloniaProperty.Register<DualCircularTripleSectionIndicator, Point>(
        nameof(TopLeftProgressLineMin));
    
    public Point TopLeftProgressLineMin
    {
        get => GetValue(TopLeftProgressLineMinProperty);
        set => SetValue(TopLeftProgressLineMinProperty, value);
    }

    public static readonly StyledProperty<Point> TopLeftProgressLineMaxProperty = AvaloniaProperty.Register<DualCircularTripleSectionIndicator, Point>(
        nameof(TopLeftProgressLineMax));

    public Point TopLeftProgressLineMax
    {
        get => GetValue(TopLeftProgressLineMaxProperty);
        set => SetValue(TopLeftProgressLineMaxProperty, value);
    }
    
    #endregion
    
    #region Top Right Progress Line props
    
    public static readonly DirectProperty<DualCircularTripleSectionIndicator, Point> TopRightProgressLinePointProperty =
        AvaloniaProperty.RegisterDirect<DualCircularTripleSectionIndicator, Point>(
            nameof(TopRightProgressLinePoint),
            p => p.TopRightProgressLinePoint,
            (p, o) => p.TopRightProgressLinePoint = o);
    
    public Point TopRightProgressLinePoint
    {
        get => _topRightProgressLinePoint;
        private set => SetAndRaise(TopRightProgressLinePointProperty, ref _topRightProgressLinePoint, value );
    }
    
    public static readonly StyledProperty<IndicatorStatusEnum> TopRightStatusProperty = AvaloniaProperty.Register<DualCircularTripleSectionIndicator, IndicatorStatusEnum>(
        nameof(TopRightStatus));
    
    public IndicatorStatusEnum TopRightStatus
    {
        get => GetValue(TopRightStatusProperty);
        set => SetValue(TopRightStatusProperty, value);
    }
    
    public static readonly StyledProperty<Point> TopRightProgressLineMinProperty = AvaloniaProperty.Register<DualCircularTripleSectionIndicator, Point>(
        nameof(TopRightProgressLineMin));
    
    public Point TopRightProgressLineMin
    {
        get => GetValue(TopLeftProgressLineMinProperty);
        set => SetValue(TopLeftProgressLineMinProperty, value);
    }

    public static readonly StyledProperty<Point> TopRightProgressLineMaxProperty = AvaloniaProperty.Register<DualCircularTripleSectionIndicator, Point>(
        nameof(TopRightProgressLineMax));

    public Point TopRightProgressLineMax
    {
        get => GetValue(TopRightProgressLineMaxProperty);
        set => SetValue(TopRightProgressLineMaxProperty, value);
    }
    #endregion
    
    #region RightBottomRight

    public static readonly StyledProperty<string> RightBottomRightTitleProperty = AvaloniaProperty.Register<DualCircularTripleSectionIndicator, string>(
        nameof(RightBottomRightTitle));

    public string RightBottomRightTitle
    {
        get => GetValue(RightBottomRightTitleProperty);
        set => SetValue(RightBottomRightTitleProperty, value);
    }

    public static readonly StyledProperty<string> RightBottomRightTextProperty = AvaloniaProperty.Register<DualCircularTripleSectionIndicator, string>(
        nameof(RightBottomRightText));

    public string RightBottomRightText
    {
        get => GetValue(RightBottomRightTextProperty);
        set => SetValue(RightBottomRightTextProperty, value);
    }

    public static readonly StyledProperty<IndicatorStatusEnum> RightBottomRightStatusProperty = AvaloniaProperty.Register<DualCircularTripleSectionIndicator, IndicatorStatusEnum>(
        nameof(RightBottomRightStatus));

    public IndicatorStatusEnum RightBottomRightStatus
    {
        get => GetValue(RightBottomRightStatusProperty);
        set => SetValue(RightBottomRightStatusProperty, value);
    }
    
    #endregion

    #region RightBottomLeft

    public static readonly StyledProperty<string> RightBottomLeftTitleProperty = AvaloniaProperty.Register<DualCircularTripleSectionIndicator, string>(
        nameof(RightBottomLeftTitle));

    public string RightBottomLeftTitle
    {
        get => GetValue(RightBottomLeftTitleProperty);
        set => SetValue(RightBottomLeftTitleProperty, value);
    }

    public static readonly StyledProperty<string> RightBottomLeftTextProperty = AvaloniaProperty.Register<DualCircularTripleSectionIndicator, string>(
        nameof(RightBottomLeftText));

    public string RightBottomLeftText
    {
        get => GetValue(RightBottomLeftTextProperty);
        set => SetValue(RightBottomLeftTextProperty, value);
    }
    
    public static readonly StyledProperty<IndicatorStatusEnum> RightBottomLeftStatusProperty = AvaloniaProperty.Register<DualCircularTripleSectionIndicator, IndicatorStatusEnum>(
        nameof(RightBottomLeftStatus));

    public IndicatorStatusEnum RightBottomLeftStatus
    {
        get => GetValue(RightBottomLeftStatusProperty);
        set => SetValue(RightBottomLeftStatusProperty, value);
    }

    #endregion

    #region RightTop

    public static readonly StyledProperty<string> RightTopTitleProperty = AvaloniaProperty.Register<DualCircularTripleSectionIndicator, string>(
        nameof(RightTopTitle));

    public string RightTopTitle
    {
        get => GetValue(RightTopTitleProperty);
        set => SetValue(RightTopTitleProperty, value);
    }

    public static readonly StyledProperty<string> RightTopTextProperty = AvaloniaProperty.Register<DualCircularTripleSectionIndicator, string>(
        nameof(RightTopText));

    public string RightTopText
    {
        get => GetValue(RightTopTextProperty);
        set => SetValue(RightTopTextProperty, value);
    }
    
    public static readonly StyledProperty<IndicatorStatusEnum> RightTopStatusProperty = AvaloniaProperty.Register<DualCircularTripleSectionIndicator, IndicatorStatusEnum>(
        nameof(RightTopStatus));

    public IndicatorStatusEnum RightTopStatus
    {
        get=> GetValue(RightTopStatusProperty);
        set => SetValue(RightTopStatusProperty, value);
    }

    #endregion

    #region LeftBottomRight

    public static readonly StyledProperty<string> LeftBottomRightTitleProperty = AvaloniaProperty.Register<DualCircularTripleSectionIndicator, string>(
        nameof(LeftBottomRightTitle));

    public string LeftBottomRightTitle
    {
        get => GetValue(LeftBottomRightTitleProperty);
        set => SetValue(LeftBottomRightTitleProperty, value);
    }

    public static readonly StyledProperty<string> LeftBottomRightTextProperty = AvaloniaProperty.Register<DualCircularTripleSectionIndicator, string>(
        nameof(LeftBottomRightText));

    public string LeftBottomRightText
    {
        get => GetValue(LeftBottomRightTextProperty);
        set => SetValue(LeftBottomRightTextProperty, value);
    }
    
    public static readonly StyledProperty<IndicatorStatusEnum> LeftBottomRightStatusProperty = AvaloniaProperty.Register<DualCircularTripleSectionIndicator, IndicatorStatusEnum>(
        nameof(LeftBottomRightStatus));

    public IndicatorStatusEnum LeftBottomRightStatus
    {
        get=> GetValue(LeftBottomRightStatusProperty);
        set => SetValue(LeftBottomRightStatusProperty, value);
    }

    #endregion

    #region LeftBottomLeft

    public static readonly StyledProperty<string> LeftBottomLeftTitleProperty = AvaloniaProperty.Register<DualCircularTripleSectionIndicator, string>(
        nameof(LeftBottomLeftTitle));

    public string LeftBottomLeftTitle
    {
        get => GetValue(LeftBottomLeftTitleProperty);
        set => SetValue(LeftBottomLeftTitleProperty, value);
    }

    public static readonly StyledProperty<string> LeftBottomLeftTextProperty = AvaloniaProperty.Register<DualCircularTripleSectionIndicator, string>(
        nameof(LeftBottomLeftText));

    public string LeftBottomLeftText
    {
        get => GetValue(LeftBottomLeftTextProperty);
        set => SetValue(LeftBottomLeftTextProperty, value);
    }

    public static readonly StyledProperty<IndicatorStatusEnum> LeftBottomLeftStatusProperty = AvaloniaProperty.Register<DualCircularTripleSectionIndicator, IndicatorStatusEnum>(
        nameof(LeftBottomLeftStatus));
    
    public IndicatorStatusEnum LeftBottomLeftStatus
    {
        get=> GetValue(LeftBottomLeftStatusProperty);
        set => SetValue(LeftBottomLeftStatusProperty, value);
    }
    

    #endregion

    #region LeftTop

    public static readonly StyledProperty<string> LeftTopTitleProperty = AvaloniaProperty.Register<DualCircularTripleSectionIndicator, string>(
        nameof(LeftTopTitle));

    public string LeftTopTitle
    {
        get => GetValue(LeftTopTitleProperty);
        set => SetValue(LeftTopTitleProperty, value);
    }

    public static readonly StyledProperty<string> LeftTopTextProperty = AvaloniaProperty.Register<DualCircularTripleSectionIndicator, string>(
        nameof(LeftTopText));

    public string LeftTopText
    {
        get => GetValue(LeftTopTextProperty);
        set => SetValue(LeftTopTextProperty, value);
    }
    
    public static readonly StyledProperty<IndicatorStatusEnum> LeftTopStatusProperty = AvaloniaProperty.Register<DualCircularTripleSectionIndicator, IndicatorStatusEnum>(
        nameof(LeftTopStatus));

    public IndicatorStatusEnum LeftTopStatus
    {
        get=> GetValue(LeftTopStatusProperty);
        set => SetValue(LeftTopStatusProperty, value);
    }

    #endregion

    #region BottomStatus
    
    public static readonly StyledProperty<string> BottomStatusTextProperty = AvaloniaProperty.Register<DualCircularTripleSectionIndicator, string>(
        nameof(BottomStatusText));

    public string BottomStatusText
    {
        get => GetValue(BottomStatusTextProperty);
        set => SetValue(BottomStatusTextProperty, value);
    }
    
    public static readonly StyledProperty<IndicatorStatusEnum> BottomStatusProperty = AvaloniaProperty.Register<DualCircularTripleSectionIndicator, IndicatorStatusEnum>(
        nameof(BottomStatus));
    
    public IndicatorStatusEnum BottomStatus
    {
        get => GetValue(BottomStatusProperty);
        set => SetValue(BottomStatusProperty, value);
    }
    
    #endregion
    
    protected override void OnPropertyChanged(AvaloniaPropertyChangedEventArgs change)
    {
        base.OnPropertyChanged(change);
        
        if (change.Property == TopLeftProgressValueProperty)
        {
            var progressValue = (double)change.NewValue! * 1.3;
            if (progressValue <= 0)
            {
                TopLeftProgressLinePoint = new Point(100, 2.5);
                TopLeftProgressAngle = 0;
            }
            if (progressValue >= 130 )
            {
                TopLeftProgressLinePoint = new Point(50, 2.5);
                TopLeftProgressAngle = 80;
                return;
            }
            TopLeftProgressAngle = 0;
            TopLeftProgressLinePoint = new Point((100 - progressValue),2.5);
            if (TopLeftProgressLinePoint.X <= 50)
            {
                TopLeftProgressLinePoint = new Point(50, 2.5);
                TopLeftProgressAngle =  progressValue - 50;     
            }
        }
        
        if (change.Property == TopRightProgressValueProperty)
        {
             var progressValue = (double)change.NewValue! * 1.3;
             if (progressValue <= 0)
             {
                 TopRightProgressLinePoint = new Point(100, 2.5);
                 TopRightProgressAngle = 0;
             }
             if (progressValue >= 130 )
             {
                 TopRightProgressLinePoint = new Point(150, 2.5);
                 TopRightProgressAngle = 80;
                 return;
             }
             TopRightProgressAngle = 0;
             TopRightProgressLinePoint = new Point((100 + progressValue),2.5);
             if (TopRightProgressLinePoint.X >= 150)
             {
                 TopRightProgressLinePoint = new Point(150, 2.5);
                 TopRightProgressAngle =  progressValue - 50;     
             }
        }
        
        if (change.Property == TopRightStatusProperty)
        {
            var value = (IndicatorStatusEnum)change.NewValue!;
            PseudoClasses.Set(RightTopProgressCritical, value == IndicatorStatusEnum.Critical);
            PseudoClasses.Set(RightTopProgressWarning, value == IndicatorStatusEnum.Warning);
            PseudoClasses.Set(RightTopProgressSuccess, value == IndicatorStatusEnum.Success);
            PseudoClasses.Set(RightTopProgressUnknown, value == IndicatorStatusEnum.Unknown);
        }
        if (change.Property == TopLeftStatusProperty)
        {
            var value = (IndicatorStatusEnum)change.NewValue!;
            PseudoClasses.Set(LeftTopProgressCritical, value == IndicatorStatusEnum.Critical);
            PseudoClasses.Set(LeftTopProgressWarning, value == IndicatorStatusEnum.Warning);
            PseudoClasses.Set(LeftTopProgressSuccess, value == IndicatorStatusEnum.Success);
            PseudoClasses.Set(LeftTopProgressUnknown, value == IndicatorStatusEnum.Unknown);
        }
        if (change.Property == RightBottomRightStatusProperty)
        {
            var value = (IndicatorStatusEnum)change.NewValue!;
            PseudoClasses.Set(RightBottomRightCritical, value == IndicatorStatusEnum.Critical);
            PseudoClasses.Set(RightBottomRightWarning, value == IndicatorStatusEnum.Warning);
            PseudoClasses.Set(RightBottomRightSuccess, value == IndicatorStatusEnum.Success);
            PseudoClasses.Set(RightBottomRightUnknown, value == IndicatorStatusEnum.Unknown);

        }

        if (change.Property == RightBottomLeftStatusProperty)
        {
            var value = (IndicatorStatusEnum)change.NewValue!;
            PseudoClasses.Set(RightBottomLeftCritical, value == IndicatorStatusEnum.Critical);
            PseudoClasses.Set(RightBottomLeftWarning, value == IndicatorStatusEnum.Warning);
            PseudoClasses.Set(RightBottomLeftSuccess, value == IndicatorStatusEnum.Success);
            PseudoClasses.Set(RightBottomLeftUnknown, value == IndicatorStatusEnum.Unknown);
        }

        if (change.Property == RightTopStatusProperty)
        {
            var value = (IndicatorStatusEnum)change.NewValue!;
            PseudoClasses.Set(RightTopCritical, value == IndicatorStatusEnum.Critical);
            PseudoClasses.Set(RightTopWarning, value == IndicatorStatusEnum.Warning);
            PseudoClasses.Set(RightTopSuccess, value == IndicatorStatusEnum.Success);
            PseudoClasses.Set(RightTopUnknown, value == IndicatorStatusEnum.Unknown);
        }

        if (change.Property == LeftBottomRightStatusProperty)
        {
            var value = (IndicatorStatusEnum)change.NewValue!;
            PseudoClasses.Set(LeftBottomRightCritical, value == IndicatorStatusEnum.Critical);
            PseudoClasses.Set(LeftBottomRightWarning, value == IndicatorStatusEnum.Warning);
            PseudoClasses.Set(LeftBottomRightSuccess, value == IndicatorStatusEnum.Success);
            PseudoClasses.Set(LeftBottomRightUnknown, value == IndicatorStatusEnum.Unknown);
        }

        if (change.Property == LeftBottomLeftStatusProperty)
        {
            var value = (IndicatorStatusEnum)change.NewValue!;
            PseudoClasses.Set(LeftBottomLeftCritical, value == IndicatorStatusEnum.Critical);
            PseudoClasses.Set(LeftBottomLeftWarning, value == IndicatorStatusEnum.Warning);
            PseudoClasses.Set(LeftBottomLeftSuccess, value == IndicatorStatusEnum.Success);
            PseudoClasses.Set(LeftBottomLeftUnknown, value == IndicatorStatusEnum.Unknown);
        }

        if (change.Property == LeftTopStatusProperty)
        {
            var value = (IndicatorStatusEnum)change.NewValue!;
            PseudoClasses.Set(LeftTopCritical, value == IndicatorStatusEnum.Critical);
            PseudoClasses.Set(LeftTopWarning, value == IndicatorStatusEnum.Warning);
            PseudoClasses.Set(LeftTopSuccess, value == IndicatorStatusEnum.Success);
            PseudoClasses.Set(LeftTopUnknown, value == IndicatorStatusEnum.Unknown);
        }

        if (change.Property == BottomStatusProperty)
        {
            var value = (IndicatorStatusEnum)change.NewValue!;
            PseudoClasses.Set(BottomStatusCritical, value == IndicatorStatusEnum.Critical);
            PseudoClasses.Set(BottomStatusWarning, value == IndicatorStatusEnum.Warning);
            PseudoClasses.Set(BottomStatusSuccess, value == IndicatorStatusEnum.Success);
            PseudoClasses.Set(BottomStatusUnknown, value == IndicatorStatusEnum.Unknown);
        }
    }

}