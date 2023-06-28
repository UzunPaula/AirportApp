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
    /// Interaction logic for ListaDestinatiiSumaIncasata.xaml
    /// </summary>  
    public partial class ListaDestinatiiSumaIncasata : Window
    {
        AeroportContext aeroContext = new AeroportContext();
        AeroportPasageriViewModel viewModel = new AeroportPasageriViewModel();
        public ListaDestinatiiSumaIncasata()
        {
            InitializeComponent();
            //DataContext = viewModel;
            dgListaDestinatiiSumaIncasata.ItemsSource = aeroContext.GetListaDestinatiiSumaIncasata();
            dgListaDestinatiiSumaIncasata.Items.Refresh();
        }
        public void RefreshGrid()
        {
            DataContext = null;
            DataContext = viewModel;
        }
    }
}
