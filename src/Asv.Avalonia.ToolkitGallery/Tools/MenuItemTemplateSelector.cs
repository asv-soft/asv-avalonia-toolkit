using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Avalonia.Data;
using FluentAvalonia.UI.Controls;
using Asv.Avalonia.ToolkitGallery.Models;
using Asv.Avalonia.ToolkitGallery.ViewModels;

namespace Asv.Avalonia.ToolkitGallery.Tools;

public class MenuItemTemplateSelector : DataTemplateSelector
    {
        private static readonly FuncDataTemplate<IShellMenuItem> SimpleItem;

        static MenuItemTemplateSelector()
        {
            SimpleItem = new FuncDataTemplate<IShellMenuItem>((value, namescope) =>
                new NavigationViewItem
                {
                    //[!NavigationViewItem.InfoBadgeProperty] = new Binding(nameof(IShellMenuItem.InfoBadge)),
                    [!NavigationViewItem.IconSourceProperty] = new Binding(nameof(IShellMenuItem.Icon)),
                    [!ContentControl.ContentProperty] = new Binding(nameof(IShellMenuItem.Name)),
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