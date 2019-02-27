using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DependencyServiceDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var deviceInfo = DependencyService.Get<IDeviceInfo>();
            DeviceInfoLabel.Text = deviceInfo.GetName();
        }
    }
}
