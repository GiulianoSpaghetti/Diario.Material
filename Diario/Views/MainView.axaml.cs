using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Interactivity;
using Avalonia.Threading;
using Diario;
using Material.Styles.Controls;

namespace Diario.Views;

public partial class MainView : UserControl
{
    public static MainView Instance;
    public MainView()
    {
        InitializeComponent();
        Instance = this;
        DrawerList.PointerReleased += DrawerSelectionChanged;

    }
    public void DrawerSelectionChanged(object? sender, RoutedEventArgs? args)
    {
        if (sender is not ListBox listBox)
            return;

        if (!listBox.IsFocused && !listBox.IsKeyboardFocusWithin)
            return;
        try
        {
            PageCarousel.SelectedIndex = listBox.SelectedIndex;
        }
        catch
        {
            // ignored
        }

        LeftDrawer.OptionalCloseLeftDrawer();

    }

    public static void MakeNotification(string message)
    {
        SnackbarHost.Post(message, null, DispatcherPriority.Normal);
    }

    public static void Traduci()
    {
        Instance.HomeTitle.Content = MainWindow.Dictionary["Home"] as string;
        Instance.RicercaTitle.Content = MainWindow.Dictionary["RicercaT"] as string;
        Instance.InfoTitle.Content = MainWindow.Dictionary["Informazioni"] as string;
    }
}