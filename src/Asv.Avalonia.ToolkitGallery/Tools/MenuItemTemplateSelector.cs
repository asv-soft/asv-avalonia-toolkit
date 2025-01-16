using Asv.Avalonia.ToolkitGallery.ViewModels;
using Asv.Avalonia.ToolkitGallery.ViewModels.MenuItems;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Avalonia.Data;
using FluentAvalonia.UI.Controls;

namespace Asv.Avalonia.ToolkitGallery.Tools;

public class MenuItemTemplateSelector : DataTemplateSelector
{
    private readonly FuncDataTemplate<IShellMenuItem> _item = new(
        (_, _) =>
            new NavigationViewItem
            {
                [!NavigationViewItem.IconSourceProperty] = new Binding(nameof(IShellMenuItem.Icon)),
                [!ContentControl.ContentProperty] = new Binding(nameof(IShellMenuItem.Name)),
                SelectsOnInvoked = true,
            }
    );

    public static readonly MenuItemTemplateSelector Instance = new();

    protected override IDataTemplate SelectTemplateCore(object item) => _item;

    protected override IDataTemplate SelectTemplateCore(object item, Control container) =>
        SelectTemplateCore(item);
}
