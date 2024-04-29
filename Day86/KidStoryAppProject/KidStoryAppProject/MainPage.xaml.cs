namespace KidStoryAppProject
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if(sender is Button button)
            {
                string storyButton = button.Text;
                Navigation.PushAsync(new Story1(storyButton));
            }
        }
    }

}
