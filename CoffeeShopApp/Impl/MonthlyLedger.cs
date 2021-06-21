using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopApp.Impl {
    public class MonthlyLedger {
        public decimal Income { get; set; }
        public decimal Expenses { get; set; }
        public decimal Total { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public DateTime DateChecked { get; set; }
        public MonthlyLedger() {

        }

    }
}
