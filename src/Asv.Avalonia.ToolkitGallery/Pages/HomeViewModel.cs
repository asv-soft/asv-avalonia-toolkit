using System;
using System.Reactive.Linq;
using Asv.Avalonia.Toolkit;
using Asv.Avalonia.ToolkitGallery.Models;
using Asv.Avalonia.ToolkitGallery.ViewModels;
using Avalonia;
using Material.Icons;

namespace Asv.Avalonia.ToolkitGallery.Pages;

public class HomeViewModel: ViewModelBase,IShellPage
{
    public HomeViewModel():base(Uri)
    {
       
    }
    public MaterialIconKind Icon { get; }
    public string Title { get; }
    public const string UriString = $"{MainViewModel.UriString}.home-page";
    public static readonly Uri Uri = new(UriString);
}