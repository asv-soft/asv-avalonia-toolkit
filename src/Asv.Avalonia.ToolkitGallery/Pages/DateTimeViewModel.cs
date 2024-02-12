using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Reactive;
using System.Windows.Input;
using Asv.Avalonia.ToolkitGallery.Models;
using Asv.Avalonia.ToolkitGallery.ViewModels;
using Asv.Common;
using Avalonia;
using Material.Icons;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace Asv.Avalonia.ToolkitGallery.Pages;

public class DateTimeViewModel: ViewModelBase,IShellPage
{
    public MaterialIconKind Icon { get; }
    public string Title { get; }
    public const string UriString = $"{MainViewModel.UriString}.date-time-page";
    public static readonly Uri Uri = new(UriString);
    [ImportingConstructor]
    public DateTimeViewModel():base(Uri)
    {
        SelectedDateTimeValue = DateTimeOffset.Now;
         this.WhenAnyValue(_=>_.SelectedDateTimeValue ).Subscribe(v =>
         {
             TimeUserValue = v.ToString();
         }).DisposeItWith(Disposable);
         SelectedDateTimeValue.WhenAnyValue(v => v.Day, v => v.Month, v => v.Year,v=>v.Hour,v=>v.Minute)
             .Subscribe(v =>
             {
                 SelectedDateTimeValue = DateTimeOffset.Parse($"{v.Item1}-{v.Item2}-{v.Item3} {v.Item4}:{v.Item5}:00-00:00");
                 TimeUserValue = SelectedDateTimeValue.ToString();
             })
             .DisposeItWith(Disposable);
         SelectionChange = ReactiveCommand.Create(() =>
         {
             TimeUserValue = SelectedDateTimeValue.ToString();
         });
    }
    public ReactiveCommand<Unit,Unit> SelectionChange { get; set; }
    [Reactive] 
    public DateTimeOffset SelectedDateTimeValue { get; set; }
    [Reactive]
    public string TimeUserValue { get; set; }
   
    
    
    
}