using BusinessLogic;
using BusinessLogic.Services;
using Model;

namespace Services
{
    public class BoxesService
    {
        private readonly Store _store;
        public Action<double, double, int>? GetBoxesEvent;
        public BoxesService()
        {
            _store = StoreProviderService.Init;
        }

        public Task<IEnumerable<Box>> GetBestOffer(double width, double height, int count)
        
                => Task.Run(() =>_store.GetBestOffer(width, height, count));
        

        public Task GetBoxes(double width, double height, int count)
                => Task.Run(() =>GetBoxesEvent?.Invoke(width, height, count));
    }
}