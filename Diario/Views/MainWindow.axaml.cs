using Avalonia.Controls;
using Diario.Pages;
using System.Globalization;

namespace Diario.Views;

public partial class MainWindow : Window
{
    private static ResourceDictionary dic;
    public static ResourceDictionary d { get => dic; };
    public MainWindow()
    {
        InitializeComponent();
        dic = this.FindResource(CultureInfo.CurrentCulture.TwoLetterISOLanguageName) as ResourceDictionary;
        if (dic == null)
            dic = this.FindResource("it") as ResourceDictionary;
        MainView.Traduci();
        HomePage.Traduci();
        RicercaPage.Traduci();
    }
}
