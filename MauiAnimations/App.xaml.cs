namespace MauiAnimations
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Resources.Add("WidthRequestConverterHalf", new WidthRequestConverterHalf());
            Resources.Add("WidthRequestConverterTriple", new WidthRequestConverterTriple());

            MainPage = new AppShell();
        }
    }
}