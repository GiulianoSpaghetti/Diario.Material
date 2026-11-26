using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;

using Diario.ViewModels;
using Diario.Views;

namespace Diario;

public partial class App : Application
{
    public static int Width { get; private set; }
    public static int Height { get; private set; }
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
        SQLitePCL.Batteries_V2.Init();
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            Height = 600;
            desktop.MainWindow = new MainWindow();
        }
        else if (ApplicationLifetime is ISingleViewApplicationLifetime singleViewPlatform)
        {
            Height = 500;
            singleViewPlatform.MainView = new MainView();
        }

        base.OnFrameworkInitializationCompleted();
    }
}
