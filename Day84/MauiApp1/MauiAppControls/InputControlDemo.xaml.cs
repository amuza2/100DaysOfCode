using System.Diagnostics;

namespace MauiAppControls;

public partial class InputControlDemo : ContentPage
{
	public InputControlDemo()
	{
		InitializeComponent();
	}

    private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        lblSlider.Text = String.Format("{0:F0}",e.NewValue);
    }

    private void stepper_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        if(stepper != null)
        {
            lblSlider.Text = e.NewValue.ToString();
        }
    }

    private void Entry_TextChanged(object sender, TextChangedEventArgs e)
    {
        
    }

    private void txbPhone_Completed(object sender, EventArgs e)
    {
        Debug.WriteLine(txbPhone.Text);
    }
}