using CoffeeShopApp.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopApp.Impl {
    public class Business : Entity {
        public string Name { get; set; }
        public Business() : base() {

        }
    }
}
