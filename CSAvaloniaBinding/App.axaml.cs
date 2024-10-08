using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;

namespace CSAvaloniaBinding
{
    public partial class App : Application
    {
        private IMainWindowViewModel vm = new MainWindowViewModel();

        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = new MainWindow{DataContext = vm};
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}