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
    /// Interaction logic for ListaPasageriWindow.xaml
    /// </summary>
    public partial class ListaPasageriWindow : Window
    {
        AeroportPasageriViewModel vm = new AeroportPasageriViewModel();
        public ListaPasageriWindow()
        {
            InitializeComponent();
            DataContext = vm;
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            DataContext = null;
            DataContext = vm;
        }

        private void Editare_Click(object sender, RoutedEventArgs e)
        {
            var viewModel = DataContext as AeroportPasageriViewModel;
            if (viewModel != null && viewModel.EditCommandPasageri != null && viewModel.EditCommandPasageri.CanExecute(dgPasageri.SelectedItem))
            {
                viewModel.EditCommandPasageri.Execute(dgPasageri.SelectedItem);
                RefreshGrid();
            }
        }

        private void Sterge_Click(object sender, RoutedEventArgs e)
        {
            var viewModel = DataContext as AeroportPasageriViewModel;
            if (viewModel != null && viewModel.DeleteCommandPasageri != null && viewModel.DeleteCommandPasageri.CanExecute(dgPasageri.SelectedItem))
            {
                viewModel.DeleteCommandPasageri.Execute(dgPasageri.SelectedItem);
            }
        }
    }
}
