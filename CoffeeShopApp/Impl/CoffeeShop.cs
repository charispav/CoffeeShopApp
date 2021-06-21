using CoffeeShopApp.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopApp.Impl {
    public class CoffeeShop : Business {
        public List<Product> Products { get; set; }
        public List<Employee> Employees { get; set; }
        public List<Transaction> Transactions { get; set; }
        public List<MonthlyLedger> MonthlyLedgers { get; set; }

        public CoffeeShop() : base() {
            Products = new List<Product>();
            Employees = new List<Employee>();
            Transactions = new List<Transaction>();
            MonthlyLedgers = new List<MonthlyLedger>();
        }
    }
}
