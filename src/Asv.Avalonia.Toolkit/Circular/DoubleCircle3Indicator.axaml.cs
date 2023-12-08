using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;

namespace Asv.Avalonia.Toolkit;

public class DoubleCircle3Indicator : IndicatorBase
{
    public static readonly StyledProperty<string> RightBottomRightTitleProperty = AvaloniaProperty.Register<DoubleCircle3Indicator, string>(
        nameof(RightBottomRightTitle));

    public string RightBottomRightTitle
    {
        get => GetValue(RightBottomRightTitleProperty);
        set => SetValue(RightBottomRightTitleProperty, value);
    }

    public static readonly StyledProperty<string> RightBottomRightTextProperty = AvaloniaProperty.Register<DoubleCircle3Indicator, string>(
        nameof(RightBottomRightText));

    public string RightBottomRightText
    {
        get => GetValue(RightBottomRightTextProperty);
        set => SetValue(RightBottomRightTextProperty, value);
    }

    public static readonly StyledProperty<string> RightBottomLeftTitleProperty = AvaloniaProperty.Register<DoubleCircle3Indicator, string>(
        nameof(RightBottomLeftTitle));

    public string RightBottomLeftTitle
    {
        get => GetValue(RightBottomLeftTitleProperty);
        set => SetValue(RightBottomLeftTitleProperty, value);
    }

    public static readonly StyledProperty<string> RightBottomLeftTextProperty = AvaloniaProperty.Register<DoubleCircle3Indicator, string>(
        nameof(RightBottomLeftText));

    public string RightBottomLeftText
    {
        get => GetValue(RightBottomLeftTextProperty);
        set => SetValue(RightBottomLeftTextProperty, value);
    }

    public static readonly StyledProperty<string> RightTopTitleProperty = AvaloniaProperty.Register<DoubleCircle3Indicator, string>(
        nameof(RightTopTitle));

    public string RightTopTitle
    {
        get => GetValue(RightTopTitleProperty);
        set => SetValue(RightTopTitleProperty, value);
    }

    public static readonly StyledProperty<string> RightTopTextProperty = AvaloniaProperty.Register<DoubleCircle3Indicator, string>(
        nameof(RightTopText));

    public string RightTopText
    {
        get => GetValue(RightTopTextProperty);
        set => SetValue(RightTopTextProperty, value);
    }

    public static readonly StyledProperty<string> LeftBottomRightTitleProperty = AvaloniaProperty.Register<DoubleCircle3Indicator, string>(
        nameof(LeftBottomRightTitle));

    public string LeftBottomRightTitle
    {
        get => GetValue(LeftBottomRightTitleProperty);
        set => SetValue(LeftBottomRightTitleProperty, value);
    }

    public static readonly StyledProperty<string> LeftBottomRightTextProperty = AvaloniaProperty.Register<DoubleCircle3Indicator, string>(
        nameof(LeftBottomRightText));

    public string LeftBottomRightText
    {
        get => GetValue(LeftBottomRightTextProperty);
        set => SetValue(LeftBottomRightTextProperty, value);
    }

    public static readonly StyledProperty<string> LeftBottomLeftTitleProperty = AvaloniaProperty.Register<DoubleCircle3Indicator, string>(
        nameof(LeftBottomLeftTitle));

    public string LeftBottomLeftTitle
    {
        get => GetValue(LeftBottomLeftTitleProperty);
        set => SetValue(LeftBottomLeftTitleProperty, value);
    }

    public static readonly StyledProperty<string> LeftBottomLeftTextProperty = AvaloniaProperty.Register<DoubleCircle3Indicator, string>(
        nameof(LeftBottomLeftText));

    public string LeftBottomLeftText
    {
        get => GetValue(LeftBottomLeftTextProperty);
        set => SetValue(LeftBottomLeftTextProperty, value);
    }

    public static readonly StyledProperty<string> LeftTopTitleProperty = AvaloniaProperty.Register<DoubleCircle3Indicator, string>(
        nameof(LeftTopTitle));

    public string LeftTopTitle
    {
        get => GetValue(LeftTopTitleProperty);
        set => SetValue(LeftTopTitleProperty, value);
    }

    public static readonly StyledProperty<string> LeftTopTextProperty = AvaloniaProperty.Register<DoubleCircle3Indicator, string>(
        nameof(LeftTopText));

    public string LeftTopText
    {
        get => GetValue(LeftTopTextProperty);
        set => SetValue(LeftTopTextProperty, value);
    }

    public static readonly StyledProperty<string> BottomStatusTextProperty = AvaloniaProperty.Register<DoubleCircle3Indicator, string>(
        nameof(BottomStatusText));

    public string BottomStatusText
    {
        get => GetValue(BottomStatusTextProperty);
        set => SetValue(BottomStatusTextProperty, value);
    }
    
    public static readonly StyledProperty<IndicatorStatusEnum> BottomStatusProperty = AvaloniaProperty.Register<DoubleCircle3Indicator, IndicatorStatusEnum>(
        nameof(BottomStatus));
    
    public IndicatorStatusEnum BottomStatus
    {
        get => GetValue(BottomStatusProperty);
        set => SetValue(BottomStatusProperty, value);
    }
    
}