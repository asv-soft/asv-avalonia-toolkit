using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using Asv.Cfg;
using Asv.Common;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Media;
using Avalonia.Styling;
using FluentAvalonia.Styling;
using Asv.Avalonia.ToolkitGallery;
using Asv.Avalonia.ToolkitGallery.ViewModels;

namespace Asv.Drones.Gui.Core
{
   

   
    
    public class ThemeService : ViewModelBase,IThemeService
    {
        private readonly ThemeItem[] _themes = {
            new(FluentAvaloniaTheme.DarkModeString, RS.ThemeService_Themes_Dark, ThemeVariant.Dark),
            new(FluentAvaloniaTheme.LightModeString, RS.ThemeService_Themes_Light, ThemeVariant.Light),
        };

        [ImportingConstructor]
        public ThemeService():base($"{MainViewModel.Uri}.theme-service")
        {
            Application.Current.RequestedThemeVariant = ThemeVariant.Default;
            var selectedTheme = default(ThemeItem);
            selectedTheme ??= _themes.First();
            CurrentTheme = new RxValue<ThemeItem>(selectedTheme).DisposeItWith(Disposable);
            CurrentTheme.Subscribe(SetTheme).DisposeItWith(Disposable);
        }

        public IEnumerable<ThemeItem> Themes =>_themes;
        public IRxEditableValue<ThemeItem> CurrentTheme { get; }

        private void SetTheme(ThemeItem theme)
        {
            if (theme == null) throw new ArgumentNullException(nameof(theme));
            Application.Current.RequestedThemeVariant = theme.Theme;
        }
    }
}