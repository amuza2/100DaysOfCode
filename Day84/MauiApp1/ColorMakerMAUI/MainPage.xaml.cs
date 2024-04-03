
using CommunityToolkit.Maui.Alerts;
using System.Diagnostics;

namespace ColorMakerMAUI
{
    public partial class MainPage : ContentPage
    {
        bool isRandom;
        string _hexValue;
        public MainPage()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            if (!isRandom)
            {
                var red  = sldRed.Value;
                var green = sldGreen.Value;
                var blue = sldBlue.Value;
                Color color = Color.FromRgb(red, green, blue);
                SetColor(color);
            }
        }

        private void SetColor(Color color)
        {
            Debug.WriteLine(color);
            Container.BackgroundColor = color;
            btnRandom.BackgroundColor = color;
            _hexValue = color.ToHex();
            lblHex.Text = _hexValue;
        }

        private void btnRandom_Clicked(object sender, EventArgs e)
        {
            isRandom = true;
            var random = new Random();
            var color = Color.FromRgb(
                random.Next(0, 256),
                random.Next(0, 256),
                random.Next(0, 256));
            SetColor(color);
            sldRed.Value = color.Red;
            sldGreen.Value = color.Green;
            sldBlue.Value = color.Blue;
            isRandom = false;
        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Clipboard.SetTextAsync(_hexValue);
            var toast = Toast.Make("Value Coppied", CommunityToolkit.Maui.Core.ToastDuration.Short,12);
            await toast.Show();
        }
    }

}
