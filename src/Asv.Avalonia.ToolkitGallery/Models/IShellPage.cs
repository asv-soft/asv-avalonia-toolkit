using System;
using System.Threading.Tasks;
using Asv.Avalonia.ToolkitGallery.ViewModels;
using DynamicData;
using Material.Icons;

namespace Asv.Avalonia.ToolkitGallery.Models;

public interface IShellPage : IViewModel
{
    MaterialIconKind Icon { get; }
    string Title { get; }
}