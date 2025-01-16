using System;
using System.Collections.Generic;
using System.Linq;
using Asv.Cfg;
using Asv.Common;
using Avalonia;
using Avalonia.Styling;
using FluentAvalonia.Styling;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace Asv.Avalonia.ToolkitGallery.Services.Theme;

public class ThemeServiceConfig
{
    public ThemeVariant SelectedTheme { get; set; } = ThemeVariant.Dark;
}

public class ThemeService : ServiceWithConfigBase<ThemeServiceConfig>, IThemeService
{
    public ThemeService(IConfiguration config)
        : base(config)
    {
        var selectedTheme = Themes?.First(theme =>
            theme?.Theme == InternalGetConfig<ThemeVariant>(cfg => cfg.SelectedTheme)
        );

        this.WhenAnyValue(svc => svc.CurrentTheme)
            .WhereNotNull()
            .Subscribe(SetTheme)
            .DisposeItWith(Disposable);

        CurrentTheme = selectedTheme;
    }

    public IEnumerable<ThemeItem?>? Themes =>
        [
            new ThemeItem(
                FluentAvaloniaTheme.DarkModeString,
                RS.ThemeService_Themes_Dark,
                ThemeVariant.Dark
            ),
            new ThemeItem(
                FluentAvaloniaTheme.LightModeString,
                RS.ThemeService_Themes_Light,
                ThemeVariant.Light
            ),
        ];

    [Reactive]
    public ThemeItem? CurrentTheme { get; set; }

    private void SetTheme(ThemeItem? theme)
    {
        ArgumentNullException.ThrowIfNull(theme);
        if (Application.Current == null)
            throw new NullReferenceException(nameof(Application.Current));

        Application.Current.RequestedThemeVariant = theme.Theme;
        InternalSaveConfig(cfg =>
        {
            cfg.SelectedTheme = theme.Theme;
        });
    }
}
