using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.Platform.Storage;
using Diario.ViewModels;
using Diario.Views;
using System;
using System.Net;

namespace Diario.Pages;

public partial class InfoPage : UserControl
{
    private static ILauncher? launcher=null;
    private static Uri HomePage = new Uri("http://github.com/GiulianoSpaghetti/Diario.Material");
    public InfoPage()
    {
        InitializeComponent();
    }

    public void OnSito_Click(Object sender, RoutedEventArgs e)
    {
        if (launcher == null)
        {
            launcher = TopLevel.GetTopLevel(this).Launcher;
        }
        launcher.LaunchUriAsync(HomePage);
    }
}