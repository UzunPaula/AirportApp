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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AppAeroport
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new AeroportPasageriViewModel();
        }

        private void btnShowAddRuta_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnShowListaRute_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnShowAddPasager_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnShowListaPasageri_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
