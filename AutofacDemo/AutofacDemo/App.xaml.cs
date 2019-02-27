using System;
using Autofac;
using Autofac.Core;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace AutofacDemo
{
    public partial class App : Application
    {
        public static IContainer Container { get; private set; }
        public App(IModule[] plattformModules)
        {
            InitializeComponent();

            var container = CreateContainer(plattformModules);
            MainPage = container.Resolve<MainPage>();
        }

        private IContainer CreateContainer(IModule[] plattformModules)
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<MainPage>().AsSelf();
            foreach (var module in plattformModules)
            {
                builder.RegisterModule(module);
            }

            return builder.Build();
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
