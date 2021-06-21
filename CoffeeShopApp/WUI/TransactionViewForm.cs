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
    public partial class TransactionViewForm : Form {

        public Transaction TransactionDetails { get; set; }
        public TransactionViewForm() {
            InitializeComponent();
        }



        private void TransactionViewForm_Load(object sender, EventArgs e) {
            TransactionViewformLoad();

        }

        private void TransactionViewformLoad() {
            foreach (TransactionLine item in TransactionDetails.TransactionLines) {
                string line = String.Format("Product: {0} \t Quantity: {1} \t TotalPrice: {2} €", item.ProductDescription, item.Quantity, item.TransactionLinePrice);
                ctrlViewList.Items.Add(line);
            }

            ctrlCustomerCode.EditValue = TransactionDetails.TransactionCustomer.Code;
            ctrlCustomerDescription.EditValue = TransactionDetails.TransactionCustomer.Description;
            ctrlDate.EditValue = TransactionDetails.Date;
            ctrlTotalPrice.EditValue = TransactionDetails.TotalPrice;
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
