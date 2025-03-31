using System.Configuration;
using System.Data;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SolidShop.WPF.Services;
using SolidShop.WPF.ViewModels;
using SolidShop.WPF.Views;
using Wpf.Ui;
using Wpf.Ui.Abstractions;

namespace SolidShop.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        IHost _host;

        public App()
        {
            _host = Host.CreateDefaultBuilder()
                .ConfigureAppConfiguration(c =>
                {
                    c.AddJsonFile("appsettings.json", true);
                })
                .ConfigureServices(ConfigureService)
                .Build();
        }

        protected override async void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            await _host.StartAsync();
            ShowShellWindow();
        }

        private void ShowShellWindow()
        {
            var shellWindow = _host.Services.GetRequiredService<ShellWindow>();
            shellWindow.Show();
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            await _host.StopAsync();
            _host.Dispose();
            base.OnExit(e);
        }

        void ConfigureService(HostBuilderContext context, IServiceCollection services)
        {
            services.AddSingleton<ShellWindow>();
            services.AddSingleton<ShellViewModel>();
            services.AddSingleton<DashboardView>();
            services.AddSingleton<DashboardViewModel>();
            services.AddSingleton<SettingsView>();
            services.AddSingleton<SettingsViewModel>();

            services.AddSingleton<INavigationService, NavigationService>();
            services.AddSingleton<INavigationViewPageProvider, NavigationViewPageProvider>();

        }
    }

}
