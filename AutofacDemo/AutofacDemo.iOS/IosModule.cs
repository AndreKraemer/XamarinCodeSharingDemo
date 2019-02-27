using Autofac;

namespace AutofacDemo.iOS
{
    public class IosModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<IoSDeviceInfo>().As<IDeviceInfo>();
        }
    }
}