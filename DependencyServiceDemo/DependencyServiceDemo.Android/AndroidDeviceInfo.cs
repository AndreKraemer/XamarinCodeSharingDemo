using DependencyServiceDemo.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(AndroidDeviceInfo))]
namespace DependencyServiceDemo.Droid
{
    public class AndroidDeviceInfo : IDeviceInfo
    {
        public string GetName()
        {
            return Android.OS.Build.Device; ;
        }
    }
}
