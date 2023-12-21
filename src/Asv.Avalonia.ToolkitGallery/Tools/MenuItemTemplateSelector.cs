using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Avalonia.Data;
using FluentAvalonia.UI.Controls;
using Asv.Avalonia.ToolkitGallery.Models;

namespace Asv.Avalonia.ToolkitGallery.Tools;

public class MenuItemTemplateSelector : DataTemplateSelector
    {
        private static readonly FuncDataTemplate<IMenuItem> SimpleItem;

        static MenuItemTemplateSelector()
        {
            SimpleItem = new FuncDataTemplate<IMenuItem>((value, namescope) =>
                new NavigationViewItem
                {
                    //[!NavigationViewItem.InfoBadgeProperty] = new Binding(nameof(IShellMenuItem.InfoBadge)),
                    [!NavigationViewItem.IconSourceProperty] = new Binding(nameof(IMenuItem.Icon)),
                    [!ContentControl.ContentProperty] = new Binding(nameof(IMenuItem.Name)),
                    //[!NavigationViewItem.MenuItemsSourceProperty] = new Binding(nameof(IShellMenuItem.Items)),
                    //[!ListBoxItem.IsSelectedProperty] = new Binding(nameof(IShellMenuItem.IsSelected)),
                    //[!Visual.IsVisibleProperty] = new Binding(nameof(IShellMenuItem.IsVisible), BindingMode.TwoWay),
                    SelectsOnInvoked = true,
                    /*[!NavigationViewItem.SelectsOnInvokedProperty] =  new Binding(nameof(IShellMenuItem.NavigateTo))
                    {
                        Converter = ObjectConverters.IsNotNull
                    }*/
                });
        }

        public static readonly MenuItemTemplateSelector Instance = new();

        protected override IDataTemplate SelectTemplateCore(object item)
        {
            return SimpleItem;
        }

        protected override IDataTemplate SelectTemplateCore(object item, Control container)
        {
            return SelectTemplateCore(item);
        }
    }