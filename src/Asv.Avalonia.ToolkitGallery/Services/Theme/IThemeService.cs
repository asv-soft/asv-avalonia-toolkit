using System.Collections.Generic;
using Asv.Avalonia.ToolkitGallery.Tools;
using Avalonia.Styling;
using ReactiveUI.Fody.Helpers;

namespace Asv.Avalonia.ToolkitGallery.Services.Theme
{
    public class ThemeItem(string id, string name, ThemeVariant theme) : DisposableReactiveObject
    {
        public string Id { get; set; } = id;
        public string Name { get; set; } = name;
        public ThemeVariant Theme { get; set; } = theme;
    }

    public interface IThemeService
    {
        IEnumerable<ThemeItem?>? Themes { get; }

        [Reactive]
        ThemeItem? CurrentTheme { get; set; }
    }
}
