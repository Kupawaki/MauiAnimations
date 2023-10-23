using System.Diagnostics;
using System.Globalization;
using Microsoft.Maui.Controls;

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
                await DisplayAlert("Rotate Error", "MSG", "Okay");
                Debug.WriteLine(ex.Message);
            }
        }

        private async void ScaleThing(object sender, EventArgs e)
        {
            try
            {
                float scale = float.Parse(scaleET.Text);
                uint ease = uint.Parse(scaleEaseET.Text);
                await img.ScaleTo(scale, ease);
            }
            catch (Exception ex)
            {
                await DisplayAlert("Scale Error", "MSG", "Okay");
                Debug.WriteLine(ex.Message);
            }
        }

        private async void TranslateThing(object sender, EventArgs e)
        {
            try
            {
                float x = float.Parse(translateXET.Text);
                float y = float.Parse(translateYET.Text);
                uint ease = uint.Parse(translateEaseET.Text);
                await img.TranslateTo(x, y, ease);
            }
            catch (Exception ex)
            {
                await DisplayAlert("Translate Error", "MSG", "Okay");
                Debug.WriteLine(ex.Message);
            }
        }

        private async void FadeThing(object sender, EventArgs e)
        {
            try
            {
                float opc = float.Parse(fadeET.Text);
                uint ease = uint.Parse(fadeEaseET.Text);
                await img.FadeTo(opc, ease);
            }
            catch (Exception ex)
            {
                await DisplayAlert("Fade Error", "MSG", "Okay");
                Debug.WriteLine(ex.Message);
            }
        }

        private void CancelAllAnimations(object sender, EventArgs e)
        {
            img.CancelAnimations();
        }
    }

    public class WidthRequestConverterHalf : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double width)
            {
                return width / 2;
            }

            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class WidthRequestConverterTriple : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double width)
            {
                return width * 3;
            }

            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}