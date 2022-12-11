using Box_Data_structure_application.ViewModels;
using Caliburn.Micro;
using System.Collections.Generic;
using System.Reflection;
using System;
using System.Windows;
using BusinessLogic;
using BusinessLogic.Services;
using Services;

namespace Box_Data_structure_application.Services
{
    public class Boostraper : BootstrapperBase
    {
        private SimpleContainer container;
        public readonly Store store;
        public Boostraper()
        {
            store = StoreProviderService.Init;
            LogManager.GetLog = type => new DebugLog(type);
            Initialize();
        }
        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewForAsync<HomePageViewModel>();
        }

        protected override void Configure()
        {
            container = new SimpleContainer();
            container.Instance<Store>(store);
            container.Singleton<BoxesService>();
            container.Singleton<IWindowManager, WindowManager>();
            container.Singleton<IEventAggregator, EventAggregator>();
            container.PerRequest<BestOfferViewModel>("BestOffer");
            container.PerRequest<GetOfferViewModel>("GetOffer");
            container.PerRequest<StoreStockViewModel>("StoreStock");
            container.PerRequest<NavigationBarViewModel>("NavBar");
            container.Singleton<HomePageViewModel>("HomePage");
        }

        protected override object GetInstance(Type service, string key)
           => container.GetInstance(service, key);


        protected override IEnumerable<object> GetAllInstances(Type service)
            => container.GetAllInstances(service);


        protected override void BuildUp(object instance)
            => container.BuildUp(instance);


        protected override IEnumerable<Assembly> SelectAssemblies()
            => new[] { Assembly.GetExecutingAssembly() };

        public StoreStockViewModel StoreStock => (StoreStockViewModel)GetInstance(typeof(StoreStockViewModel), "StoreStock");   
        public GetOfferViewModel GetOffer => (GetOfferViewModel)GetInstance(typeof(GetOfferViewModel), "GetOffer");  
        public BestOfferViewModel BestOffer => (BestOfferViewModel)GetInstance(typeof(BestOfferViewModel), "BestOffer");    
        public NavigationBarViewModel NavBar => (NavigationBarViewModel)GetInstance(typeof(NavigationBarViewModel), "NavBar");

    }
}

