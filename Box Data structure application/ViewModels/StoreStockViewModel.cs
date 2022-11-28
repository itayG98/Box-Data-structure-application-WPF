using BusinessLogic;
using BusinessLogic.Services;
using Caliburn.Micro;
using Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace Box_Data_structure_application.ViewModels
{
    public partial class StoreStockViewModel : Screen
    {
        private readonly Store _store;
        private readonly BindableCollection<Box> _boxes;

        public StoreStockViewModel(Store store)
        {
            _store  = store;
            _boxes = new BindableCollection<Box>();
            foreach (Box b in _store.GetAll())
                Boxes.Add(b);
        }

        public BindableCollection<Box> Boxes
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


