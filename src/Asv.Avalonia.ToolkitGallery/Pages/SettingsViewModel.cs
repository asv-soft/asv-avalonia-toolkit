using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Reactive.Linq;
using Asv.Avalonia.ToolkitGallery.Models;
using Asv.Avalonia.ToolkitGallery.ViewModels;
using Asv.Cfg;
using Asv.Common;
using Asv.Drones.Gui.Core;
using Avalonia;
using Avalonia.Styling;
using FluentAvalonia.Styling;
using Material.Icons;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace Asv.Avalonia.ToolkitGallery.Pages;

public class SettingsViewModel: ViewModelBase, IShellPage
{
    private IThemeService _themeService;
    public MaterialIconKind Icon { get; }
    public string Title { get; }
    public const string UriString = $"{MainViewModel.UriString}.settings-page";
    public static readonly Uri Uri = new(UriString);
    
    [ImportingConstructor]
    public SettingsViewModel(): base(Uri)
    {
        _themeService = new ThemeService();
        // _themeService.CurrentTheme.Subscribe(_ => SelectedTheme = _).DisposeItWith(Disposable);
        this.WhenAnyValue(vm => vm.SelectedTheme)
            .Skip(1) // skip first because it is set in constructor
            .Subscribe(v =>
            {
                Application.Current.RequestedThemeVariant = v.Theme;
            })
            .DisposeItWith(Disposable); 
    }
    private readonly ThemeItem[] _themes = {
        new(FluentAvaloniaTheme.DarkModeString, RS.ThemeService_Themes_Dark, ThemeVariant.Dark),
        new(FluentAvaloniaTheme.LightModeString, RS.ThemeService_Themes_Light, ThemeVariant.Light),
    };
    
    public IEnumerable<ThemeItem> AppThemes => _themes;
    
    [Reactive]
    public ThemeItem SelectedTheme { get; set; }
}