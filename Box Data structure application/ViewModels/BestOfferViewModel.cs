using BusinessLogic;
using Caliburn.Micro;
using Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Box_Data_structure_application.ViewModels
{

    public partial class BestOfferViewModel : Screen
    {
        private readonly Store? _store;
        private readonly BindableCollection<Box> _boxes;
        public BindableCollection<Box> Boxes => _boxes;
        public BestOfferViewModel(Store store)
        {
            _boxes = new BindableCollection<Box>();
            _store = store;
            _store.GetBoxesEvent += onRequestOffer;
        }

        private void onRequestOffer(double width, double height, int count)
        {
            if (_store != null) 
            { 
            _boxes.Clear(); 
            foreach (Box box in _store.GetBestOffer(width,height,count))
                _boxes.Add(box);
            NotifyOfPropertyChange(nameof(Boxes));
            }
        }
    }
}
