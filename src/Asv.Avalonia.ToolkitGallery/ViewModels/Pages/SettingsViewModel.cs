using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using Asv.Avalonia.ToolkitGallery.Services.Theme;
using Asv.Avalonia.ToolkitGallery.Tools;
using Asv.Common;
using Microsoft.Extensions.DependencyInjection;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace Asv.Avalonia.ToolkitGallery.ViewModels.Pages;

public class SettingsViewModel : DisposableReactiveObject, IShellPage
{
    private readonly IThemeService? _themeSvc;

    public SettingsViewModel()
    {
        _themeSvc ??= App.Current?.Services?.GetService<IThemeService>();

        Themes = _themeSvc?.Themes;

        Theme = Themes?.First(theme => theme?.Theme == _themeSvc?.CurrentTheme?.Theme);

        this.WhenAnyValue(settings => settings.Theme)
            .Skip(1)
            .Subscribe(theme =>
            {
                if (_themeSvc != null)
                    _themeSvc.CurrentTheme = theme;
            })
            .DisposeItWith(Disposable);
    }

    [Reactive]
    public IEnumerable<ThemeItem?>? Themes { get; set; }

    [Reactive]
    public ThemeItem? Theme { get; set; }
}
