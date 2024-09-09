namespace AvaloniaBinding

type IMainWindowViewModel =
    abstract member Text : string with get

type MainWindowViewModel() =
    interface IMainWindowViewModel with
        member _.Text = "Hello, Avalonia!"
