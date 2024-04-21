
using CommunityToolkit.Maui.Alerts;
using System.Diagnostics;
using Microsoft.Maui.Graphics;

namespace ColorMakerMAUI
{
    public partial class MainPage : ContentPage
    {
        bool buttonIsActive = false;
        public MainPage()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            // Condition to disable button call when a slider in used
            if(!buttonIsActive)
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
            lblColor.Text = "Color Value: " + color.ToHex().ToString();
            Debug.WriteLine(color.ToString());
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            buttonIsActive = true;
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
            buttonIsActive = false;
        }
    }

}
