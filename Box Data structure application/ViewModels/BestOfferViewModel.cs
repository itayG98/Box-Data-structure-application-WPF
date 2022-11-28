using BusinessLogic;
using BusinessLogic.Services;
using Caliburn.Micro;

namespace Box_Data_structure_application.ViewModels
{

    public partial class BestOfferViewModel : PropertyChangedBase
    {
        private readonly Store _store;
        public BestOfferViewModel(Store store)
        {
            _store = store;
        }
    }
}
