using System;
using ReactiveUI;

namespace Asv.Avalonia.ToolkitGallery.ViewModels;

public interface IViewModel:IReactiveObject, IDisposable
{
    Uri Id { get; }
}