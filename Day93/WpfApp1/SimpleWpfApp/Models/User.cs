using CommunityToolkit.Mvvm.ComponentModel;

namespace SimpleWpfApp.Models;

public partial class User : ObservableObject
{
    [ObservableProperty]
    private string _name;
    [ObservableProperty]
    private string _description;
    [ObservableProperty]
    private bool _isActive;
}