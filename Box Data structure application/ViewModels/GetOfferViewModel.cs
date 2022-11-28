using BusinessLogic;
using BusinessLogic.Services;
using Caliburn.Micro;
using System.Windows.Ink;

namespace Box_Data_structure_application.ViewModels
{


    public partial class GetOfferViewModel : PropertyChangedBase
    {
        private readonly Store _store;
        public GetOfferViewModel(Store store)
        {
            _store = store;
        }
    }
}
