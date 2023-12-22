using System;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.Reactive.Disposables;
using System.Threading;
using System.Threading.Tasks;
using Asv.Avalonia.ToolkitGallery.Models;
using Asv.Avalonia.ToolkitGallery.Pages;
using Asv.Avalonia.ToolkitGallery.ViewModels.MenuItems;
using Asv.Avalonia.ToolkitGallery.Views;
using Avalonia.Controls;
using DynamicData.Binding;
using FluentAvalonia.UI.Controls;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Asv.Cfg;
using Asv.Common;
using Avalonia.Platform.Storage;

namespace Asv.Avalonia.ToolkitGallery.ViewModels;
[Export(typeof(IShell))]
[PartCreationPolicy(CreationPolicy.Shared)]
public class MainViewModel : ViewModelBase,IShell
{
    private object? _previousSuccessSelectedMenu;
    //private readonly IShellMenuForSelectedPage _menuForSelectedPage;

    public const string UriString = $"asv:main";
    public static readonly Uri Uri = new(UriString);

    
    [ImportingConstructor]
    public MainViewModel():base(Uri)
    {
        this.WhenAnyValue(vm => vm.Items)
            .Subscribe();
        
         this.WhenValueChanged(x => x.SelectedMenu)
             .Subscribe(OnSelectionChanged)
             .DisposeItWith(Disposable);
        Items = new ObservableCollection<IShellMenuItem> 
        {
            new HomePageMenuItem(),
            new MeasurePageMenuItems(),
            new RoutePageMenuItem()
         };
    }
    private void OnSelectionChanged(IShellMenuItem menuItem)
    { 
       if(menuItem == null ) return;

       if (menuItem is HomePageMenuItem)
       {
           CurrentPage = new HomeViewModel();
       }
       if (menuItem is MeasurePageMenuItems)
       {
           CurrentPage = new MeasureUnitsViewModel();
       }
       if (menuItem is RoutePageMenuItem)
       {
           CurrentPage = new RouteIndicatorsViewModel();
       }
    }
    [Reactive]
    public ObservableCollection<IShellMenuItem> Items { get; set; }
    [Reactive] 
    public IShellMenuItem SelectedMenu { get; set; } = null!;

    [Reactive]
    public IShellPage? CurrentPage { get; set; }
}
