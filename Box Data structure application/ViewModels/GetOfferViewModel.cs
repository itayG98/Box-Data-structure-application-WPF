using BusinessLogic;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box_Data_structure_application.ViewModels
{
    [INotifyPropertyChanged]

    internal partial class GetOfferViewModel
    {
        private readonly Store _store;
        public GetOfferViewModel(Store store)
        {
            _store = store;
        }
    }
}
