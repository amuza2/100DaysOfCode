namespace KidStoryAppProject
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(Story1), typeof(Story1));
        }
    }
}
