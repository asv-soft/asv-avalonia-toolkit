namespace Asv.Avalonia.ToolkitGallery.Views
{
    /// <summary>
    /// Main view interface
    /// </summary>
    public interface IShell
    {
        IShell? CurrentPage { get; set; }
    }
}