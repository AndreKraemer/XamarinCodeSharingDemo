using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace XamarinEssentialsDemo
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            OrientationSensor.ReadingChanged += OrientationSensor_ReadingChanged;
        }

        void DeviceInfo_Clicked(object sender, System.EventArgs e)
        {
            DisplayDeviceInfo();
        }

        private void DisplayDeviceInfo()
        {

            var manufacturer = DeviceInfo.Manufacturer;
            var device = DeviceInfo.Model;
            var deviceName = DeviceInfo.Name;

            // Operating System Version Number (7.0)
            var version = DeviceInfo.VersionString;

            // Platform (Android)
            var platform = DeviceInfo.Platform;

            // Idiom (Phone)
            var idiom = DeviceInfo.Idiom;

            // Device Type (Physical)
            var deviceType = DeviceInfo.DeviceType;

            var deviceText = $"{deviceType} {idiom}: {manufacturer} " +
                $"{device} {deviceName} {platform} {version}";


            DeviceInfoLabel.Text = deviceText;
        }

        void PhoneDialer_Clicked(object sender, System.EventArgs e)
        {
            OpenPhoneDialer();
        }


        private void OpenPhoneDialer()
        {
            var number = "555 12345";
            try
            {
                PhoneDialer.Open(number);
            }
            catch (FeatureNotSupportedException)
            {
                DisplayAlert("Fehler", "Feature kann nicht genutzt werden", "Abbrechen");
            }
        }

        void Orientation_Clicked(object sender, System.EventArgs e)
        {
            ToggleOrientationSensor();
        }

        private  void ToggleOrientationSensor()
        {
            try
            {
                if (OrientationSensor.IsMonitoring)
                {

                    OrientationSensor.Stop();
                }
                else
                {

                    OrientationSensor.Start(SensorSpeed.UI);
                }
            }
            catch (FeatureNotSupportedException)
            {
                DisplayAlert("Fehler", "Feature kann nicht genutzt werden", "Abbrechen");
            }

        }

        private void OrientationSensor_ReadingChanged(object sender, OrientationSensorChangedEventArgs e)
        {
            var data = e.Reading;
            OrientationLabel.Text = $"Orientierung: X: {data.Orientation.X}, Y: {data.Orientation.Y}, Z: {data.Orientation.Z}, W: {data.Orientation.W}";
            // Process Orientation quaternion (X, Y, Z, and W)
        }



        void AppInfo_Clicked(object sender, System.EventArgs e)
        {
            GetAppInfo();
        }

        private void GetAppInfo()
        {

            var appName = AppInfo.Name;

            var version = AppInfo.VersionString;

            var text = $"{appName} (V. {version}";
            AppInfoLabel.Text = text;
        }
    }
}
