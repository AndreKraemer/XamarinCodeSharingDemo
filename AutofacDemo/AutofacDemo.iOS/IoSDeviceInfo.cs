namespace AutofacDemo.iOS
{
    public class IoSDeviceInfo : IDeviceInfo
    {
        public string GetName()
        {
            return UIKit.UIDevice.CurrentDevice.Name;
        }
    }
}