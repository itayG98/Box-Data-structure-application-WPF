using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;
using BusinessLogic.Services;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Box_Data_structure_application.ViewModels
{
    [INotifyPropertyChanged]
    public partial class BestOfferViewModel
    {
        private readonly Store _store;
        public BestOfferViewModel()
        {
            _store = StoreProviderService.Init;
        }
    }
}
