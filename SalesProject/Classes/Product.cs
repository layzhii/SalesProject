using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesProject.Classes
{
    public class Product
    {
        private string productCode;
        public string ProductCode
        {
            get { return productCode; }
        }
        private string productName;
        public string ProductName
        {
            get { return productName; }
        }
        private string isWeight;
        public string IsWeight
        {
            get { return isWeight; }
        }
        private string countPackage;
        public string CountPackage
        {
            get { return countPackage; }
        }

        public Product(string productCode, string productName, string isWeight, string countPackage)
        {
            this.productCode = productCode;
            this.productName = productName;
            this.isWeight = isWeight;
            this.countPackage = countPackage;
        }
    }
}
