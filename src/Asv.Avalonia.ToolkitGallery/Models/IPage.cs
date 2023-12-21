using System;

namespace Asv.Avalonia.ToolkitGallery.Models;

public interface IPage
{
    public string Name { get; set; }
    public Uri PageUri { get; set; }
}