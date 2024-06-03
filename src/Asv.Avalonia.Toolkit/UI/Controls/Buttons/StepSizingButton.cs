using Avalonia;
using Avalonia.Controls;
using Avalonia.Layout;
using Avalonia.Media;

namespace Asv.Avalonia.Toolkit.UI.Controls.Buttons;

public class StepSizingButton : Button
{
    public static readonly StyledProperty<double> ButtonUnitWidthProperty =
        AvaloniaProperty.Register<StepSizingButton, double>(nameof(StepSizeWidth));

    /// <summary>
    /// Get or Set step of width for control
    /// </summary>
    public double StepSizeWidth
    {
        get => GetValue(ButtonUnitWidthProperty);
        set => SetValue(ButtonUnitWidthProperty, value);
    }

    public static readonly StyledProperty<double> ButtonUnitHeightProperty =
        AvaloniaProperty.Register<StepSizingButton, double>(nameof(StepSizeHeight));

    /// <summary>
    /// Get or Set step of height for control
    /// </summary>
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
            MinWidth = StepSizeWidth;
            if (StepSizeWidth != 0)
            {
                if (Bounds.Width > StepSizeWidth)
                {
                    var increment = (int)Math.Round(Bounds.Width / StepSizeWidth);
                    Width = StepSizeWidth * increment + (Margin.Right + Margin.Left) * (increment - 1);
                    if (Width < Bounds.Width) increment++;
                    Width = StepSizeWidth * increment + (Margin.Right + Margin.Left) * (increment - 1);
                }
                else
                {
                    Width = StepSizeWidth;
                }
            }
            if (StepSizeHeight == 0) return;
            if (Bounds.Height > StepSizeHeight)
            {
                var increment = (int)Math.Round(Bounds.Height / StepSizeHeight);
                Height = StepSizeHeight * increment + (Margin.Top + Margin.Bottom) * (increment - 1);
            }
            else
            {
                Height = StepSizeHeight;
            }
        }
    }
}