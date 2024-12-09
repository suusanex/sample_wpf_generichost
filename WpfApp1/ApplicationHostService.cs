using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;

namespace WpfApp1
{
    public class ApplicationHostService(IServiceProvider _serviceProvider) : IHostedService
    {
        public async Task StartAsync(CancellationToken cancellationToken)
        {
            _MainWindow = _serviceProvider.GetRequiredService<MainWindow>();
            _MainWindow.Show();
            await Task.CompletedTask;
        }

        private Window? _MainWindow;

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
        }
    }
}
