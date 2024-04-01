namespace MauiAppControls;

public partial class CommandsControlsDemo : ContentPage
{
	public CommandsControlsDemo()
	{
		InitializeComponent();
	}

    private void btnSubmit_Clicked(object sender, EventArgs e)
    {
		DisplayAlert("test", "Demo testing", "Ok");
    }

    private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        DisplayAlert("Radio Button", $"radio Testing: {e.Value}", "Ok");
    }

    private void searchControl_SearchButtonPressed(object sender, EventArgs e)
    {
        DisplayAlert("SarchBar", $"Searching: {searchControl.Text}", "Ok");
    }

    private void SwipeItem_Invoked(object sender, EventArgs e)
    {
        DisplayAlert("Swap", "Item selected", "Ok");
    }

}