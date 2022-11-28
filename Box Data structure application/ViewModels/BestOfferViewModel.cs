using BusinessLogic;
using Caliburn.Micro;
using Model;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Box_Data_structure_application.ViewModels
{

    public partial class BestOfferViewModel : Screen
    {
        private readonly Store? _store;
        public BestOfferViewModel(Store store)
        {
            _store = store;
        }
    }
}
