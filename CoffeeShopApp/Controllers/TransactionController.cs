using CoffeeShopApp.Impl;
using CoffeeShopApp.WUI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopApp.Controllers {
    class TransactionController {

        public CoffeeShop NewCoffeeShop { get; set; }
        public string LogFile { get; set; }
        public string Message { get; set; }

        public object SelectedItem { get; set; }

        public TransactionController() {

        }

        public TransactionController(CoffeeShop coffeeShop, string logFile) {
            NewCoffeeShop = coffeeShop;
            LogFile = logFile;
        }
        public TransactionController(CoffeeShop coffeeShop, string logFile, object selecteditem) {
            NewCoffeeShop = coffeeShop;
            LogFile = logFile;
            SelectedItem = selecteditem;
        }
        public List<string> GetTransactionList() {
            List<string> transactionList = new List<string>();

            try {

                if (NewCoffeeShop?.Transactions != null) {
                    foreach (Transaction item in NewCoffeeShop.Transactions) {
                        transactionList.Add(string.Format("Date: {0} \t CustomerID: {1} \t TotalPrice: {2} € \t ID: {3}",
                                item.Date, item.TransactionCustomer.ID, item.TotalPrice, item.ID));
                    }
                }
                else {
                    Message = "No Transaction data exists!";
                }

            }
            catch (Exception ex) {
                Message = "Something wrong happened! Please send me the log file!";
                string path = Path.Combine(Environment.CurrentDirectory, LogFile);
                File.WriteAllText(path, ex.ToString());
            }

            return transactionList;
        }

        //Create 
        public void AddEntity(Transaction transaction) {

            NewCoffeeShop.Transactions.Add(transaction);

        }
        //Select record
        public object GetSelectedRecord(Guid id) {

            Object editObject = null;

            editObject = NewCoffeeShop.Transactions.Find(x => x.ID == id);

            return editObject;
        }

        //Delete
        public void DeleteSelectedRecord(Guid id) {

            NewCoffeeShop.Transactions.RemoveAll(x => x.ID == id);

        }

    }
}


