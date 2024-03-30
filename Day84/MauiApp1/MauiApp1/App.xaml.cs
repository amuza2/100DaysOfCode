
namespace MauiApp1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var navBar = new NavigationPage(new MainPage());
            navBar.BarBackground = Colors.Black;
            navBar.BarTextColor = Colors.White;

            MainPage = new AbsoluteLayoutDemo();
        }
    }
}
