using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Styling;

namespace Asv.Avalonia.Toolkit.Styling.Core;

/// <summary>
/// Theme manager for FluentAvalonia, managing various components of the Fluentv2 theme
/// like AccentColor, styles, and platform settings
/// </summary>
public partial class AsvAvaloniaToolkit : Styles, IResourceProvider
{
    /// <summary>
    /// Create new instance of <see cref="AsvAvaloniaToolkit"/>.
    /// </summary>
    public AsvAvaloniaToolkit()
    {
        Init();
    }
    
    private void Init()
    {
        AvaloniaXamlLoader.Load(this);
    }
}
