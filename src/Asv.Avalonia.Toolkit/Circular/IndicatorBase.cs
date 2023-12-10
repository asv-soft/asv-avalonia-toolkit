using Avalonia;
using Avalonia.Controls.Primitives;

namespace Asv.Avalonia.Toolkit;




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