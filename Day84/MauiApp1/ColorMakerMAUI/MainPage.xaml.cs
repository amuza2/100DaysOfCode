
using CommunityToolkit.Maui.Alerts;
using System.Diagnostics;
using Microsoft.Maui.Graphics;

namespace ColorMakerMAUI
{
    public partial class MainPage : ContentPage
    {
        private bool _buttonIsActive = false;
        private string _hexValue;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            // Condition to disable button call when a slider in used
            if(!_buttonIsActive)
            {
                var red = sldRed.Value;
                var green = sldGreen.Value;
                var blue = sldBlue.Value;

                var color = Color.FromRgb(red, green, blue);

                setColor(color);
            }
            
        }

        private void setColor(Color color)
        {
            Container.BackgroundColor = color;
            _hexValue = color.ToHex();
            lblColor.Text = "Color Value: " + _hexValue;
            //Debug.WriteLine(color.ToString());
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            _buttonIsActive = true;
            var rnd = new Random();
            var color = Color.FromRgb(
                rnd.Next(256),
                rnd.Next(256),
                rnd.Next(256)
                );

            setColor(color);
            sldBlue.Value = color.Blue;
            sldGreen.Value = color.Green;
            sldRed.Value = color.Red;
            _buttonIsActive = false;
        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Clipboard.SetTextAsync(_hexValue);
            var toast = Toast.Make(
                "Color copied",
                CommunityToolkit.Maui.Core.ToastDuration.Short,
                12
                );
            await toast.Show();
        }
    }

}
