using CoffeeShopApp.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopApp.Impl {
    public class Product : DescriptiveEntity {
        public decimal Price { get; set; }
        public decimal Cost { get; set; }

        public Product():base() {

        }

    }
}
