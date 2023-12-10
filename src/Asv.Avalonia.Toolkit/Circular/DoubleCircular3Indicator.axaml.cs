using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Metadata;
using Avalonia.Media;

namespace Asv.Avalonia.Toolkit;

[PseudoClasses(RightBottomRightCritical, RightBottomRightWarning, RightBottomRightSuccess, RightBottomRightUnknown,
    RightBottomLeftCritical, RightBottomLeftWarning, RightBottomLeftSuccess, RightBottomLeftUnknown,
    RightTopCritical, RightTopWarning, RightTopSuccess, RightTopUnknown,
    LeftBottomRightCritical, LeftBottomRightWarning, LeftBottomRightSuccess, LeftBottomRightUnknown,
    LeftBottomLeftCritical, LeftBottomLeftWarning, LeftBottomLeftSuccess, LeftBottomLeftUnknown,
    LeftTopCritical, LeftTopWarning, LeftTopSuccess, LeftTopUnknown, BottomStatusCritical, BottomStatusWarning, BottomStatusSuccess, BottomStatusUnknown)]
public class DoubleCircular3Indicator : IndicatorBase
{
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
    public const string LeftTopCritical = ":lt-critical";
    public const string LeftTopWarning = ":lt-warning";
    public const string LeftTopSuccess = ":lt-success";
    public const string LeftTopUnknown = ":lt-unknown";
    
    public const string BottomStatusCritical = ":bottom-critical";
    public const string BottomStatusWarning = ":bottom-warning";
    public const string BottomStatusSuccess = ":bottom-success";
    public const string BottomStatusUnknown = ":bottom-unknown";
    
    #endregion

    #region RightBottomRight

    public static readonly StyledProperty<string> RightBottomRightTitleProperty = AvaloniaProperty.Register<DoubleCircular3Indicator, string>(
        nameof(RightBottomRightTitle));

    public string RightBottomRightTitle
    {
        get => GetValue(RightBottomRightTitleProperty);
        set => SetValue(RightBottomRightTitleProperty, value);
    }

    public static readonly StyledProperty<string> RightBottomRightTextProperty = AvaloniaProperty.Register<DoubleCircular3Indicator, string>(
        nameof(RightBottomRightText));

    public string RightBottomRightText
    {
        get => GetValue(RightBottomRightTextProperty);
        set => SetValue(RightBottomRightTextProperty, value);
    }

    public static readonly StyledProperty<IndicatorStatusEnum> RightBottomRightStatusProperty = AvaloniaProperty.Register<DoubleCircular3Indicator, IndicatorStatusEnum>(
        nameof(RightBottomRightStatus));

    public IndicatorStatusEnum RightBottomRightStatus
    {
        get => GetValue(RightBottomRightStatusProperty);
        set => SetValue(RightBottomRightStatusProperty, value);
    }
    
    #endregion

    #region RightBottomLeft

    public static readonly StyledProperty<string> RightBottomLeftTitleProperty = AvaloniaProperty.Register<DoubleCircular3Indicator, string>(
        nameof(RightBottomLeftTitle));

    public string RightBottomLeftTitle
    {
        get => GetValue(RightBottomLeftTitleProperty);
        set => SetValue(RightBottomLeftTitleProperty, value);
    }

    public static readonly StyledProperty<string> RightBottomLeftTextProperty = AvaloniaProperty.Register<DoubleCircular3Indicator, string>(
        nameof(RightBottomLeftText));

    public string RightBottomLeftText
    {
        get => GetValue(RightBottomLeftTextProperty);
        set => SetValue(RightBottomLeftTextProperty, value);
    }
    
    public static readonly StyledProperty<IndicatorStatusEnum> RightBottomLeftStatusProperty = AvaloniaProperty.Register<DoubleCircular3Indicator, IndicatorStatusEnum>(
        nameof(RightBottomLeftStatus));

    public IndicatorStatusEnum RightBottomLeftStatus
    {
        get => GetValue(RightBottomLeftStatusProperty);
        set => SetValue(RightBottomLeftStatusProperty, value);
    }

    #endregion

    #region RightTop

    public static readonly StyledProperty<string> RightTopTitleProperty = AvaloniaProperty.Register<DoubleCircular3Indicator, string>(
        nameof(RightTopTitle));

    public string RightTopTitle
    {
        get => GetValue(RightTopTitleProperty);
        set => SetValue(RightTopTitleProperty, value);
    }

    public static readonly StyledProperty<string> RightTopTextProperty = AvaloniaProperty.Register<DoubleCircular3Indicator, string>(
        nameof(RightTopText));

    public string RightTopText
    {
        get => GetValue(RightTopTextProperty);
        set => SetValue(RightTopTextProperty, value);
    }
    
    public static readonly StyledProperty<IndicatorStatusEnum> RightTopStatusProperty = AvaloniaProperty.Register<DoubleCircular3Indicator, IndicatorStatusEnum>(
        nameof(RightTopStatus));

    public IndicatorStatusEnum RightTopStatus
    {
        get=> GetValue(RightTopStatusProperty);
        set => SetValue(RightTopStatusProperty, value);
    }

    #endregion

    #region LeftBottomRight

    public static readonly StyledProperty<string> LeftBottomRightTitleProperty = AvaloniaProperty.Register<DoubleCircular3Indicator, string>(
        nameof(LeftBottomRightTitle));

    public string LeftBottomRightTitle
    {
        get => GetValue(LeftBottomRightTitleProperty);
        set => SetValue(LeftBottomRightTitleProperty, value);
    }

    public static readonly StyledProperty<string> LeftBottomRightTextProperty = AvaloniaProperty.Register<DoubleCircular3Indicator, string>(
        nameof(LeftBottomRightText));

    public string LeftBottomRightText
    {
        get => GetValue(LeftBottomRightTextProperty);
        set => SetValue(LeftBottomRightTextProperty, value);
    }
    
    public static readonly StyledProperty<IndicatorStatusEnum> LeftBottomRightStatusProperty = AvaloniaProperty.Register<DoubleCircular3Indicator, IndicatorStatusEnum>(
        nameof(LeftBottomRightStatus));

    public IndicatorStatusEnum LeftBottomRightStatus
    {
        get=> GetValue(LeftBottomRightStatusProperty);
        set => SetValue(LeftBottomRightStatusProperty, value);
    }

    #endregion

    #region LeftBottomLeft

    public static readonly StyledProperty<string> LeftBottomLeftTitleProperty = AvaloniaProperty.Register<DoubleCircular3Indicator, string>(
        nameof(LeftBottomLeftTitle));

    public string LeftBottomLeftTitle
    {
        get => GetValue(LeftBottomLeftTitleProperty);
        set => SetValue(LeftBottomLeftTitleProperty, value);
    }

    public static readonly StyledProperty<string> LeftBottomLeftTextProperty = AvaloniaProperty.Register<DoubleCircular3Indicator, string>(
        nameof(LeftBottomLeftText));

    public string LeftBottomLeftText
    {
        get => GetValue(LeftBottomLeftTextProperty);
        set => SetValue(LeftBottomLeftTextProperty, value);
    }

    public static readonly StyledProperty<IndicatorStatusEnum> LeftBottomLeftStatusProperty = AvaloniaProperty.Register<DoubleCircular3Indicator, IndicatorStatusEnum>(
        nameof(LeftBottomLeftStatus));
    
    public IndicatorStatusEnum LeftBottomLeftStatus
    {
        get=> GetValue(LeftBottomLeftStatusProperty);
        set => SetValue(LeftBottomLeftStatusProperty, value);
    }
    

    #endregion

    #region LeftTop

    public static readonly StyledProperty<string> LeftTopTitleProperty = AvaloniaProperty.Register<DoubleCircular3Indicator, string>(
        nameof(LeftTopTitle));

    public string LeftTopTitle
    {
        get => GetValue(LeftTopTitleProperty);
        set => SetValue(LeftTopTitleProperty, value);
    }

    public static readonly StyledProperty<string> LeftTopTextProperty = AvaloniaProperty.Register<DoubleCircular3Indicator, string>(
        nameof(LeftTopText));

    public string LeftTopText
    {
        get => GetValue(LeftTopTextProperty);
        set => SetValue(LeftTopTextProperty, value);
    }
    
    public static readonly StyledProperty<IndicatorStatusEnum> LeftTopStatusProperty = AvaloniaProperty.Register<DoubleCircular3Indicator, IndicatorStatusEnum>(
        nameof(LeftTopStatus));

    public IndicatorStatusEnum LeftTopStatus
    {
        get=> GetValue(LeftTopStatusProperty);
        set => SetValue(LeftTopStatusProperty, value);
    }

    #endregion

    #region BottomStatus
    
    public static readonly StyledProperty<string> BottomStatusTextProperty = AvaloniaProperty.Register<DoubleCircular3Indicator, string>(
        nameof(BottomStatusText));

    public string BottomStatusText
    {
        get => GetValue(BottomStatusTextProperty);
        set => SetValue(BottomStatusTextProperty, value);
    }
    
    public static readonly StyledProperty<IndicatorStatusEnum> BottomStatusProperty = AvaloniaProperty.Register<DoubleCircular3Indicator, IndicatorStatusEnum>(
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