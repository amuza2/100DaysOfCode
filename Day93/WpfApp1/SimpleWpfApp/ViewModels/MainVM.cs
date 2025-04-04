using SimpleWpfApp.Command;
using SimpleWpfApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SimpleWpfApp.ViewModels;

public class MainVM : INotifyPropertyChanged
{
    private User _currentUser;

    public MainVM()
    {
        Users = new ObservableCollection<User>();
        CurrentUser = new User();
        AddUserCommand = new RelayCommand(AddUser, CanAddUser);
    }

    public ObservableCollection<User> Users { get; }

    public User CurrentUser
    {
        get => _currentUser;
        set
        {
            if (_currentUser != value)
            {
                _currentUser = value;
                OnPropertyChanged();
            }
        }
    }

    public RelayCommand AddUserCommand { get; }

    private bool CanAddUser(object obj)
    {
        return !string.IsNullOrWhiteSpace(CurrentUser.Name);
    }

    private void AddUser(object obj)
    {
        Users.Add(new User
        {
            Name = CurrentUser.Name,
            Description = CurrentUser.Description,
            IsActive = CurrentUser.IsActive
        });

        // Reset current user
        CurrentUser = new User();
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }


}
