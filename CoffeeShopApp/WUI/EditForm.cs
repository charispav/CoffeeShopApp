using CoffeeShopApp.Impl;
using CoffeeShopApp.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CoffeeShopApp.WUI {
    public partial class EditForm : Form {
        public object EditObject { get; set; }
        public EntityTypeEnum Type { get; set; }
        private const string _LogFile = "Log.txt";
        private const string _JsonFile = "CoffeeShopData.json";

        public CoffeeShop NewCoffeeShop = new CoffeeShop();

        public EditForm() {
            InitializeComponent();
        }

        private void EditForm_Load(object sender, EventArgs e) {
            EditFormLoad();
        }

        private void EditFormLoad() {
            switch (Type) {
                case EntityTypeEnum.Employee:
                    ctrlTitle.Text = "Add New Employee";
                    lblfield1.Text = "Name";
                    lblfield2.Text = "Surname";
                    lblfield3.Text = "Salary";
                    lblfield4.Visible = false;

                    Employee employee = EditObject as Employee;

                    ctrlEditField1.EditValue = employee.Name;
                    ctrlEditField2.EditValue = employee.Surname;
                    ctrlEditField3.EditValue = employee.Salary;
                    ctrlEditField4.Visible = false;

                    break;
                case EntityTypeEnum.Transaction:

                    ctrlTitle.Text = "Add New Transaction";
                    break;
                case EntityTypeEnum.Product:
                    ctrlTitle.Text = "Add New Product";
                    lblfield1.Text = "Code";
                    lblfield2.Text = "Description";
                    lblfield3.Text = "Price";
                    lblfield4.Text = "Cost";

                    Product product = EditObject as Product;

                    ctrlEditField1.EditValue = product.Code;
                    ctrlEditField2.EditValue = product.Description;
                    ctrlEditField3.EditValue = product.Price;
                    ctrlEditField4.EditValue = product.Cost;

                    break;
                default:
                    break;
            }
        }

        private void btnOK_Click(object sender, EventArgs e) {
            SaveEdit();
        }
        private void EditForm_FormClosing(object sender, FormClosingEventArgs e) {
            Close();
        }
        private void SaveEdit() {
            NumberStyles style = NumberStyles.AllowDecimalPoint | NumberStyles.AllowCurrencySymbol;
            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-GR");
            switch (Type) {
                case EntityTypeEnum.Employee:

                    string name = Convert.ToString(ctrlEditField1.EditValue);
                    string surname = Convert.ToString(ctrlEditField2.EditValue);
                    decimal salary=0m;

                    if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(surname)
                      && decimal.TryParse(Convert.ToString(ctrlEditField3.EditValue).Replace(',', '.'), style, culture, out salary) && salary > 0) {

                        Employee employee = EditObject as Employee;
                        employee.Name = name;
                        employee.Surname = surname;
                        employee.Salary = salary;

                        EmployeeController employeeController = new EmployeeController(NewCoffeeShop, _LogFile);
                        employeeController.AddEntity(employee);

                        Close();

                    }

                    else {
                        MessageBox.Show("Please fill all fields with valid values!");

                    }
                    break;


                case EntityTypeEnum.Product:

                    string code = Convert.ToString(ctrlEditField1.EditValue);
                    string description = Convert.ToString(ctrlEditField2.EditValue);

                    decimal price = 0m;
                    decimal cost = 0m;
                   
                    Product product = EditObject as Product;
                    if (!string.IsNullOrWhiteSpace(code) && !string.IsNullOrWhiteSpace(description)
                        && decimal.TryParse(Convert.ToString(ctrlEditField3.EditValue).Replace(',', '.'), style, culture, out price) && price > 0
                        && decimal.TryParse(Convert.ToString(ctrlEditField4.EditValue).Replace(',', '.'), style, culture, out cost )  && cost > 0) {

                        product.Code = code;
                        product.Description = description;
                        product.Price = price;
                        product.Cost = cost;

                        ProductController productController = new ProductController(NewCoffeeShop, _LogFile);
                        productController.AddEntity(product);
                        Close();
                    }

                    else {
                        MessageBox.Show("Please fill all fields with valid values!");

                    }

                    break;
                default:
                    break;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {

            Close();
        }

        private void EditForm_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape) {
                Close();
                e.Handled = true;
            }
        }
    }
}
