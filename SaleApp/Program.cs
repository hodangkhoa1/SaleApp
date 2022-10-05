using Microsoft.Extensions.Configuration;

namespace SaleApp
{
    internal static class Program
    {
        public static string ConnectionString;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            var configuration = builder.Build();

            ConnectionString = configuration.GetSection("ConnectionStrings").GetSection("ProductManagementCs").Value;

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new SplashScreen());
        }
    }
}