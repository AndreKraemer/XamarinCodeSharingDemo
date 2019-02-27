using Autofac;
using Autofac.Core;

namespace AutofacDemo.Droid
{
    public class AndroidModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AndroidDeviceInfo>().As<IDeviceInfo>();
        }
    }
}