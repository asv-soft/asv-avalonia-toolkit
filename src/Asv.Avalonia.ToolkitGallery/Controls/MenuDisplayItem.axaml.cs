using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Metadata;
using Avalonia.Controls.Primitives;
using Avalonia.Media;

namespace Asv.Avalonia.ToolkitGallery.Controls;

public class MenuDisplayItem : TemplatedControl
{

    public static readonly StyledProperty<StreamGeometry> IconProperty = AvaloniaProperty.Register<MenuDisplayItem, StreamGeometry>(
        nameof(Icon));

    public StreamGeometry Icon
    {
        get => GetValue(IconProperty);
        set => SetValue(IconProperty, value);
    } 
    public static readonly StyledProperty<string> TextProperty = AvaloniaProperty.Register<MenuDisplayItem, string>(
        nameof(MenuItemText));

    public string MenuItemText
    {
        get => GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }
}