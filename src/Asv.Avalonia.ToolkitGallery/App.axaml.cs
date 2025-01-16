using System;
using Asv.Avalonia.ToolkitGallery.Services.Theme;
using Asv.Avalonia.ToolkitGallery.ViewModels;
using Asv.Avalonia.ToolkitGallery.Views;
using Asv.Cfg;
using Asv.Cfg.Json;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Microsoft.Extensions.DependencyInjection;

namespace Asv.Avalonia.ToolkitGallery;

public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        var services = new ServiceCollection();

        var configuration = new JsonOneFileConfiguration("GalleryConfig.json", true, null);

        var themeSvc = new ThemeService(configuration);

        services.AddSingleton<IThemeService>(x =>
        {
            x.CreateScope();
            return themeSvc;
        });

        Services = services.BuildServiceProvider();

        switch (ApplicationLifetime)
        {
            case IClassicDesktopStyleApplicationLifetime desktop:
                desktop.MainWindow = new MainWindow { DataContext = new MainViewModel() };
                break;
            case ISingleViewApplicationLifetime singleViewPlatform:
                singleViewPlatform.MainView = new MainView { DataContext = new MainViewModel() };
                break;
        }

        base.OnFrameworkInitializationCompleted();
    }

    /// <summary>
    /// Current application instance.
    /// </summary>
    public new static App? Current => Application.Current as App;

    /// <summary>
    /// Gets the <see cref="IServiceProvider"/> instance to resolve application services.
    /// </summary>
    public IServiceProvider? Services { get; private set; }
}
