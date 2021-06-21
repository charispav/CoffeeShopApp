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
    public partial class MonthlyLedgerForm : Form {
       
        public CoffeeShop MasterData { get; set; }
        public MonthlyLedgerForm() {
            InitializeComponent();
        }



        private void btnClose_Click(object sender, EventArgs e) {

            Close();
        }



        private void btnCalculate_Click(object sender, EventArgs e) {

           CalculateMonthLedger();
        }

        private void CalculateMonthLedger( ) {

            int givenMonth = Convert.ToInt32(ctrlMonth.EditValue);
            int givenYear = Convert.ToInt32(ctrlYear.EditValue);

            List<Transaction> transactions = MasterData.Transactions.FindAll(x => x.Date.Year == givenYear).FindAll(y => y.Date.Month == givenMonth);
            List<Employee> employees = MasterData.Employees.FindAll(x => x.Date.Year <= givenYear).
                FindAll(y => y.Date.Month <= givenMonth).FindAll(w => w.DismissDate.Year >= givenYear).
                FindAll(z=> z.DismissDate.Month  >=givenMonth );
 
            decimal income = CalculateIncome(transactions);
            ctrlIncome.Text = Convert.ToString(income) + " € ";
            decimal expenses = CalculateExpenses(transactions, employees);
            ctrlExpenses.Text = Convert.ToString(expenses) + " € ";
            decimal total = 0m;

            if (income > expenses) {
                total = income - expenses;
                ctrlTotal.Text = String.Format(" {0} € ", total);
                lblTotal.Text = "Total Profit:";
            }
            else {
                total = expenses - income;
                ctrlTotal.Text = String.Format(" {0} € ", total);
                lblTotal.Text = "Total Loss:";
            }

            MonthlyLedger monthlyLedger = new MonthlyLedger();

            monthlyLedger.Year = givenYear;
            monthlyLedger.Month = givenMonth;
            monthlyLedger.Expenses = expenses;
            monthlyLedger.Income = income;
            monthlyLedger.Total = total;
            monthlyLedger.DateChecked = DateTime.Now;

            MasterData.MonthlyLedgers.Add(monthlyLedger);
            
        }

        private decimal CalculateIncome(List<Transaction> transactions) {
            decimal income = 0m;
            foreach (var item in transactions) {
                income += item.TotalPrice;
            }
            return income;
        }
        private decimal CalculateExpenses(List<Transaction> transactions, List<Employee> employees) {
            decimal expenses = 0m;
            const decimal rent = 3000m;
            decimal salaries = 0m;
            decimal productsCost = 0m;


            foreach (var item in employees) {
                salaries += item.Salary;
            }

            foreach (var item in transactions) {
                productsCost += item.TotalCost;
            }

            expenses = rent + salaries + productsCost;
            return expenses;
        }
    }
}


