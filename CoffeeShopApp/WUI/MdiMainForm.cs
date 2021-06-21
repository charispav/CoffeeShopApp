using CoffeeShopApp.Impl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace CoffeeShopApp.WUI {
    public partial class MdiMainForm : Form {
        private const string _LogFile = "Log.txt";
        private const string _JsonFile = "CoffeeShopData.json";

        private CoffeeShop NewCoffeeShop = new CoffeeShop();
        public Storage NewStorage = new Storage();
        public MdiMainForm() {
            InitializeComponent();
        }

        private void MdiMainForm_Load(object sender, EventArgs e) {

            NewStorage.DeserializeFromJson();
            NewCoffeeShop = NewStorage.NewCoffeeShop;

        }

        private void productAddToolStripMenuItem_Click(object sender, EventArgs e) {

            AddProduct();
        }

        private void AddProduct() {

            Product productEntity = new Product();
            EditForm productForm = new EditForm();

            productForm.Type = EntityTypeEnum.Product;
            productForm.EditObject = productEntity;
            productForm.MdiParent = this;
            productForm.NewCoffeeShop = NewCoffeeShop;

            productForm.Show();

        }

        private void viewProductsToolStripMenuItem_Click(object sender, EventArgs e) {
            ViewProduct();
        }

        private void ViewProduct() {
            ViewForm viewForm = new ViewForm();
            viewForm.MdiParent = this;

            viewForm.Type = EntityTypeEnum.Product;
            viewForm.MasterData = NewCoffeeShop;

            viewForm.Show();
        }


        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            NewStorage.SerializeToJson();
            NewStorage.NewCoffeeShop = NewCoffeeShop;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e) {
            AddEmployee();
        }

        private void AddEmployee() {

            Employee employeeEntity = new Employee();
            EditForm employeeForm = new EditForm();

            employeeForm.MdiParent = this;
            employeeForm.Type = EntityTypeEnum.Employee;
            employeeForm.NewCoffeeShop = NewCoffeeShop;
            employeeForm.EditObject = employeeEntity;
            employeeForm.Show();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e) {
            ViewEmployee();
        }

        private void ViewEmployee() {
            ViewForm viewForm = new ViewForm();
            viewForm.MdiParent = this;

            viewForm.Type = EntityTypeEnum.Employee;
            viewForm.MasterData = NewCoffeeShop;
            viewForm.Show();
        }

        private void addTransaction_Click(object sender, EventArgs e) {
            AddTransaction();

        }

        private void AddTransaction() {

            Transaction transaction = new Transaction();

            TransactionEditForm transactionEditForm = new TransactionEditForm();

            transactionEditForm.MdiParent = this;

            transactionEditForm.MasterData = NewCoffeeShop;

            transactionEditForm.NewTransaction = transaction;
            transactionEditForm.Show();

        }

        private void viewTransactions_Click(object sender, EventArgs e) {
            ViewTransaction();
        }

        private void ViewTransaction() {
            ViewForm viewForm = new ViewForm();
            viewForm.MdiParent = this;

            viewForm.Type = EntityTypeEnum.Transaction;
            viewForm.MasterData = NewCoffeeShop;
            viewForm.btnEdit.Visible = false;
            viewForm.viewTransactionLines.Visible = true;

            viewForm.Show();
        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e) {
            ViewMonthlyLedger();
        }

        private void ViewMonthlyLedger() {
            MonthlyLedgerForm monthlyLedger = new MonthlyLedgerForm();
            monthlyLedger.MdiParent = this;
            monthlyLedger.MasterData = NewCoffeeShop;

            monthlyLedger.Show();
        }



        private void CustomizeDesign() {
            panelQuickStartMenu.Visible = false;
        }

        private void HideSubMenu() {
            if (panelQuickStartMenu.Visible == true)
                panelQuickStartMenu.Visible = false;

        }

        private void ShowSubMenu(Panel submenu) {
            if (submenu.Visible == false) {
                HideSubMenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void btnQuickStart_Click(object sender, EventArgs e) {
            ShowSubMenu(panelQuickStartMenu);
        }

        private void sidePanel1_Click(object sender, EventArgs e) {

        }

        private void btnNewProduct_Click(object sender, EventArgs e) {
            AddProduct();
        }

        private void btnNewEmployee_Click(object sender, EventArgs e) {
            AddEmployee();
        }

        private void btnNewTransaction_Click(object sender, EventArgs e) {
            AddTransaction();
        }
    }
}
