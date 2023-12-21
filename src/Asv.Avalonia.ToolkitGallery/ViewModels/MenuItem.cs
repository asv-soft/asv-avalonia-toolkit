using System;
using Asv.Avalonia.ToolkitGallery.Models;
using ReactiveUI.Fody.Helpers;

namespace Asv.Avalonia.ToolkitGallery.ViewModels;

public class MenuItem : IMenuItem
{
    
    [Reactive]
    public string Name { get; set; }
    // [Reactive]
    // public Uri NavigateTo { get; set; }
    [Reactive]
    public string Icon { get; set; }
   
    
    
}
