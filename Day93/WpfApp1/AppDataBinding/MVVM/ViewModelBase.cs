using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AppDataBinding.MVVM;

public class ViewModelBase : INotifyPropertyChanged, INotifyDataErrorInfo
{
    public event PropertyChangedEventHandler? PropertyChanged;
    public event EventHandler<DataErrorsChangedEventArgs>? ErrorsChanged;

    // Dictionary to store validation errors (property name -> list of errors)
    private readonly Dictionary<string, List<string>> _errors = new();

    // Implement INotifyDataErrorInfo members
    public bool HasErrors => _errors.Any();

    public IEnumerable GetErrors(string? propertyName)
    {
        if (string.IsNullOrEmpty(propertyName) || !_errors.ContainsKey(propertyName))
            return null;

        return _errors[propertyName];
    }

    // Method to add a validation error
    protected void AddError(string propertyName, string error)
    {
        if (!_errors.ContainsKey(propertyName))
            _errors[propertyName] = new List<string>();

        if (!_errors[propertyName].Contains(error))
        {
            _errors[propertyName].Add(error);
            OnErrorsChanged(propertyName);
        }
    }

    // Method to remove a validation error
    protected void RemoveError(string propertyName, string error = null)
    {
        if (!_errors.ContainsKey(propertyName))
            return;

        if (string.IsNullOrEmpty(error))
        {
            // Remove all errors for this property
            _errors.Remove(propertyName);
        }
        else
        {
            // Remove specific error
            _errors[propertyName].Remove(error);
            if (_errors[propertyName].Count == 0)
                _errors.Remove(propertyName);
        }

        OnErrorsChanged(propertyName);
    }

    // Method to check if a property has errors
    protected bool HasError(string propertyName)
    {
        return _errors.ContainsKey(propertyName) && _errors[propertyName].Count > 0;
    }

    // Helper method to raise ErrorsChanged event
    protected void OnErrorsChanged(string propertyName)
    {
        ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
    }

    public void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    // Validate method that child classes can override
    protected virtual void ValidateProperty(string propertyName)
    {
        // Base implementation does nothing
    }
}
