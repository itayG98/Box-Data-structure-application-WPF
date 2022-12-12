using Caliburn.Micro;
using Model;
using Services;

namespace Box_Data_structure_application.ViewModels
{

    public partial class BestOfferViewModel : Screen
    {
        private readonly BoxesService _boxesService;
        private readonly BindableCollection<Box> _boxes;
        public BindableCollection<Box> Boxes => _boxes;
        public BestOfferViewModel(BoxesService boxesService)
        {
            _boxes = new BindableCollection<Box>();
            _boxesService = boxesService;
            _boxesService.GetBoxesEvent += OnRequestOffer;
        }

        private async void OnRequestOffer(double width, double height, int count)
        {
            _boxes.Clear();
            foreach (Box box in await _boxesService.GetBestOffer(width, height, count))
                _boxes.Add(box);
            NotifyOfPropertyChange(nameof(Boxes));
        }
    }
}

