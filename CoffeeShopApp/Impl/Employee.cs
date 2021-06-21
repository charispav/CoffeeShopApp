using CoffeeShopApp.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopApp.Impl {
    public class Employee : Entity {

        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal Salary { get; set; }
        public DateTime Date { get; set; }

        public DateTime DismissDate { get; set; }
        public Employee() : base()
        {
            Date = DateTime.Now;
            DismissDate = DateTime.MaxValue;

        }
    }
}
