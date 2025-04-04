using AppDataBinding.ViewModel;
using System.Windows;

namespace AppDataBinding.Views
{
    /// <summary>
    /// Interaction logic for AddAndEditWindow.xaml
    /// </summary>
    public partial class AddAndEditWindow : Window
    {
        public AddAndEditWindow(AddAndEditWondowViewModel addAndEditWondowViewModel)
        {
            InitializeComponent();
            DataContext = addAndEditWondowViewModel;
        }
    }
}
