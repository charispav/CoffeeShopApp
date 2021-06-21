using CoffeeShopApp.Controllers;
using CoffeeShopApp.Impl;
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
    public partial class TransactionEditForm : Form {

        public CoffeeShop MasterData { get; set; }
        public List<string> ViewData = new List<string>();
        public Transaction  NewTransaction { get; set; }
        public string LogFile { get; set; }

        public decimal TotalPrice { get; set; }
        public decimal TotalCost { get; set; }


        public TransactionEditForm() {

            InitializeComponent();
        }

        private void TransactionEditForm_Load(object sender, EventArgs e) {
            TransactionEditFormLoad();

        }

        private void TransactionEditFormLoad() {
            this.Text = "New Transaction";

            foreach (Product item in MasterData.Products) {

                if (item.Description != null) {

                    ctrlListBox1.Items.Add(item.Description);
                }

            }

            ctrlCustomerCode.EditValue = NewTransaction.TransactionCustomer.Code;
            ctrlCustomerCode.ReadOnly = true;
            ctrlCustomerDescription.EditValue = NewTransaction.TransactionCustomer.Description;
            ctrlCustomerDescription.ReadOnly = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void btnAdd_Click(object sender, EventArgs e) {
            AddTransaction();
        }

        private void AddTransaction() {

            string description = Convert.ToString(ctrlListBox1.SelectedItem);

            if (description != string.Empty) {

                Product selectedObject = null;
                int quantity = Convert.ToInt32(ctrlSpinEdit.EditValue);

                selectedObject = MasterData.Products.Find(x => x.Description == Convert.ToString(description));
                decimal transactionLinePrice = selectedObject.Price * quantity;
                decimal transactionLineCost = selectedObject.Cost * quantity;
                TransactionLine transactionLine = new TransactionLine(quantity, transactionLinePrice, selectedObject.ID, description);

                ctrlListBox2.Items.Add(transactionLine.PrintTransactionLine());
                ctrlSpinEdit.EditValue = 1;
                TotalPrice += transactionLinePrice;
                TotalCost += transactionLineCost;
                ctrlTotalPrice.EditValue = Convert.ToString(TotalPrice + " €");
                ctrlTotalPrice.ReadOnly = true;

            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e) {
            DeleteLine();

        }

        private void DeleteLine() {
            if (ctrlListBox2.SelectedItem != null) {
                List<string> listParse = ctrlListBox2.SelectedItem.ToString().Split('x').ToList();

                string name = Convert.ToString(listParse[0].Substring(0, listParse[0].Length - 1));

                List<string> secondPartListParse = listParse[1].Split(' ').ToList();

                int quantity = Convert.ToInt32(secondPartListParse[1]);
                decimal price = Convert.ToDecimal(secondPartListParse[4]);
                TotalPrice -= price;
                ctrlListBox2.Items.Remove(ctrlListBox2.SelectedItem);
                ctrlTotalPrice.EditValue = Convert.ToString(TotalPrice + " €");
                Product selectedObject = MasterData.Products.Find(x => x.Description == Convert.ToString(name));

                TotalCost -= (quantity * selectedObject.Cost);
            }
            else {
                MessageBox.Show("Please select a transaction line!");

            }
        }

        private void btnOK_Click(object sender, EventArgs e) {
            SaveTransaction();
        }

        private void SaveTransaction() {
           
            if (ctrlListBox2.Items.Count >0) {
                foreach (string item in ctrlListBox2.Items) {

                    List<string> listParse = item.ToString().Split('x').ToList();
                    string description =  Convert.ToString(listParse[0].Substring(0, listParse[0].Length - 1));
                    Product selectedObject = MasterData.Products.Find(x => x.Description == Convert.ToString(description));
                    Guid productID = selectedObject.ID;
                    string temp = Convert.ToString(listParse[1].Substring(1));
                    List<string> listParse1 = temp.Split(' ').ToList();
                    int quantity = Convert.ToInt32(listParse1[0]);
                    decimal price = Convert.ToDecimal(listParse1[3]) ;
                    TransactionLine line = new TransactionLine(quantity, price, productID, description);
                    NewTransaction.TransactionLines.Add(line);

                }
               
                NewTransaction.TotalPrice = TotalPrice;
                NewTransaction.TotalCost = TotalCost;

                TransactionController transactionController = new TransactionController(MasterData, LogFile);
                transactionController.AddEntity(NewTransaction);
                Close();
            }
            else {
                MessageBox.Show("Please select product !");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }

    }
}
