using BusinessLogic;
using BusinessLogic.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box_Data_structure_application.ViewModels
{
    [INotifyPropertyChanged]

    public partial class GetOfferViewModel
    {
        private readonly Store _store;
        public GetOfferViewModel()
        {
            _store = StoreProviderService.Init;
        }
    }
}
