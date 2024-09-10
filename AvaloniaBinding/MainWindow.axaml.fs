namespace AvaloniaBinding

open System
open Avalonia
open Avalonia.Controls
open Avalonia.Markup.Xaml

type MainWindow () as this =
    inherit Window ()

    do this.InitializeComponent()

    member private this.InitializeComponent() =
        AvaloniaXamlLoader.Load(this)

    member this.TextBlock : TextBlock = this.FindControl<TextBlock>("TextBlock")
