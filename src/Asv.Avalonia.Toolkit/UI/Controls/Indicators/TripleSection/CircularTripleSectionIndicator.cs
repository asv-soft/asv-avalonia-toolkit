using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Metadata;

namespace Asv.Avalonia.Toolkit.UI.Controls.Indicators;

[PseudoClasses(LeftCritical, LeftWarning, LeftSuccess, LeftUnknown,
    TopCritical, TopWarning, TopSuccess, TopUnknown,
    RightCritical, RightWarning, RightSuccess, RightUnknown)]
public class CircularTripleSectionIndicator : IndicatorBase
{
    public const string TopCritical = ":top-critical";
    public const string TopWarning = ":top-warning";
    public const string TopSuccess = ":top-success";
    public const string TopUnknown = ":top-unknown";
    public const string LeftCritical = ":left-critical";
    public const string LeftWarning = ":left-warning";
    public const string LeftSuccess = ":left-success";
    public const string LeftUnknown = ":left-unknown";
    public const string RightCritical = ":right-critical";
    public const string RightWarning = ":right-warning";
    public const string RightSuccess = ":right-success";
    public const string RightUnknown = ":right-unknown";
    
    private double _topProgressAngle;

    #region Top Props

    public static readonly StyledProperty<double> TopMinProperty = AvaloniaProperty.Register<CircularTripleSectionIndicator, double>(
        nameof(TopMin), 0);

    public double TopMin
    {
        get => GetValue(TopMinProperty);
        set => SetValue(TopMinProperty, value);
    }

    public static readonly StyledProperty<double> TopMaxProperty = AvaloniaProperty.Register<CircularTripleSectionIndicator, double>(
        nameof(TopMin));

    public double TopMax
    {
        get => GetValue(TopMaxProperty);
        set => SetValue(TopMaxProperty, value);
    }

    public static readonly StyledProperty<double> TopValueProperty = AvaloniaProperty.Register<CircularTripleSectionIndicator, double>(
        nameof(TopValue));

    public double TopValue
    {
        get => GetValue(TopValueProperty);
        set => SetValue(TopValueProperty, value);
    }
    
    public static readonly DirectProperty<CircularTripleSectionIndicator, double> TopProgressAngleProperty =
        AvaloniaProperty.RegisterDirect<CircularTripleSectionIndicator, double>(
            nameof(TopProgressAngle),
            p => p.TopProgressAngle,
            (p, o) => p.TopProgressAngle = o);

    public double TopProgressAngle
    {
        get => _topProgressAngle;
        private set => SetAndRaise(TopProgressAngleProperty, ref _topProgressAngle, value);
    }


    public static readonly StyledProperty<string> TopTextProperty = AvaloniaProperty.Register<CircularTripleSectionIndicator, string>(
        nameof(TopText));

    public string TopText
    {
        get => GetValue(TopTextProperty);
        set => SetValue(TopTextProperty, value);
    }

    public static readonly StyledProperty<string> TopTitleProperty = AvaloniaProperty.Register<CircularTripleSectionIndicator, string>(
        nameof(TopTitle));

    public string TopTitle
    {
        get => GetValue(TopTitleProperty);
        set => SetValue(TopTitleProperty, value);
    }

    public static readonly StyledProperty<IndicatorStatusEnum> TopStatusProperty = AvaloniaProperty.Register<CircularTripleSectionIndicator, IndicatorStatusEnum>(
        nameof(TopStatus));

    public IndicatorStatusEnum TopStatus
    {
        get => GetValue(TopStatusProperty);
        set => SetValue(TopStatusProperty, value);
    }
    
    
    #endregion
   
    #region Left props

    public static readonly StyledProperty<string> LeftTextProperty = AvaloniaProperty.Register<CircularTripleSectionIndicator, string>(
        nameof(LeftText));

    public string LeftText
    {
        get => GetValue(LeftTextProperty);
        set => SetValue(LeftTextProperty, value);
    }

    public static readonly StyledProperty<string> LeftTitleProperty = AvaloniaProperty.Register<CircularTripleSectionIndicator, string>(
        nameof(LeftTitle));

    public string LeftTitle
    {
        get => GetValue(LeftTitleProperty);
        set => SetValue(LeftTitleProperty, value);
    }

    public static readonly StyledProperty<IndicatorStatusEnum> LeftStatusProperty = AvaloniaProperty.Register<CircularTripleSectionIndicator, IndicatorStatusEnum>(
        nameof(LeftStatus));

    public IndicatorStatusEnum LeftStatus
    {
        get => GetValue(LeftStatusProperty);
        set => SetValue(LeftStatusProperty, value);
    }
    
    #endregion
    
    #region Right props

    public static readonly StyledProperty<string> RightTextProperty = AvaloniaProperty.Register<CircularTripleSectionIndicator, string>(
        nameof(RightText));

    public string RightText
    {
        get => GetValue(RightTextProperty);
        set => SetValue(RightTextProperty, value);
    }

    public static readonly StyledProperty<string> RightTitleProperty = AvaloniaProperty.Register<CircularTripleSectionIndicator, string>(
        nameof(RightTitle));

    public string RightTitle
    {
        get => GetValue(RightTitleProperty);
        set => SetValue(RightTitleProperty, value);
    }

    public static readonly StyledProperty<IndicatorStatusEnum> RightStatusProperty = AvaloniaProperty.Register<CircularTripleSectionIndicator, IndicatorStatusEnum>(
        nameof(RightStatus));

    public IndicatorStatusEnum RightStatus
    {
        get => GetValue(RightStatusProperty);
        set => SetValue(RightStatusProperty, value);
    }
    
    #endregion
    
    protected override void OnPropertyChanged(AvaloniaPropertyChangedEventArgs change)
    {
        base.OnPropertyChanged(change);
        if (change.Property == TopValueProperty)
        {
            var value = (double)change.NewValue!;
            var min = TopMin;
            var max = TopMax;
            var angle = 160 * (value - min) / (max - min);
            TopProgressAngle = angle;
        }

        if (change.Property == TopStatusProperty)
        {
            var value = (IndicatorStatusEnum)change.NewValue!;
            PseudoClasses.Set(TopCritical, value == IndicatorStatusEnum.Critical);
            PseudoClasses.Set(TopWarning, value == IndicatorStatusEnum.Warning);
            PseudoClasses.Set(TopSuccess, value == IndicatorStatusEnum.Success);
            PseudoClasses.Set(TopUnknown, value == IndicatorStatusEnum.Unknown);
        }
        if (change.Property == LeftStatusProperty)
        {
            var value = (IndicatorStatusEnum)change.NewValue!;
            PseudoClasses.Set(LeftCritical, value == IndicatorStatusEnum.Critical);
            PseudoClasses.Set(LeftWarning, value == IndicatorStatusEnum.Warning);
            PseudoClasses.Set(LeftSuccess, value == IndicatorStatusEnum.Success);
            PseudoClasses.Set(LeftUnknown, value == IndicatorStatusEnum.Unknown);
        }
        if (change.Property == RightStatusProperty)
        {
            var value = (IndicatorStatusEnum)change.NewValue!;
            PseudoClasses.Set(RightCritical, value == IndicatorStatusEnum.Critical);
            PseudoClasses.Set(RightWarning, value == IndicatorStatusEnum.Warning);
            PseudoClasses.Set(RightSuccess, value == IndicatorStatusEnum.Success);
            PseudoClasses.Set(RightUnknown, value == IndicatorStatusEnum.Unknown);
        }
    }
    
    
}