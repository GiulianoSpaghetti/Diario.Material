using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Diario.ViewModels;
using Diario.Views;
using System;

namespace Diario.Pages;

public partial class RicercaPage : UserControl
{
    private static RicercaPage Instance=null;
    public RicercaPage()
    {
        DataContext ??= MainViewModel.GetInstance();
        InitializeComponent();
        Instance = this;
    }
    public static void Traduci()
    {
        Instance.Cerca.Content = MainView.Dictionary["RicercaT"] as string;
        Instance.RicercaL.Content = MainView.Dictionary["Ricerca"] as string;
    }
}
