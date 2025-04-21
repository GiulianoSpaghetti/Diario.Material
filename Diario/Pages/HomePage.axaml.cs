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

namespace Diario.Pages;

public partial class HomePage : UserControl
{
    private static string cs = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "test.db");
    private static SQLiteConnection con;
    private static string s;
    private static int id;
    private SQLite.TableQuery<Item> query;
    private static HomePage Instance = null;
    public static HomePage HomePageInstance { get => Instance; } 
    public HomePage()
    {
        InitializeComponent();
        con = new SQLiteConnection(cs);
        con.CreateTable<Item>();
        AggiornaEntita();
        Instance = this;
    }

    public static void Traduci()
    {
        Instance.Leggi.Content = MainWindow.Dictionary["Leggi"] as string;
        Instance.Modifica.Content = MainWindow.Dictionary["Modifica"] as string;
        Instance.Elimina.Content = MainWindow.Dictionary["Elimina"] as string;
        Instance.Inserisci.Content = MainWindow.Dictionary["Inserisci"] as string;
    }

    private void LeggiClicked(object sender, RoutedEventArgs e)
    {
        try
        {
            id = GetIdFromEntita();
        }
        catch (Exception ex)
        {
            MainView.MakeNotification(ex.Message);
            return;
        }
        query = con.Table<Item>().Where(v => v.Id.Equals(id));
        foreach (Item item in query)
        {
            sstring.Text = item.testo;
        }
    }

    private void ModificaClicked(object sender, RoutedEventArgs e)
    {
        try
        {
            id = GetIdFromEntita();
        }
        catch (Exception ex)
        {
            MainView.MakeNotification(ex.Message);
            return;
        }
        query = con.Table<Item>().Where(v => v.Id.Equals(id));
        foreach (Item item in query)
        {
            item.testo = sstring.Text;
            item.data = DateTime.Now;
            con.Update(item);
        }
        AggiornaEntita();

    }
    private void InserisciClicked(object sender, RoutedEventArgs e)
    {
        Item item = new Item();
        item.data = DateTime.Now;
        item.testo = sstring.Text;
        con.Insert(item);
        AggiornaEntita();
    }
    private void EliminaClicked(object sender, RoutedEventArgs e)
    {
        try
        {
            id = GetIdFromEntita();
        }
        catch (Exception ex)
        {
            MainView.MakeNotification(ex.Message);
            return;
        }
        query = con.Table<Item>().Where(v => v.Id.Equals(id));
        foreach (Item item in query)
        {
            con.Delete(item);
        }
        AggiornaEntita();
    }

    private int GetIdFromEntita()
    {
        if (Dati.Items.Count == 0)
            throw new Exception(MainWindow.Dictionary["DatabaseVuoto"] as string);
        s = Dati.SelectedItem.ToString();
        return Int32.Parse(s.Substring(0, s.IndexOf("-") - 1));

    }

    public void AggiornaEntita(DateTime? data = null)
    {
        Dati.Items.Clear();
        List<Item> elementi;
        if (data == null)
            elementi = con.Table<Item>().ToList();
        else
        {
            query = con.Table<Item>().Where(v => v.data >= data);
            elementi = new List<Item>();
            foreach (Item item in query)
                elementi.Add(item);
        }
        if (elementi.Count > 0)
        {
            foreach (Item elemento in elementi)
                Dati.Items.Add($"{elemento.Id} - {elemento.data}");
            Dati.SelectedIndex = 0;
        }
        if (data != null)
            if (elementi.Count == 0)
                MainView.MakeNotification(MainWindow.Dictionary["ImpossibileTrovareElementi"] as string);
            else
                MainView.MakeNotification($"{MainWindow.Dictionary["RicercaEffettuata"]} {MainWindow.Dictionary["CiSono"]} {elementi.Count} {MainWindow.Dictionary["elementi"]}.");
        Dati.IsEnabled = elementi.Count > 0;
        sstring.Text = "";
    }
}