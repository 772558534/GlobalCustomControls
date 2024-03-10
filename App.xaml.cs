using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Data;
using System.Windows;

namespace GlobalCustomControls
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public IServiceProvider? Services{ get;}

        public static new App Current =>(App)Application.Current;

        public App()
        {
            var container = new ServiceCollection();

            container.AddSingleton<MainWindow>();
            container.AddSingleton<MainViewModel>();
            //container.AddSingleton<SystemPage1>();
            //container.AddSingleton<ProjectPage1_1>();
            //container.AddSingleton<ProjectPage1_2>();
            //container.AddSingleton<ProcessPage1_1_1>();
            //container.AddSingleton<ProcessPage1_1_2>();
            //container.AddSingleton<ProcessPage1_1_3>();
            //container.AddSingleton<ProcessPage1_2_1>();
            //container.AddSingleton<ProcessPage1_2_2>();
            //container.AddSingleton<ProcessPage1_2_3>();
            //container.AddSingleton<SystemPage2>();

            Services= container.BuildServiceProvider();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            MainWindow =Services?.GetRequiredService<MainWindow>();
            MainWindow?.Show();
        }
    }

}
