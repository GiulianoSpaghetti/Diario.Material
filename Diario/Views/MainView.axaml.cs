using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Interactivity;
using Avalonia.Threading;
using Diario;
using Diario.Pages;
using Material.Styles.Controls;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace Diario.Views;

public partial class MainView : UserControl
{
    public static MainView Instance;
    public static ResourceDictionary Dictionary { get; private set; }

    public MainView()
    {
        
        InitializeComponent();
        Instance = this;
        Dictionary = this.FindResource(CultureInfo.CurrentCulture.TwoLetterISOLanguageName) as ResourceDictionary;
        if (Dictionary == null)
            Dictionary = this.FindResource("it") as ResourceDictionary; MainView.Traduci();
        HomePage.Traduci();
        RicercaPage.Traduci();

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
        Instance.HomeTitle.Content = Dictionary["Home"] as string;
        Instance.RicercaTitle.Content = Dictionary["RicercaT"] as string;
        Instance.InfoTitle.Content = Dictionary["Informazioni"] as string;
    }
}
