using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesProject.Classes
{
    public class Store
    {
        private int storeCode;
        public int StoreCode 
        {
            get { return storeCode; } 
        }
        private string storeName;

        public string StoreName
        {
            get { return storeName; }
        }
        public Store(int storeCode, string storeName)
        {
            this.storeCode = storeCode;
            this.storeName = storeName;
        }
    }
}
