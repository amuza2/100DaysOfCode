using SimpleWpfApp.Command;
using SimpleWpfApp.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;

namespace SimpleWpfApp.ViewModels;

public class MainVM : INotifyPropertyChanged
{
    private User _currentUser;
    private User _selectedUser;
    private bool _isEditing;
    private User _userBeingEdited;

    public ObservableCollection<User> Users { get; }
    public RelayCommand AddUserCommand { get; }
    public RelayCommand ViewUserCommand { get; }
    public RelayCommand EditUserCommand { get; }
    public RelayCommand DeleteUserCommand { get; }
    public RelayCommand PrintUserCommand { get; }
    public RelayCommand CancelEditCommand { get; }

    public MainVM()
    {
        Users = new ObservableCollection<User>();
        CurrentUser = new User();
        IsEditing = false;

        AddUserCommand = new RelayCommand(AddUser, CanAddUser);
        ViewUserCommand = new RelayCommand(ViewUser, CanPerformUserAction);
        EditUserCommand = new RelayCommand(EditUser, CanPerformUserAction);
        DeleteUserCommand = new RelayCommand(DeleteUser, CanPerformUserAction);
        PrintUserCommand = new RelayCommand(PrintUser, CanPerformUserAction);
        CancelEditCommand = new RelayCommand(CancelEdit, param => IsEditing);

    }


    public User CurrentUser
    {
        get => _currentUser;
        set
        {
            if (_currentUser != value)
            {
                _currentUser = value;
                OnPropertyChanged();
                CommandManager.InvalidateRequerySuggested();
            }
        }
    }

    private bool CanAddUser(object obj)
    {
        return !string.IsNullOrWhiteSpace(CurrentUser.Name);
    }

    private void AddUser(object obj)
    {
        if(IsEditing && _userBeingEdited != null)
        {
            _userBeingEdited.Name = CurrentUser.Name;
            _userBeingEdited.Description = CurrentUser.Description;
            _userBeingEdited.IsActive = CurrentUser.IsActive;

            int userIndex = Users.IndexOf(_userBeingEdited);
            if(userIndex >= 0)
            {
                Users.RemoveAt(userIndex);
                Users.Insert(userIndex, _userBeingEdited);
            }

            IsEditing = false;
        }
        else
        {
            Users.Add(new User
            {
                Name = CurrentUser.Name,
                Description = CurrentUser.Description,
                IsActive = CurrentUser.IsActive
            });

        }

        // Reset current user
        CurrentUser = new User();
    }

    public User SelectedUser 
    { 
        get => _selectedUser;
        set
        {
            if(_selectedUser != value)
            {
                _selectedUser = value;
                OnPropertyChanged();
                CommandManager.InvalidateRequerySuggested();
            }
        }
    }

    public bool IsEditing
    { 
        get => _isEditing;
        set
        {
            if (_isEditing != value)
            {
                _isEditing = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(IsNotEditing));
                CommandManager.InvalidateRequerySuggested();
            }
        }
    }

    public bool IsNotEditing => !IsEditing;

    private bool CanPerformUserAction(object obj)
    {
        return SelectedUser != null && !IsEditing;
    }

    private void ViewUser(object obj)
    {
        if(SelectedUser != null)
        {
            MessageBox.Show($"Name: {SelectedUser.Name}\nDescription: {SelectedUser.Description}\nIsActive: {(SelectedUser.IsActive ? "Yes" : "No")}," +
                $"User Detail", "User Info", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }

    private void EditUser(object obj)
    {
        if(SelectedUser == null)
            return;

        IsEditing = true;
        _userBeingEdited = SelectedUser;
        CurrentUser = new User
        {
            Name = SelectedUser.Name,
            Description = SelectedUser.Description,
            IsActive = SelectedUser.IsActive
        };
    }

    private void DeleteUser(object obj)
    {

        if (SelectedUser != null)
        {
            var result = MessageBox.Show($"Are you sure you want to delete {SelectedUser.Name}?","User deletion", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if(result == MessageBoxResult.No)
                return;
            Users.Remove(SelectedUser);
            SelectedUser = null;
        }
    }

    private void PrintUser(object obj)
    {
        if (SelectedUser == null)
            return;
        var printDialog = new PrintDialog();
        if(printDialog.ShowDialog() == true)
        {
            var document = new FlowDocument();
            var paragraph = new Paragraph(new Run($"Name: {SelectedUser.Name}\nDescription: {SelectedUser.Description}\nIsActive: {(SelectedUser.IsActive ? "Yes" : "No")}"));
            document.Blocks.Add(paragraph);

            var paginator = ((IDocumentPaginatorSource)document).DocumentPaginator;
            printDialog.PrintDocument(paginator, "User Details");
        }
    }

    private void CancelEdit(object obj)
    {
        IsEditing = false;
        _userBeingEdited = null;
        CurrentUser = new User();
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }


}
