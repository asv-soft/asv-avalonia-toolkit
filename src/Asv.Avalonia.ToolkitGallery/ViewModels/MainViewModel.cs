using System;
using System.Collections.ObjectModel;
using Asv.Avalonia.ToolkitGallery.Models;
using Asv.Avalonia.ToolkitGallery.ViewModels.MenuItems;
using Asv.Avalonia.ToolkitGallery.ViewModels.Pages;
using DynamicData.Binding;
using ReactiveUI.Fody.Helpers;
using Asv.Common;

namespace Asv.Avalonia.ToolkitGallery.ViewModels;

public class MainViewModel : DisposableReactiveObject
{
    public MainViewModel()
    {
        this.WhenValueChanged(x => x.SelectedMenu)
            .Subscribe(OnSelectionChanged)
            .DisposeItWith(Disposable);
    }
    
    private void OnSelectionChanged(IShellMenuItem? menuItem) => CurrentPage = menuItem?.CreatePage();
    
    public ObservableCollection<IShellMenuItem> Items =>
    [
        new HomePageMenuItemBase(),
        new MeasurePageMenuItemsBase(),
        new RoutePageMenuItemBase(),
        new DateTimeMenuItemBase(),
        new SettingsMenuItemBase()
    ];
    
    [Reactive] 
    public IShellMenuItem? SelectedMenu { get; set; }

    [Reactive]
    public IShellPage? CurrentPage { get; set; }
}
