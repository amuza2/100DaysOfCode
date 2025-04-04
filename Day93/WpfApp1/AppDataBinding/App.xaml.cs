using AppDataBinding.ViewModel;
using AppDataBinding.Views;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace AppDataBinding;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    public static IServiceProvider serviceProvider { get; private set; }

    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);
        ServiceCollection services = new();
        ConfigureServices(services);
        serviceProvider = services.BuildServiceProvider();

        // Create and show the MainWindow
        var mainWindow = serviceProvider.GetRequiredService<MainWindow>();
        mainWindow.Show();
    }

    private void ConfigureServices(ServiceCollection services)
    {
        // ViewModels
        services.AddTransient<MainWindowViewModel>();
        services.AddTransient<AddAndEditWondowViewModel>();

        // Window
        services.AddTransient<MainWindow>();
        services.AddTransient<AddAndEditWindow>();

        // ErrorValidation
    }
}

