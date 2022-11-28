using BusinessLogic;
using Caliburn.Micro;
using Model;
using System;

namespace Box_Data_structure_application.ViewModels
{
    public partial class GetOfferViewModel : PropertyChangedBase
    {
        private readonly Store _store;
        private Box _box = new Box(1, 1, 1);

        public GetOfferViewModel(Store store)
        {
            _store = store;
        }

        public double Width
        {
            get { return _box.Width; }
            set
            {
                if (value <= 0)
                    throw new ApplicationException("Must be positive number");
                else
                    _box.Width = value;
            }
        }
        public double Height
        {
            get { return _box.Height; }
            set
            {
                if (value <= 0)
                    throw new ApplicationException("Must be positive number");
                else
                    _box.Height = value;
            }
        }
        public int Count
        {
            get { return _box.Count; }
            set
            {
                if (value <= 0)
                    throw new ApplicationException("Must be positive number");
                else
                    _box.Count = value;
            }
        }
        public bool CanGetMe
        {
            get
            {
                return Width != default &&
                Height != default &&
                Count != default;
            }
        }
        public void GetMe()
        {
            if (Width != default &&
                Height != default &&
                Count != default)
                _store.GetBoxes(Width, Height, Count);
        }
    }
}
