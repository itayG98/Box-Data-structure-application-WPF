using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class StoreProviderService
    {
        private Store _store;
        public Store Init
        {
            get
            {
                if (_store != null)
                    return _store;
                else
                    return _store = new Store();
            }
        }
        private StoreProviderService()
        {

        }
    }
}
