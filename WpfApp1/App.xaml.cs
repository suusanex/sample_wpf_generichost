using System.Configuration;
using System.Data;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IHost? _host;

        private async void OnStartup(object sender, StartupEventArgs e)
        {
            _host = Host.CreateDefaultBuilder(e.Args)
                .ConfigureServices(collection =>
                {
                    collection.AddHostedService<ApplicationHostService>();
                    collection.AddTransient<MainWindow>();
                })
                .Build();

            await _host.StartAsync();
        }

        private void OnExit(object sender, ExitEventArgs e)
        {

        }
    }

}
