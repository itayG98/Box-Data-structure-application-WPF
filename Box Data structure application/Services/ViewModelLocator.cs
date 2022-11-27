using Box_Data_structure_application.ViewModels;
using BusinessLogic.Services;
using CommonServiceLocator;
using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Box_Data_structure_application.Services
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            Ioc.Default.ConfigureServices(
                new ServiceCollection()
            .AddSingleton<MainViewModel>()
            .AddSingleton<StoreStockViewModel>().
            AddSingleton<GetOfferViewModel>() 
            .AddSingleton<BestOfferViewModel>()
            .BuildServiceProvider());
        }

        public MainViewModel Main => ServiceLocator.Current.GetInstance<MainViewModel>();
        public StoreStockViewModel StoreStock =>
            ServiceLocator.Current.GetInstance<StoreStockViewModel>();  
        public GetOfferViewModel GetOffer =>
            ServiceLocator.Current.GetInstance<GetOfferViewModel>();  
        public BestOfferViewModel BestOffer =>
            ServiceLocator.Current.GetInstance<BestOfferViewModel>();

    }
}

