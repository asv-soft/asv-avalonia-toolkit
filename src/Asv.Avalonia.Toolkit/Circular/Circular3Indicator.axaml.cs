using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Metadata;
using Avalonia.Controls.Primitives;

namespace Asv.Avalonia.Toolkit;

[PseudoClasses(LeftCritical, LeftWarning, LeftSuccess, LeftUnknown,
    TopCritical, TopWarning, TopSuccess, TopUnknown,
    RightCritical, RightWarning, RightSuccess, RightUnknown)]
public class Circular3Indicator : IndicatorBase
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

    public static readonly StyledProperty<double> TopMinProperty = AvaloniaProperty.Register<Circular3Indicator, double>(
        nameof(TopMin), 0);

    public double TopMin
    {
        get => GetValue(TopMinProperty);
        set => SetValue(TopMinProperty, value);
    }

    public static readonly StyledProperty<double> TopMaxProperty = AvaloniaProperty.Register<Circular3Indicator, double>(
        nameof(TopMin));

    public double TopMax
    {
        get => GetValue(TopMaxProperty);
        set => SetValue(TopMaxProperty, value);
    }

    public static readonly StyledProperty<double> TopValueProperty = AvaloniaProperty.Register<Circular3Indicator, double>(
        nameof(TopValue));

    public double TopValue
    {
        get => GetValue(TopValueProperty);
        set => SetValue(TopValueProperty, value);
    }
    
    public static readonly DirectProperty<Circular3Indicator, double> TopProgressAngleProperty =
        AvaloniaProperty.RegisterDirect<Circular3Indicator, double>(
            nameof(TopProgressAngle),
            p => p.TopProgressAngle,
            (p, o) => p.TopProgressAngle = o);

    public double TopProgressAngle
    {
        get => _topProgressAngle;
        private set => SetAndRaise(TopProgressAngleProperty, ref _topProgressAngle, value);
    }


    public static readonly StyledProperty<string> TopTextProperty = AvaloniaProperty.Register<Circular3Indicator, string>(
        nameof(TopText));

    public string TopText
    {
        get => GetValue(TopTextProperty);
        set => SetValue(TopTextProperty, value);
    }

    public static readonly StyledProperty<string> TopTitleProperty = AvaloniaProperty.Register<Circular3Indicator, string>(
        nameof(TopTitle));

    public string TopTitle
    {
        get => GetValue(TopTitleProperty);
        set => SetValue(TopTitleProperty, value);
    }

    public static readonly StyledProperty<IndicatorStatusEnum> TopStatusProperty = AvaloniaProperty.Register<Circular3Indicator, IndicatorStatusEnum>(
        nameof(TopStatus));

    public IndicatorStatusEnum TopStatus
    {
        get => GetValue(TopStatusProperty);
        set => SetValue(TopStatusProperty, value);
    }
    
    
    #endregion
   
    #region Left props

    public static readonly StyledProperty<string> LeftTextProperty = AvaloniaProperty.Register<Circular3Indicator, string>(
        nameof(LeftText));

    public string LeftText
    {
        get => GetValue(LeftTextProperty);
        set => SetValue(LeftTextProperty, value);
    }

    public static readonly StyledProperty<string> LeftTitleProperty = AvaloniaProperty.Register<Circular3Indicator, string>(
        nameof(LeftTitle));

    public string LeftTitle
    {
        get => GetValue(LeftTitleProperty);
        set => SetValue(LeftTitleProperty, value);
    }

    public static readonly StyledProperty<IndicatorStatusEnum> LeftStatusProperty = AvaloniaProperty.Register<Circular3Indicator, IndicatorStatusEnum>(
        nameof(LeftStatus));

    public IndicatorStatusEnum LeftStatus
    {
        get => GetValue(LeftStatusProperty);
        set => SetValue(LeftStatusProperty, value);
    }
    
    #endregion
    
    #region Right props

    public static readonly StyledProperty<string> RightTextProperty = AvaloniaProperty.Register<Circular3Indicator, string>(
        nameof(RightText));

    public string RightText
    {
        get => GetValue(RightTextProperty);
        set => SetValue(RightTextProperty, value);
    }

    public static readonly StyledProperty<string> RightTitleProperty = AvaloniaProperty.Register<Circular3Indicator, string>(
        nameof(RightTitle));

    public string RightTitle
    {
        get => GetValue(RightTitleProperty);
        set => SetValue(RightTitleProperty, value);
    }

    public static readonly StyledProperty<IndicatorStatusEnum> RightStatusProperty = AvaloniaProperty.Register<Circular3Indicator, IndicatorStatusEnum>(
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