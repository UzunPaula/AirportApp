using AppAeroport.Models;
using AppAeroport.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AppAeroport.AppWindow
{
    /// <summary>
    /// Interaction logic for ListaDestinatii800and1200euro.xaml
    /// </summary>
    public partial class ListaDestinatii800and1200euro : Window
    {
        AeroportContext aeroContext = new AeroportContext();
        AeroportPasageriViewModel vm = new AeroportPasageriViewModel();
        public ListaDestinatii800and1200euro()
        {
            InitializeComponent();
            dgListaDestinatii800and1200.ItemsSource = aeroContext.GetListaDestinatii800and1200euro();
            dgListaDestinatii800and1200.Items.Refresh();
            RefreshGrid();
        }
        public void RefreshGrid()
        {
            DataContext = null;
            DataContext = vm;
        }
    }
}
