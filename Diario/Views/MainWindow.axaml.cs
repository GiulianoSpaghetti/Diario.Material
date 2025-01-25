using Avalonia.Controls;
using Diario.Pages;
using System.Globalization;

namespace Diario.Views;

public partial class MainWindow : Window
{
    public static ResourceDictionary d;
    public MainWindow()
    {
        InitializeComponent();
        d = this.FindResource(CultureInfo.CurrentCulture.TwoLetterISOLanguageName) as ResourceDictionary;
        if (d == null)
            d = this.FindResource("it") as ResourceDictionary;
        MainView.Traduci();
        HomePage.Traduci();
        RicercaPage.Traduci();
    }
}
