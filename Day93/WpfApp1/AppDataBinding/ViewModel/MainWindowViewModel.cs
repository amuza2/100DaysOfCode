using AppDataBinding.Command;
using AppDataBinding.Model;
using AppDataBinding.MVVM;
using AppDataBinding.Views;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace AppDataBinding.ViewModel;

public class MainWindowViewModel : ViewModelBase
{
	private string _searchUser;
	private ObservableCollection<User> _userItems;

	public ObservableCollection<User> UserItems
	{
		get { return _userItems; }
		set { _userItems = value; OnPropertyChanged(); }
	}

    public string SearchUser
	{
		get { return _searchUser; }
		set { _searchUser = value; OnPropertyChanged(); }
	}

	public ICommand AddUserCommand { get; }

    public MainWindowViewModel()
    {
        GetUsers();

        AddUserCommand = new RelayCommand(OpenUserWindow);
    }

	private void OpenUserWindow()
	{
		var addAndEditViewModel = new AddAndEditWondowViewModel();
		var addAndEditWindow = new AddAndEditWindow(addAndEditViewModel);

        addAndEditWindow.ShowDialog();
    }

	public void GetUsers()
    {
        UserItems = Data.GetUsers();
    }
}
