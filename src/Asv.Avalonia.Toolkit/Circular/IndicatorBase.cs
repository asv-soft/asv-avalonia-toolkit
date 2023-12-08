using Avalonia;
using Avalonia.Controls.Primitives;

namespace Asv.Avalonia.Toolkit;

public static class SharedConst
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
}


public class IndicatorBase : TemplatedControl
{
    public static readonly StyledProperty<string> TitleProperty = AvaloniaProperty.Register<IndicatorBase, string>(
        nameof(Title));

    public string Title
    {
        get => GetValue(TitleProperty);
        set => SetValue(TitleProperty, value);
    }
}