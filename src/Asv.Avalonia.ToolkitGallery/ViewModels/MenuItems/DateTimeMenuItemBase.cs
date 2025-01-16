using Asv.Avalonia.ToolkitGallery.ViewModels.Pages;

namespace Asv.Avalonia.ToolkitGallery.ViewModels.MenuItems;

public class DateTimeMenuItemBase : MenuItemBase
{
    public DateTimeMenuItemBase()
    {
        Name = "Date/Time Controls";
        Icon =
            "M11 6.5a.5.5 0 0 1 .5-.5h1a.5.5 0 0 1 .5.5v1a.5.5 0 0 1-.5.5h-1a.5.5 0 0 1-.5-.5z"
            + "M3.5 0a.5.5 0 0 1 .5.5V1h8V.5a.5.5 0 0 1 1 0V1h1a2 2 0 0 1 2 2v11a2 2 0 0 1-2 2H2a2 2 0 0 1-2-2V3a2 2 0 0 1 2-2h1V.5a.5.5 0 0 1 .5-.5M1 4v10a1 1 0 0 0 1 1h12a1 1 0 0 0 1-1V4z";
    }

    public override string Name { get; }
    public override string Icon { get; }

    public override IShellPage CreatePage()
    {
        return new DateTimeViewModel();
    }
}
