using Assignment.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var serviceProvider = ConfigureServices();

            serviceProvider.GetRequiredService<ITextFilterApplication>().Run();
            
            
        }

        private static ServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();
            // Register Text Filter service
            services.AddSingleton<ITextFilterService, TextFilterService>();
            
            // Register File Reader service
            services.AddSingleton<IFileReaderService, FileReaderService>();

            // Register this application

            services.AddTransient<ITextFilterApplication,TextFilterApplication>();

            return services.BuildServiceProvider();
        }
    }
}
