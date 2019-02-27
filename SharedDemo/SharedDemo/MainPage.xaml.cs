using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SharedDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var text = GetDeviceInfo();
            DeviceInfoLabel.Text = text;
        }
#if __ANDROID__
        private string GetDeviceInfo()
        {
            return Android.OS.Build.Device;
        }
#endif
#if __IOS__
        private string GetDeviceInfo()
        {
            return UIKit.UIDevice.CurrentDevice.Name;
        }
#endif
#if WINDOWS_UWP
        private string GetDeviceInfo()
        {
            return new Windows.Security.
                ExchangeActiveSyncProvisioning.
                EasClientDeviceInformation().FriendlyName;
        }       
#endif
    }
}
