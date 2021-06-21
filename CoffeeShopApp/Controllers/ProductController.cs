using CoffeeShopApp.WUI;
using CoffeeShopApp.Impl;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopApp.Controllers {
    public class ProductController {
        public CoffeeShop NewCoffeeShop { get; set; }
        public string LogFile { get; set; }
        public string Message { get; set; }

        public object SelectedItem { get; set; }

        public ProductController() {

        }

        public ProductController(CoffeeShop coffeeShop, string logFile) {
            NewCoffeeShop = coffeeShop;
            LogFile = logFile;
        }

        public ProductController(CoffeeShop coffeeShop, string logFile, object selecteditem) {
            NewCoffeeShop = coffeeShop;
            LogFile = logFile;
            SelectedItem = selecteditem;
        }
        // Get - Read       

        public List<string> GetProductList() {
            List<string> productList = new List<string>();


            try {

                if (NewCoffeeShop?.Products != null) {
                    foreach (Product item in NewCoffeeShop.Products) {
                        productList.Add(string.Format("Code: {0} \t Description: {1} \t Price: {2} € \t Cost: {3} € \t ID: {4}",
                            item.Code, item.Description, item.Price, item.Cost, item.ID));
                    }
                }
                else {
                    Message = "No product data exists!";
                }

            }
            catch (Exception ex) {
                Message = "Something wrong happened! Please send me the log file!";
                string path = Path.Combine(Environment.CurrentDirectory, LogFile);
                File.WriteAllText(path, ex.ToString());
            }

            return productList;
        }

        // Post - Create
        public void AddEntity(Product productEntity) {

            NewCoffeeShop.Products.Add(productEntity);

        }

        //Select records

        public object GetSelectedRecord(Guid id) {

            Object editObject = null;

            editObject = NewCoffeeShop.Products.Find(x => x.ID == id);

            return editObject;
        }
        //Delete
        public void DeleteSelectedRecord(Guid id) {

            NewCoffeeShop.Products.RemoveAll(x => x.ID == id);

        }
    }
}







