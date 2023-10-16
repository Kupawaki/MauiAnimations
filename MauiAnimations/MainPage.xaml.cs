using System.Diagnostics;

namespace MauiAnimations
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void RotateThing(object sender, EventArgs e)
        {
            try
            {
                float rot = float.Parse(rotateET.Text);
                uint ease = uint.Parse(rotateEaseET.Text);
                await img.RotateTo(rot, ease);
            }
            catch(Exception ex)
            {
                await DisplayAlert("HEY", "Stop being dumb - enter a number", "Okay, sorry");
                Debug.WriteLine(ex.Message);
            }
        }

        private async void ScaleThing(object sender, EventArgs e)
        {
            try
            {
                float rot = float.Parse(scaleET.Text);
                uint ease = uint.Parse(scaleEaseET.Text);
                await img.ScaleTo(rot, ease);
            }
            catch (Exception ex)
            {
                await DisplayAlert("HEY", "Stop being dumb - enter a number", "Okay, sorry");
                Debug.WriteLine(ex.Message);
            }
        }
    }
}