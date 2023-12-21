using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Asv.Avalonia.ToolkitGallery.Pages;

public partial class MeasureUnits : UserControl
{
    public MeasureUnits()
    {
        InitializeComponent();
        
    }
    public Point PointDoubleLeftTopLineEndPoint = new Point(100, 2.5);
    public Point PointDoubleRightTopLineEndPoint = new Point(100, 2.5);
}