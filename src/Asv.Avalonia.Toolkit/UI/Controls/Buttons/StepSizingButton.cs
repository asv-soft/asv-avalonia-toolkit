using Avalonia;
using Avalonia.Controls;
using Avalonia.Layout;
using Avalonia.Media;

namespace Asv.Avalonia.Toolkit.UI.Controls.Buttons;

public class StepSizingButton : Button
{

    public static readonly StyledProperty<double> ButtonUnitWidthProperty =
        AvaloniaProperty.Register<StepSizingButton, double>(nameof(StepSizeWidth));

    public double StepSizeWidth
    {
        get => GetValue(ButtonUnitWidthProperty);
        set => SetValue(ButtonUnitWidthProperty, value);
    }
    
    public static readonly StyledProperty<double> ButtonUnitHeightProperty =
        AvaloniaProperty.Register<StepSizingButton, double>(nameof(StepSizeHeight));

    public double StepSizeHeight
    {
        get => GetValue(ButtonUnitHeightProperty);
        set => SetValue(ButtonUnitHeightProperty, value);
    }
    
    protected override void OnPropertyChanged(AvaloniaPropertyChangedEventArgs change)
    {
        base.OnPropertyChanged(change);
        
        if (change.Property == BoundsProperty)
        {
            if (StepSizeWidth != 0 )
            {
                if (Bounds.Width > StepSizeWidth)
                {
                    Width = StepSizeWidth * Math.Round(Bounds.Width / StepSizeWidth) - Margin.Right - Margin.Left;
                }
                else
                {
                    Width = StepSizeWidth -Margin.Right - Margin.Left;
                }
            }

            if (StepSizeHeight != 0)
            {
                if (Bounds.Height+15 > StepSizeHeight)
                {
                    Height = StepSizeHeight *  Math.Round(Bounds.Height / StepSizeHeight) - Margin.Bottom - Margin.Top;
                }
                else
                {
                    Height = StepSizeHeight - Margin.Bottom - Margin.Top;
                }
            }
        }
    }
}