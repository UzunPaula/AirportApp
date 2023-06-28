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
    /// Interaction logic for AeroportWindow.xaml
    /// </summary>
    public partial class AeroportWindow : Window
    {
        AeroportContext aeroContext = new AeroportContext();
        public Aeroport Aeroport { get; private set; }
        public AeroportWindow(Aeroport aeroport)
        {
            InitializeComponent();
            cbxPasager.ItemsSource = aeroContext.GetPasager().ToList();
            Aeroport = aeroport;
            DataContext = aeroport;
        }



        private void AddRutaBtn_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}
