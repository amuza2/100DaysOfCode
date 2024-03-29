namespace MauiApp1;

public partial class abouza : ContentPage
{
	public abouza()
	{
		InitializeComponent();
	}

    private void ClickMeButton_Click(object sender, EventArgs e)
    {
		Navigation.PushAsync(new MainPage());
    }
}