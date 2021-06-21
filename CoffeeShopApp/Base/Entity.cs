using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopApp.Base {
    public class Entity {

        public Guid ID { get; }

        public Entity() {

            ID = Guid.NewGuid();
        }
    }
}
