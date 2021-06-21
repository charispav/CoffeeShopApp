using CoffeeShopApp.WUI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeShopApp.Impl;

namespace CoffeeShopApp.Controllers {
    public class EmployeeController {
        public CoffeeShop NewCoffeeShop { get; set; }
        public string LogFile { get; set; }
        public string Message { get; set; }

        public object SelectedItem { get; set; }

        public EmployeeController() {

        }

        public EmployeeController(CoffeeShop coffeeShop, string logFile) {
            NewCoffeeShop = coffeeShop;
            LogFile = logFile;
        }

        public EmployeeController(CoffeeShop coffeeShop, string logFile, object selecteditem) {
            NewCoffeeShop = coffeeShop;
            LogFile = logFile;
            SelectedItem = selecteditem;
        }
        // Get - Read       

        public List<string> GetEmployeeList() {
            List<string> employeeList = new List<string>();

            try {

                if (NewCoffeeShop?.Employees != null) {
                    foreach (Employee item in NewCoffeeShop.Employees) {
                        employeeList.Add(string.Format("Name: {0} \t Surname: {1} \t Salary: {2} € \t Date: {3} \t ID: {4} \t DismissDate: {5}",
                                item.Name, item.Surname, item.Salary, item.Date, item.ID, item.DismissDate));
                    }
                }
                else {
                    Message = "No employees data exists!";
                }

            }
            catch (Exception ex) {
                Message = "Something wrong happened! Please send me the log file!";
                string path = Path.Combine(Environment.CurrentDirectory, LogFile);
                File.WriteAllText(path, ex.ToString());
            }

            return employeeList;
        }

        // Post - Create
        public void AddEntity(Employee employeeEntity) {

            NewCoffeeShop.Employees.Add(employeeEntity);

        }
        
        //Select record
        public object GetSelectedRecord(Guid id) {

            Object editObject = null;

            editObject = NewCoffeeShop.Employees.Find(x => x.ID == id);

            return editObject;
        }

        //Delete
        public void DeleteSelectedRecord(Guid id) {

            NewCoffeeShop.Employees.RemoveAll(x => x.ID == id);
        }

    }
}






