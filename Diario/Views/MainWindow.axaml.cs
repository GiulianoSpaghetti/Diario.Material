using Avalonia.Controls;
using Diario.Pages;
using System.Globalization;

namespace Diario.Views;

public partial class MainWindow : Window
{
    public static ResourceDictionary Dictionary { get; private set; }
    public MainWindow()
    {
        InitializeComponent();
        Dictionary = this.FindResource(CultureInfo.CurrentCulture.TwoLetterISOLanguageName) as ResourceDictionary;
        if (Dictionary == null)
            Dictionary = this.FindResource("it") as ResourceDictionary;
        MainView.Traduci();
        HomePage.Traduci();
        RicercaPage.Traduci();
    }
}
