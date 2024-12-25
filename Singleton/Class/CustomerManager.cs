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
        static object _lockObject=new object();
        

        private CustomerManager() { }
        public static CustomerManager CreateAsSingleton ()//bu fonksiyon sayesinde nesne sadece bir kez üretilmiş oluyor ve bir nesne üzerinden çalışılmış oluyor
        {
            lock (_lockObject)// thread safe singleton için
            {
                if (_customerManager == null)
                {
                    _customerManager = new CustomerManager();
                }
            }
            return _customerManager;
        }

        public void Save()
        {
            Console.WriteLine("Saved");
        }
    }
}
