using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Metadata;
using Avalonia.Controls.Primitives;

namespace Asv.Avalonia.Toolkit;

[PseudoClasses(SharedConst.LeftCritical, SharedConst.LeftWarning, SharedConst.LeftSuccess, SharedConst.LeftUnknown,
    SharedConst.TopCritical, SharedConst.TopWarning, SharedConst.TopSuccess, SharedConst.TopUnknown,
    SharedConst.RightCritical, SharedConst.RightWarning, SharedConst.RightSuccess, SharedConst.RightUnknown)]
public class Circular3Indicator : IndicatorBase
{
    private double _topProgressAngle;
    
    public Circular3Indicator()
    {
        
    }

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
            PseudoClasses.Set(":top-critical", value == IndicatorStatusEnum.Critical);
            PseudoClasses.Set(":top-warning", value == IndicatorStatusEnum.Warning);
            PseudoClasses.Set(":top-success", value == IndicatorStatusEnum.Success);
            PseudoClasses.Set(":top-unknown", value == IndicatorStatusEnum.Unknown);
        }
        if (change.Property == LeftStatusProperty)
        {
            var value = (IndicatorStatusEnum)change.NewValue!;
            PseudoClasses.Set(":left-critical", value == IndicatorStatusEnum.Critical);
            PseudoClasses.Set(":left-warning", value == IndicatorStatusEnum.Warning);
            PseudoClasses.Set(":left-success", value == IndicatorStatusEnum.Success);
            PseudoClasses.Set(":left-unknown", value == IndicatorStatusEnum.Unknown);
        }
        if (change.Property == RightStatusProperty)
        {
            var value = (IndicatorStatusEnum)change.NewValue!;
            PseudoClasses.Set(":right-critical", value == IndicatorStatusEnum.Critical);
            PseudoClasses.Set(":right-warning", value == IndicatorStatusEnum.Warning);
            PseudoClasses.Set(":right-success", value == IndicatorStatusEnum.Success);
            PseudoClasses.Set(":right-unknown", value == IndicatorStatusEnum.Unknown);
        }
    }
    
    
}