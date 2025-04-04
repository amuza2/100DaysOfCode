using AppDataBinding.ViewModel;
using System.Windows;

namespace AppDataBinding;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private readonly AddAndEditWondowViewModel _addAndEditWondowViewModel;
    public MainWindow(MainWindowViewModel mainWindowViewModel, AddAndEditWondowViewModel addAndEditWondowViewModel)
    {
        InitializeComponent();
        DataContext = mainWindowViewModel;
        _addAndEditWondowViewModel = addAndEditWondowViewModel;
        addAndEditWondowViewModel.UpdateDataGridWhenUserAdded = mainWindowViewModel.GetUsers;
    }
}