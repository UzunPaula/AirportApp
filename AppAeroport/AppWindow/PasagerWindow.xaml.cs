using AppAeroport.Models;
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
    /// Interaction logic for PasagerWindow.xaml
    /// </summary>
    public partial class PasagerWindow : Window
    {
        public Pasager Pasager { get; set; }
        public PasagerWindow(Pasager pasager)
        {
            InitializeComponent();

            Pasager = pasager;
            DataContext = Pasager;
        }

        private void btnAddPasager_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}
