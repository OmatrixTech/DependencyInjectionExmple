using DependencyInjectionExmple.Implementation;
using DependencyInjectionExmple.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace DependencyInjectionExmple
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static IServiceProvider serviceProvider;

        public App()
        {
            // Set up DI container
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            // Build the service provider
            serviceProvider = serviceCollection.BuildServiceProvider();
        }

        private void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<MainWindowViewModel>();
            // Register your services and dependencies here
            services.AddSingleton<ITestingService, TestingService>(); // Example registration
        }

       
    }

}
