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

        [ListBindable(true)]
        private ObservableCollection <Box>boxes = new();

        public StoreStockViewModel()
        {
            _store = _store = StoreProviderService.Init;
            foreach (Box b in _store.GetAll())
                Boxes.Add(b);
        }

        public ObservableCollection<Box> Boxes { get => boxes; }
    }
}
    