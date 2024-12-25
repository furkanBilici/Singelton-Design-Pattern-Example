using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Class
{
    internal class CustomerManager
    {
        private static CustomerManager _customerManager;

        private CustomerManager() { }
        public static CustomerManager CreateAsSingleton ()
        {
            if (_customerManager == null)
            {
                _customerManager= new CustomerManager();    
            }
            return _customerManager;
        }
    }
}
