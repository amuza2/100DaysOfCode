using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SimpleWpfApp.Command;
using SimpleWpfApp.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SimpleWpfApp.ViewModels;

public partial class MainVM : ObservableValidator
{
    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(AddUserCommand))]
    [Required(ErrorMessage = "Name is required")]
    [MinLength(3, ErrorMessage = "Name cannot be less than 3 characters")]
    private string _name;

    //[Required(ErrorMessage = "Description is required")]
    //[MinLength(3, ErrorMessage = "Description cannot be less than 3 characters")]
    [ObservableProperty]
    private string _description;

    [ObservableProperty]
    private bool _isActive;

    public ObservableCollection<User> Users { get; }

    //public ObservableCollection<ValidationResult> ValidationErrors { get; set; }

    public MainVM()
    {
        Users = new ObservableCollection<User>();
    }
    partial void OnNameChanged(string value)
    {
        ValidateProperty(value, nameof(Name));
    }

    private bool CanAddUser(object obj)
    {
        ValidateAllProperties();

        return !HasErrors;
    }

    //[RelayCommand]
    [RelayCommand(CanExecute = nameof(CanAddUser))]
    private void AddUser(object obj)
    {
        if (HasErrors)
            return;

        Users.Add(new User
        {
            Name = Name,
            Description = Description,
            IsActive = IsActive
        });
        Name = string.Empty;
        Description = string.Empty;
        IsActive = false;

    }
}
