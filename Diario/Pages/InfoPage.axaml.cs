using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Diario.ViewModels;
using Diario.Views;
using System;
using System.Net;

namespace Diario.Pages;

public partial class InfoPage : UserControl
{
    private static Avalonia.Platform.Storage.ILauncher? launcher=null;
    public static readonly Uri HomePage=new Uri("https://github.com/GiulianoSpaghetti/Diario.Material");
    public InfoPage()
    {
        InitializeComponent();
    }

    private void OnSito_Click(object sender, RoutedEventArgs e)
    {
        if (launcher==null)
            launcher = TopLevel.GetTopLevel( (Avalonia.Visual) sender).Launcher;
        launcher.LaunchUriAsync(HomePage);
    }
}
