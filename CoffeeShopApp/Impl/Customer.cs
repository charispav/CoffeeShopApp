using CoffeeShopApp.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopApp.Impl {
    public class Customer : DescriptiveEntity {

        public Customer() {
            Code = "001";
            Description = "Retail Customer";
        }
    }
}
