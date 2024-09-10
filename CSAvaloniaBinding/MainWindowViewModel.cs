namespace CSAvaloniaBinding
{
    public interface IMainWindowViewModel
    {
        string Text { get; }
    }

    public class MainWindowViewModel() : IMainWindowViewModel
    {
        string IMainWindowViewModel.Text => "Hello, Avalonia!";
    }
}