using CoffeeShopApp.Impl;
using CoffeeShopApp.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopApp.WUI {
    public partial class ViewForm : Form {
        public EntityTypeEnum Type { get; set; }
        public CoffeeShop MasterData { get; set; }
        public List<string> ViewData = new List<string>();
        public string LogFile { get; set; }


        public ViewForm() {
            InitializeComponent();
        }

        private void ViewForm_Load(object sender, EventArgs e) {
            RefreshList();
        }

        public void RefreshList() {
            switch (Type) {
                case EntityTypeEnum.Employee:
                    this.Text = "Employees View Form";
                    btnDelete.Text = "Fire Employee";
                    EmployeeController employeeController = new EmployeeController() {
                        NewCoffeeShop = MasterData,
                        LogFile = LogFile
                    };

                    ViewData = employeeController.GetEmployeeList();
                    
                    break;
                case EntityTypeEnum.Transaction:
                    this.Text = "Transactions View Form";
                    TransactionController transactionController = new TransactionController(MasterData, LogFile);
                    
                    ViewData = transactionController.GetTransactionList();
                    break;
                case EntityTypeEnum.Product:
                    this.Text = "Products View Form";
                    ProductController productController = new ProductController() {
                        NewCoffeeShop = MasterData,
                        LogFile = LogFile
                    };

                    ViewData = productController.GetProductList();
                    break;
                default:
                    break;
            }


            ctrlViewList.Items.Clear();
            foreach (string item in ViewData) {
                ctrlViewList.Items.Add(item);
            }

        }

        private void Sort() {
            switch (Type) {
                case EntityTypeEnum.Employee:
                    List<Employee> sortedEmployees = MasterData.Employees.OrderBy(x => x.Surname).ToList();
                    ctrlViewList.Items.Clear();


                    foreach (Employee item in sortedEmployees) {
                        ctrlViewList.Items.Add(string.Format("Name: {0} \t Surname: {1} \t Salary: {2} € \t Date: {3} \t ID: {4} \t DismissDate: {5}",
                                item.Name, item.Surname, item.Salary, item.Date, item.ID, item.DismissDate));
                    }
                        break;
                case EntityTypeEnum.Transaction:
                    List<Transaction> sortedTransactions = MasterData.Transactions.OrderByDescending(x => x.Date).ToList();
                    ctrlViewList.Items.Clear();


                    foreach (Transaction item in sortedTransactions) {
                        ctrlViewList.Items.Add(string.Format("Date: {0} \t CustomerID: {1} \t TotalPrice: {2} € \t ID: {3}",
                                item.Date, item.TransactionCustomer.ID, item.TotalPrice, item.ID));

                    }

                    break;
                case EntityTypeEnum.Product:
                    List<Product> sortedProducts = MasterData.Products.OrderBy(x => x.Description).ToList();
                    ctrlViewList.Items.Clear();


                    foreach (Product item in sortedProducts) {
                        ctrlViewList.Items.Add(string.Format("Code: {0} \t Description: {1} \t Price: {2} €  \t Cost: {3} € \t ID: {4}",
                            item.Code, item.Description, item.Price, item.Cost, item.ID));
                    }
                    break;

                default:
                    break;
            }

        }
        private void btnEdit_Click(object sender, EventArgs e) {
            EditView();
        }

        private void EditView() {
            Guid id = GetListID();

            object editObject = null;
            if (id != Guid.Empty) {
                switch (Type) {
                    case EntityTypeEnum.Employee:

                        EmployeeController employeeController = new EmployeeController(MasterData, LogFile, ctrlViewList.SelectedItem);
                        editObject = employeeController.GetSelectedRecord(id);

                        break;
                    case EntityTypeEnum.Product:
                        ProductController productController = new ProductController(MasterData, LogFile, ctrlViewList.SelectedItem);
                        editObject = productController.GetSelectedRecord(id);

                        break;
                    default:
                        break;
                }
                EditForm form = new EditForm();
                form.Type = Type;
                form.EditObject = editObject;
                form.ShowDialog();
                RefreshList();

            }
            else {
                MessageBox.Show("Please select a record!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            DeleteViewLIne();
        }

        private void DeleteViewLIne() {
            Guid id = GetListID();

            if (id != Guid.Empty) {
                switch (Type) {
                    case EntityTypeEnum.Employee:
                        EmployeeController employeeController = new EmployeeController(MasterData, LogFile, ctrlViewList.SelectedItem);
                        Employee editObject = null;
                        editObject =(Employee) employeeController.GetSelectedRecord(id);
                        editObject.DismissDate = DateTime.Now;

                        break;
                    case EntityTypeEnum.Transaction:
                        TransactionController transactionController = new TransactionController(MasterData, LogFile, ctrlViewList.SelectedItem);
                        transactionController.DeleteSelectedRecord(id);
                        break;
                    case EntityTypeEnum.Product:

                        ProductController productController = new ProductController(MasterData, LogFile, ctrlViewList.SelectedItem);
                        productController.DeleteSelectedRecord(id);

                        break;
                    default:
                        break;

                }
                RefreshList();
            }


            else {
                MessageBox.Show("Please select a record!");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            AddFromView();

        }

        private void AddFromView() {
            EditForm form = new EditForm();
            form.Type = Type;

            switch (Type) {
                case EntityTypeEnum.Employee:

                    Employee employeeEntity = new Employee();
                    form.NewCoffeeShop = MasterData;
                    form.EditObject = employeeEntity;
                    
                    form.Show();

                    break;
                case EntityTypeEnum.Transaction:
                   
                    Transaction transaction = new Transaction();

                    TransactionEditForm transactionEditForm = new TransactionEditForm();

                    transactionEditForm.MasterData = MasterData;

                    transactionEditForm.NewTransaction = transaction;
                    transactionEditForm.Show();

                    break;
                case EntityTypeEnum.Product:

                    Product productEntity = new Product();
                    form.EditObject = productEntity;
                    form.NewCoffeeShop = MasterData;               
                    form.Show();
              
                    break;
                default:
                    break;
            }
            RefreshList();
        }

        private void btnRefresh_Click(object sender, EventArgs e) {

            RefreshList();
        }

        private void viewTransactionLines_Click(object sender, EventArgs e) {

            ViewTransactionLines();
        }

        private void ViewTransactionLines() {

            TransactionController transactionController = new TransactionController(MasterData, LogFile, ctrlViewList.SelectedItem);
            TransactionViewForm transactionViewForm = new TransactionViewForm();

            Guid id = GetListID();
            if (id != Guid.Empty) {

                Transaction selectedObject = (Transaction)transactionController.GetSelectedRecord(id);

                transactionViewForm.TransactionDetails = selectedObject;

                transactionViewForm.Show();
            }
            else {
                MessageBox.Show("Please select a record!");
            }
        }

        public Guid GetListID() {

            if (ctrlViewList.SelectedItem != null) {
                object listSelection = ctrlViewList.SelectedItem;

                List<string> listParse = listSelection.ToString().Split('\t').ToList();
                Guid id = Guid.Empty;
                switch (Type) {
                    case EntityTypeEnum.Employee:
                        id = Guid.Parse(listParse[4].Substring(4));
                        break;
                    case EntityTypeEnum.Transaction:
                        id = Guid.Parse(listParse[3].Substring(4));
                        break;
                    case EntityTypeEnum.Product:
                        id = Guid.Parse(listParse[4].Substring(4));
                        break;
                    default:
                        break;
                }

                return id;
            }
            else {
                return Guid.Empty;
            }

        }

        private void button1_Click(object sender, EventArgs e) {
            Sort();
        }

        private void ctrlViewList_DoubleClick(object sender, EventArgs e) {
            
            EditView();
        }

    }
}
