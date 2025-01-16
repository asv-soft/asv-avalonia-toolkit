using System;
using Asv.Avalonia.ToolkitGallery.Tools;
using Asv.Avalonia.ToolkitGallery.ViewModels;
using Avalonia.Controls;
using Avalonia.Controls.Templates;

namespace Asv.Avalonia.ToolkitGallery;

public class ViewLocator : IDataTemplate
{
    public Control? Build(object? data)
    {
        if (data is null)
            return null;

        var name = data.GetType().FullName!.Replace("ViewModel", "View", StringComparison.Ordinal);
        var type = Type.GetType(name);

        if (type != null)
        {
            return (Control)Activator.CreateInstance(type)!;
        }

        return new TextBlock { Text = "Not Found: " + name };
    }

    public bool Match(object? data)
    {
        return data is DisposableReactiveObject;
    }
}
