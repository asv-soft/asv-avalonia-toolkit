using Asv.Avalonia.ToolkitGallery.ViewModels.Pages;

namespace Asv.Avalonia.ToolkitGallery.ViewModels.MenuItems
{
    public interface IShellMenuItem
    {
        string Icon { get; }
        string Name { get; }
        
        IShellPage CreatePage();
    }
}
