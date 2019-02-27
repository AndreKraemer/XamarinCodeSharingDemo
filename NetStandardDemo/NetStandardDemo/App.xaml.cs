using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace NetStandardDemo
{
    public partial class App : Application
    {
        public App(IDeviceInfo deviceInfo)
        {
            InitializeComponent();

            MainPage = new MainPage(deviceInfo);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
