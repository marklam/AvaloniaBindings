namespace AvaloniaBinding

open System
open System.Threading
open Avalonia
open Avalonia.Headless

module Program =

    [<EntryPoint; STAThread>]
    let main argv =
        use session = HeadlessUnitTestSession.StartNew(typeof<App>)

        let vm : IMainWindowViewModel = MainWindowViewModel()

        let success =
            session.Dispatch((
                fun () ->
                    let window = MainWindow(DataContext = vm)

                    window.Show()

                    try
                        if String.IsNullOrEmpty(window.TextBlock.Text) then
                            false
                        else
                            true
                    finally
                        window.Close()
                ), CancellationToken.None).Result

        if not success then failwith "Text was not set from binding"

        0
