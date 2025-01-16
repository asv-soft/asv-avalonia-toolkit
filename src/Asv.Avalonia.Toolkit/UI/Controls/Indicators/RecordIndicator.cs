using System.Windows.Input;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Metadata;
using Avalonia.Controls.Primitives;

namespace Asv.Avalonia.Toolkit.UI.Controls.Indicators;

[PseudoClasses("")]
public class RecordIndicator : TemplatedControl
{
    public const string RecordingPseudoClass = ":recording";

    public static readonly StyledProperty<bool> IsRecordingProperty = AvaloniaProperty.Register<
        RecordIndicator,
        bool
    >(nameof(IsRecording));

    public bool IsRecording
    {
        get => GetValue(IsRecordingProperty);
        set => SetValue(IsRecordingProperty, value);
    }

    protected override void OnPropertyChanged(AvaloniaPropertyChangedEventArgs change)
    {
        base.OnPropertyChanged(change);
        if (change.Property == IsRecordingProperty)
        {
            PseudoClasses.Set(RecordingPseudoClass, IsRecording);
        }
    }

    public static readonly StyledProperty<ICommand?> StartCommandProperty =
        AvaloniaProperty.Register<RecordIndicator, ICommand?>(nameof(StartCommand));

    public ICommand? StartCommand
    {
        get => GetValue(StartCommandProperty);
        set => SetValue(StartCommandProperty, value);
    }

    public static readonly StyledProperty<ICommand?> StopCommandProperty =
        AvaloniaProperty.Register<RecordIndicator, ICommand?>(nameof(StopCommand));

    public ICommand? StopCommand
    {
        get => GetValue(StopCommandProperty);
        set => SetValue(StopCommandProperty, value);
    }

    public static readonly StyledProperty<string> StartCommandTextProperty =
        AvaloniaProperty.Register<RecordIndicator, string>(
            nameof(StartCommandText),
            "Start record"
        );

    public string StartCommandText
    {
        get => GetValue(StartCommandTextProperty);
        set => SetValue(StartCommandTextProperty, value);
    }

    public static readonly StyledProperty<string> RecordingTextProperty = AvaloniaProperty.Register<
        RecordIndicator,
        string
    >(nameof(RecordingText), "Recording");

    public string RecordingText
    {
        get => GetValue(RecordingTextProperty);
        set => SetValue(RecordingTextProperty, value);
    }

    public static readonly StyledProperty<string> RecordingStatusTextProperty =
        AvaloniaProperty.Register<RecordIndicator, string>(nameof(RecordingStatusText), "01:30.52");

    public string RecordingStatusText
    {
        get => GetValue(RecordingStatusTextProperty);
        set => SetValue(RecordingStatusTextProperty, value);
    }
}
