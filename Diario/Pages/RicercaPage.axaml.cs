using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Diario.Views;
using System;

namespace Diario.Pages;

public partial class RicercaPage : UserControl
{
    public static RicercaPage Instance=null;
    public RicercaPage()
    {
        InitializeComponent();
        filtraPerData.SelectedDate = DateTime.Now;
        Instance = this;

    }
    private void CercaDalClicked(object sender, RoutedEventArgs e)
    {
        HomePage.Instance.AggiornaEntita(new DateTime(filtraPerData.SelectedDate.Value.Year, filtraPerData.SelectedDate.Value.Month, filtraPerData.SelectedDate.Value.Day));

    }

    public static void Traduci()
    {
        Instance.Cerca.Content = MainWindow.d["RicercaT"] as string;
        Instance.RicercaL.Content = MainWindow.d["Ricerca"] as string;
    }
}