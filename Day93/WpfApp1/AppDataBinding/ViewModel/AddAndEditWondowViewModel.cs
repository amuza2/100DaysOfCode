using AppDataBinding.Command;
using AppDataBinding.Model;
using AppDataBinding.MVVM;
using AppDataBinding.Shared;
using System.Windows;
using System.Windows.Input;

namespace AppDataBinding.ViewModel;

public class AddAndEditWondowViewModel : ViewModelBase
{
	public Action UpdateDataGridWhenUserAdded;
	private string _name;

	public string Name
	{
		get { return _name; }
		set { _name = value;
			OnPropertyChanged();
            ValidateProperty(nameof(Name));
        }
	}

	private string _email;

	public string Email
	{
		get { return _email; }
		set 
		{ 
			_email = value;
			OnPropertyChanged();
            ValidateProperty(nameof(Email));
        }
	}

	public ICommand AddUserCommand { get; }

	public AddAndEditWondowViewModel()
    {
        AddUserCommand = new RelayCommand(AddUserToDatabase, CanAddUserToDatabase);
    }

    private void AddUserToDatabase()
    {
        ValidateProperty(nameof(Name));
        ValidateProperty(nameof(Email));

		if (HasErrors) return;

        User newUser = new User
        {
            Name = Name,
            Email = Email
        };

		var addedUser = Data.AddUser(newUser);
		UpdateDataGridWhenUserAdded?.Invoke();
		MessageBox.Show($"User Id: {addedUser} - added successfully"); 
    }

    private bool CanAddUserToDatabase()
    {
        // Check if both Name and Email are valid
        return !string.IsNullOrWhiteSpace(Name) &&
               !string.IsNullOrWhiteSpace(Email) &&
               !HasErrors;
    }

    // Override the validation method
    protected override void ValidateProperty(string propertyName)
    {
        // Clear existing errors for this property
        RemoveError(propertyName);

        switch (propertyName)
        {
            case nameof(Name):
                if (string.IsNullOrWhiteSpace(Name))
                    AddError(propertyName, "Name is required.");
                else if (Name.Length < 3)
                    AddError(propertyName, "Name must be at least 3 characters.");
                break;

            case nameof(Email):
                if (string.IsNullOrWhiteSpace(Email))
                    AddError(propertyName, "Email is required.");
                else if (!IsValidEmail(Email))
                    AddError(propertyName, "Please enter a valid email address.");
                break;
        }

        // Notify that CanExecute may have changed
        CommandManager.InvalidateRequerySuggested();
    }

    // Helper method to validate email format
    private bool IsValidEmail(string email)
    {
        try
        {
            var addr = new System.Net.Mail.MailAddress(email);
            return addr.Address == email;
        }
        catch
        {
            return false;
        }
    }
}
