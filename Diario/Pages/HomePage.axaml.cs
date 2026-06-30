using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Diario.Views;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System;
using System.IO;
using SQLite;
using Diario.ViewModels;
using System.Collections.Immutable;

namespace Diario.Pages;

public partial class HomePage : UserControl
{
    private static HomePage Instance = null;
    public static HomePage HomePageInstance { get => Instance; }

    public HomePage()
    {
        DataContext ??= MainViewModel.GetInstance();
        InitializeComponent();
        Instance = this;
    }
    public static void Traduci()
    {
        Instance.Leggi.Content = MainView.Dictionary["Leggi"] as string;
        Instance.Modifica.Content = MainView.Dictionary["Modifica"] as string;
        Instance.Elimina.Content = MainView.Dictionary["Elimina"] as string;
        Instance.Inserisci.Content = MainView.Dictionary["Inserisci"] as string;
    }
}
