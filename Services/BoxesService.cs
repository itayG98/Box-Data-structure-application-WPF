using BusinessLogic;
using BusinessLogic.Services;
using Model;

namespace Services
{
    public class BoxesService
    {
        private readonly Store _store;
        public Action<double, double, int> GetBoxesEvent;
        public BoxesService()
        {
            _store = StoreProviderService.Init;
        }

        public IEnumerable<Box> GetBestOffer(double width, double height, int count)
        
                => _store.GetBestOffer(width, height, count);
        

        public void GetBoxes(double width, double height, int count)
                => GetBoxesEvent?.Invoke(width, height, count);
    }
}