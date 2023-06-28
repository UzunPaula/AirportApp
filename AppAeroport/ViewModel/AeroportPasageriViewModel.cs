using AppAeroport.AppWindow;
using AppAeroport.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace AppAeroport.ViewModel
{
    public class AeroportPasageriViewModel
    {
        AeroportContext db = new AeroportContext();
        RelayCommand? addCommandRuta;
        RelayCommand? editCommandRuta;
        RelayCommand? deleteCommandRuta;
        RelayCommand? showRuta;

        RelayCommand? addCommandPasager;
        RelayCommand? editCommandPasager;
        RelayCommand? deleteCommandPasager;
        RelayCommand? showPasager;

        RelayCommand? showListaPasagDestClas;
        RelayCommand? showPasageriDestPretBetween;
        RelayCommand? showDestinSumIncasatPas;

        public ObservableCollection<Pasager>? Pasageri { get; set; }
        public ObservableCollection<Aeroport>? Aeroporturi { get; set; }

        public AeroportPasageriViewModel()
        {
            db.Database.EnsureCreated();

            db.Pasageri.Load();
            db.Aeroporturi.Load();

            Pasageri = db.Pasageri.Local.ToObservableCollection();

            Aeroporturi = db.Aeroporturi.Local.ToObservableCollection();
        }


        public RelayCommand AddCommandPasager
        {
            get
            {
                return addCommandPasager ?? (addCommandPasager = new RelayCommand((p) =>
                {
                    PasagerWindow pasagerWindow = new PasagerWindow(new Pasager());
                    if (pasagerWindow.ShowDialog() == true)
                    {
                        Pasager pasager = pasagerWindow.Pasager;
                        db.AdaugaPasager(pasager);
                    }
                }));
            }
        }
        public RelayCommand ShowListaPasageri
        {
            get
            {
                return showPasager ?? (showPasager = new RelayCommand((p) =>
                {
                    ListaPasageriWindow listaPasageriWindow = new ListaPasageriWindow();
                    listaPasageriWindow.ShowDialog();
                }));
            }
        }
        public RelayCommand EditCommandPasageri
        {
            get
            {
                return editCommandPasager ??
                    (editCommandPasager = new RelayCommand((selectedItem) =>
                    {
                        //obtinem obiectul selectat

                        Pasager? pasager = selectedItem as Pasager;
                        if (pasager == null)
                        {
                            return;
                        }
                        Pasager vm = new Pasager
                        {
                            CodPasager = pasager.CodPasager,
                            NumePasager = pasager.NumePasager,
                            PrenumePasager = pasager.PrenumePasager,
                            Telefon = pasager.Telefon,
                        };
                        PasagerWindow agentWindow = new PasagerWindow(vm);
                        Button editButton = agentWindow.btnAddPasager;
                        editButton.Content = "Editeaza pasagerul";

                        if (agentWindow.ShowDialog() == true)
                        {
                            pasager.NumePasager = agentWindow.Pasager.NumePasager;
                            pasager.PrenumePasager = agentWindow.Pasager.PrenumePasager;
                            pasager.Telefon = agentWindow.Pasager.Telefon;
                            db.ActualizeazaPasager(pasager);
                        }
                    }));
            }
        }
        public RelayCommand DeleteCommandPasageri
        {
            get
            {
                return deleteCommandPasager ??
                    (deleteCommandPasager = new RelayCommand((selectedItem) =>
                    {
                        Pasager? pasager = selectedItem as Pasager;
                        if (pasager == null) { return; }
                        db.StergePasager(pasager);
                    }));
            }
        }

        public RelayCommand AddCommandRuta
        {
            get
            {
                return addCommandRuta ?? (addCommandRuta = new RelayCommand((r) =>
                {
                    AeroportWindow aeroportWindow = new AeroportWindow(new Aeroport());
                    if (aeroportWindow.ShowDialog() == true)
                    {
                        Aeroport aeroport = aeroportWindow.Aeroport;
                        aeroport.CodPasager = ((Pasager)aeroportWindow.cbxPasager.SelectedItem).CodPasager;
                        db.AdaugaRuta(aeroport);
                    }
                }));
            }
        }
        public RelayCommand ShowListaRute
        {
            get
            {
                return showRuta ?? (showRuta = new RelayCommand((ap) =>
                {
                    ListaAeroportWindow listaAeroportWindow = new ListaAeroportWindow();
                    listaAeroportWindow.ShowDialog();
                }));
            }
        }
        public RelayCommand EditCommandAero
        {
            get
            {
                return editCommandRuta ?? (editCommandRuta = new RelayCommand((selectedItem) =>
                {
                    Aeroport? aeroport = selectedItem as Aeroport;
                    if (aeroport == null)
                    {
                        return;
                    }
                    Aeroport aero = new Aeroport
                    {
                        CodRuta = aeroport.CodRuta,
                        Destinatia = aeroport.Destinatia,
                        Clasa = aeroport.Clasa,
                        Pret = aeroport.Pret,
                        Pasager = aeroport.Pasager
                    };
                    AeroportWindow aeroportWindow = new AeroportWindow(aero);
                    Button editButton = aeroportWindow.btnAddRuta;
                    editButton.Content = "Editeaza ruta";


                    //Valoarea obiectului selectat se afiseaza in combobox
                    Pasager? selectedPasager = null;
                    foreach (Pasager pasager in aeroportWindow.cbxPasager.Items)
                    {
                        if (pasager.CodPasager == aeroport.Pasager.CodPasager)
                        {
                            selectedPasager = pasager;
                            break;
                        }
                    }
                    aeroportWindow.cbxPasager.SelectedItem = selectedPasager;

                    if (aeroportWindow.ShowDialog() == true)
                    {
                        aeroport.Destinatia = aeroportWindow.Aeroport.Destinatia;
                        aeroport.Clasa = aeroportWindow.Aeroport.Clasa;
                        aeroport.Pret = aeroportWindow.Aeroport.Pret;
                        aeroport.CodPasager = ((Pasager)aeroportWindow.cbxPasager.SelectedItem).CodPasager;
                        db.ActualizeazaRuta(aeroport);
                    }
                }));
            }
        }
        public RelayCommand DeleteCommandAero
        {
            get
            {
                return deleteCommandRuta ?? (deleteCommandRuta = new RelayCommand((selectedItemDel) =>
                {
                    Aeroport? aeroport = selectedItemDel as Aeroport;
                    if (aeroport == null)
                    {
                        return;
                    }
                    db.StergeRuta(aeroport);
                }));
            }
        }

        public RelayCommand ShowListaPasagDestClas
        {
            get
            {
                return showListaPasagDestClas ?? (showListaPasagDestClas = new RelayCommand((show) =>
                {
                    ListaPasagDestinClasa listaPasagDestClas = new ListaPasagDestinClasa();
                    listaPasagDestClas.dgListaPasagDestinClasa.ItemsSource = db.GetListaPasagDestinClasa();
                    listaPasagDestClas.ShowDialog();
                }));
            }
        }

        public RelayCommand ShowPasageriDestPretBetween
        {
            get
            {
                return showPasageriDestPretBetween ?? (showPasageriDestPretBetween = new RelayCommand((show) =>
                {
                    ListaDestinatii800and1200euro listaDestinatii800and1200euro = new ListaDestinatii800and1200euro();
                    listaDestinatii800and1200euro.dgListaDestinatii800and1200.ItemsSource = db.GetListaDestinatii800and1200euro();
                    listaDestinatii800and1200euro.ShowDialog();
                }));
            }
        }

        public RelayCommand ShowDestinSumIncasatPas
        {
            get
            {
                return showDestinSumIncasatPas ?? (showDestinSumIncasatPas = new RelayCommand((show) =>
                {
                    ListaDestinatiiSumaIncasata listaDestinatiiSumaIncasata = new ListaDestinatiiSumaIncasata();
                    listaDestinatiiSumaIncasata.dgListaDestinatiiSumaIncasata.ItemsSource = db.GetListaDestinatiiSumaIncasata();
                    listaDestinatiiSumaIncasata.ShowDialog();
                }));
            }
        }

    }
}
