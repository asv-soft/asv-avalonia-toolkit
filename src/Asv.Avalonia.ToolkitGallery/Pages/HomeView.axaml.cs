using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using ReactiveUI.Fody.Helpers;

namespace Asv.Avalonia.ToolkitGallery.Pages;

public partial class HomeView : UserControl
{
    public HomeView()
    {
        InitializeComponent();
        StartPoint = new Point(100, 2.5);
    }

    [Reactive]
    public Point StartPoint { get; set; }

}