using DependencyServiceDemo.iOS;
using Xamarin.Forms;

[assembly: Dependency(typeof(IoSDeviceInfo))]
namespace DependencyServiceDemo.iOS
{
    public class IoSDeviceInfo : IDeviceInfo
    {
        public string GetName()
        {
            return UIKit.UIDevice.CurrentDevice.Name;
        }
    }
}
