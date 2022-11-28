using BusinessLogic;
using BusinessLogic.Services;
using Caliburn.Micro;
using Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace Box_Data_structure_application.ViewModels
{
    public partial class StoreStockViewModel : PropertyChangedBase
    {
        private readonly Store _store;
        private readonly ObservableCollection<Box> _boxes;

        public StoreStockViewModel(Store store)
        {
            _store  = store;
            _boxes = new ObservableCollection<Box>();
            foreach (Box b in _store.GetAll())
                Boxes.Add(b);
        }

        public ObservableCollection<Box> Boxes
        {
            get { return _boxes; }
            set
            {
                _boxes.Clear();
                _boxes.Concat(value);
                NotifyOfPropertyChange(nameof(Boxes));
            }
        }
    }
}


