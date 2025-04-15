using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace WpfCommunityMvvmToolKit1;


public partial class MainWindowViewModel : ObservableObject
{
    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(ClickCommand))]
    private int? _count = 0; 

    [RelayCommand(CanExecute = nameof(CanClick))]
    private void Click()
    { 
        Count += 1;
    }

    [RelayCommand()]
    private void Reset()
    {
        Count = 0;
    }

    [RelayCommand()]
    private void Exit()
    {
        Environment.Exit(0);
    }

    private bool CanClick()
        => Count != 3;
    
}
 