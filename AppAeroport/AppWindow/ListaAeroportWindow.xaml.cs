using AppAeroport.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
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
    /// Interaction logic for ListaAeroportWindow.xaml
    /// </summary>
    public partial class ListaAeroportWindow : Window
    {
        AeroportPasageriViewModel viewModelAero = new AeroportPasageriViewModel();
        public ListaAeroportWindow()
        {
            InitializeComponent();
            DataContext = viewModelAero;
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            DataContext = null;
            DataContext = viewModelAero;
        }

        private void Editare_Click(object sender, RoutedEventArgs e)
        {
            var viewModel = DataContext as AeroportPasageriViewModel;
            if (viewModel != null && viewModel.EditCommandAero != null && viewModel.EditCommandAero.CanExecute(dgRute.SelectedItem))
            {
                viewModel.EditCommandAero.Execute(dgRute.SelectedItem);
                RefreshGrid();
            }
        }

        private void Stergere_Click(object sender, RoutedEventArgs e)
        {
            var viewModel = DataContext as AeroportPasageriViewModel;
            if (viewModel != null && viewModel.DeleteCommandAero != null && viewModel.DeleteCommandAero.CanExecute(dgRute.SelectedItem))
            {
                viewModel.DeleteCommandAero.Execute(dgRute.SelectedItem);
            }
        }
    }
}
