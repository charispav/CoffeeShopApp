using CoffeeShopApp.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopApp.Impl {
    public class Transaction : Entity {
        public DateTime Date { get; set; }
        public decimal TotalPrice { get; set; }
        public Guid CustomerID { get; }
        public Customer TransactionCustomer { get; set; }
        public List<TransactionLine> TransactionLines { get; set; }

        public decimal TotalCost { get; set; }

        public Transaction() {
            Customer customer = new Customer();
            TransactionCustomer = customer;
            Date = DateTime.Now;
            TransactionLines = new List<TransactionLine>();
        }
    }
}
