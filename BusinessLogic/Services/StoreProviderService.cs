namespace BusinessLogic.Services
{
    public static class StoreProviderService
    {
        private static Store? _store;
        public static Store Init
        {
            get
            {
                if (_store != null)
                    return _store;
                else
                    return _store = new Store();
            }
        }
    }
}
