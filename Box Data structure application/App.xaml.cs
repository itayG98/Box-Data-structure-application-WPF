using Box_Data_structure_application.Views;
using BusinessLogic;
using BusinessLogic.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;


namespace Box_Data_structure_application
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly Store store;
        public App()
        {
            store = new Store();
            Services = ConfigureServices();
            this.InitializeComponent();
        }
        public Store Store => store;

        /// <summary>
        /// Gets the current <see cref="App"/> instance in use
        /// </summary>
        public new static App Current => (App)Application.Current;

        /// <summary>
        /// Gets the <see cref="IServiceProvider"/> instance to resolve application services.
        /// </summary>
        public IServiceProvider Services { get; }



        /// <summary>
        /// Configures the services for the application.
        /// </summary>
        private static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddSingleton<StoreProviderService>();
            services.AddScoped<BestOfferView>();
            services.AddScoped<GetOfferView>();
            services.AddScoped<StoreStockView>();

            return services.BuildServiceProvider();
        }
    }
}
