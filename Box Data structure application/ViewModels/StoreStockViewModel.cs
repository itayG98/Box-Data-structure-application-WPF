using BusinessLogic;
using BusinessLogic.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box_Data_structure_application.ViewModels
{
    [INotifyPropertyChanged]
    public partial class StoreStockViewModel
    {
        private readonly Store _store;
        StoreProviderService _storeProvider;

        [ObservableProperty]
        private List<Box> boxes;

        public StoreStockViewModel(StoreProviderService storeProvider)
        {
            _storeProvider = storeProvider;
            _store = _storeProvider.Init;
            foreach (Box b in _store.GetAll())
                Boxes.Add(b);
        }
    }
}
    