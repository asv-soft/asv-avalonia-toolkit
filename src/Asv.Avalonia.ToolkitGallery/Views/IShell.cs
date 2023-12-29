using Asv.Avalonia.ToolkitGallery.Models;
using Asv.Avalonia.ToolkitGallery.ViewModels;

namespace Asv.Avalonia.ToolkitGallery.Views
{
    /// <summary>
    /// Main view interface
    /// </summary>
    public interface IShell : IViewModel
    {
        IShellPage? CurrentPage { get; set; }
    }
}