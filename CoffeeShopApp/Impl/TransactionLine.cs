using CoffeeShopApp.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopApp.Impl {
    public class TransactionLine : Entity {
        public int Quantity { get; set; }

        public decimal TransactionLinePrice { get; set; }

        public Guid ProductID { get; set; }

        public string ProductDescription { get; set; }

        public decimal ProductsCost { get; set; }
        public TransactionLine():base() {

        }

        public TransactionLine(int quantity, decimal price, Guid productID, string productDescription) :
            base() {
            Quantity = quantity;
            TransactionLinePrice = price;
            ProductID = productID;
            ProductDescription = productDescription;

        }
        public string PrintTransactionLine() {
            return String.Format("{0} x {1}  = {2} €", ProductDescription, Quantity, TransactionLinePrice);
        }
    }
}

