using CommunityToolkit.Mvvm.ComponentModel;

namespace SimpleWpfApp.Models;

public class User
{
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsActive { get; set; }
}