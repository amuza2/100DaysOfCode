namespace KidStoryAppProject
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // MainPage = new AppShell();
           var navigationPage = new NavigationPage(new MainPage())
        {
            BarBackgroundColor = Colors.Pink,
            BarTextColor = Colors.White
        };
        
        // Hide the navigation bar
        NavigationPage.SetHasNavigationBar(navigationPage.CurrentPage, false);
        
        MainPage = navigationPage;
        }
    }
}
