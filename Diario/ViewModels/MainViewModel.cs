using Avalonia.Interactivity;
using Diario.Pages;
using Diario.Views;
using ReactiveUI;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.IO;
using System.Reactive;
using System.Xml.Linq;

namespace Diario.ViewModels;

public class MainViewModel : ViewModelBase
{
    private string _s;
    private string _status;
    public string Status { get => _status;
        set {
            this.RaiseAndSetIfChanged(ref _status, value);
            MainView.MakeNotification(_status);
        }
    }
    private Item _selectedEntita;
    private DateTimeOffset _d;
    public DateTimeOffset Data { get => _d; set => this.RaiseAndSetIfChanged(ref _d, value); }
    public Item SelectedEntita
    {
        get => _selectedEntita;
        set => this.RaiseAndSetIfChanged(ref _selectedEntita, value);
    }
    public static MainViewModel Instance { get; private set; } = null;
    public string Sstring
    {
        get => _s;
        set => this.RaiseAndSetIfChanged(ref _s, value);
    }
    public ObservableCollection<Item> Entita { get; private set; }
    private static string cs = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "test.db");
    private static SQLiteConnection con;
    private static string s;
    private SQLite.TableQuery<Item> query;

    public static MainViewModel GetInstance()
    {
        if (Instance == null)
            Instance = new MainViewModel();
        return Instance;
    }
    private MainViewModel()
    {

        con = new SQLiteConnection(cs);
        con.CreateTable<Item>();
        Entita = new ObservableCollection<Item>();
        _d = DateTime.Now;
    }

    public void LeggiClicked()
    {
        Entita.Clear();
        query = con.Table<Item>();
        foreach (Item item in query)
        {
            Entita.Add(item);
        }
    }

    public void ModificaClicked()
    {
        if (SelectedEntita == null)
        {
            Status=MainView.Dictionary["ImpossibileTrovareElementi"] as string;
            return;
        }
        SelectedEntita.testo=Sstring;
        SelectedEntita.data = DateTime.Now;
        con.Update(SelectedEntita);
        Status= MainView.Dictionary["ElementoModificato"] as string;
    }
    public void InserisciClicked()
    {
        Item item = new Item();
        item.data = DateTime.Now;
        item.testo = Sstring;
        con.Insert(item);
        Status = MainView.Dictionary["ElementoInserito"] as string;
    }
    public void EliminaClicked()
    {
        if (SelectedEntita == null)
        {
            Status=MainView.Dictionary["ImpossibileTrovareElementi"] as string;
            return;
        }
        con.Delete(SelectedEntita);
        query = con.Table<Item>();
        Status = MainView.Dictionary["ElementoEliminato"] as string;
    }
    public void RicercaClicked()
    {
        Entita.Clear();
        List<Item> elementi;
        if (Data == null)
            elementi = con.Table<Item>().ToList();
        else
        {
            query = con.Table<Item>().Where(v => v.data >= Data);
            elementi = query.ToList();
        }
        if (elementi.Count > 0)
        {
            foreach (Item item in query)
            {
                Entita.Add(item);
            }
        }
        if (Data != null)
            if (elementi.Count == 0)
                Status=MainView.Dictionary["ImpossibileTrovareElementi"] as string;
            else
                Status=$"{MainView.Dictionary["RicercaEffettuata"]} {MainView.Dictionary["CiSono"]} {elementi.Count} {MainView.Dictionary["elementi"]}.";
    }

}
