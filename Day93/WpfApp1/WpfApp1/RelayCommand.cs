using System.Windows.Input;

namespace WpfApp1
{
    internal class RelayCommand : ICommand
    {
        private readonly Func<Task> executeCommand;
        private readonly Func<bool> canExecuteCommand;

        public RelayCommand(Func<Task> executeCommand, Func<bool> canExecuteCommand = null)
        {
            this.executeCommand = executeCommand ?? throw new ArgumentNullException(nameof(executeCommand));
            this.canExecuteCommand = canExecuteCommand;
        }

        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object? parameter)
        {
            return canExecuteCommand == null || canExecuteCommand();
        }

        public async void Execute(object? parameter)
        {
            await executeCommand();
        }
    }
}