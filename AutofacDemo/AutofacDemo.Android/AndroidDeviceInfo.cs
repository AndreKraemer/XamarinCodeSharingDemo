namespace AutofacDemo.Droid
{
    public class AndroidDeviceInfo : IDeviceInfo
    {
        public string GetName()
        {
            return Android.OS.Build.Device;
        }
    }
}