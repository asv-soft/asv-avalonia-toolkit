using System;
using Asv.Avalonia.ToolkitGallery.Tools;
using Asv.Avalonia.ToolkitGallery.ViewModels.Pages;
using ReactiveUI.Fody.Helpers;

namespace Asv.Avalonia.ToolkitGallery.ViewModels.MenuItems;

public abstract class MenuItemBase : DisposableReactiveObject, IShellMenuItem
{
    public abstract string Name { get; }
    public abstract string Icon { get; }

    public virtual IShellPage CreatePage()
    {
        throw new NotImplementedException();
    }
}
