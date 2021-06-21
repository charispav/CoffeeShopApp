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
    public partial class LogInForm : Form {
        public LogInForm() {

            InitializeComponent();
            LoadCredentials();
        }

        private void ctrlLogIn_Click(object sender, EventArgs e) {
            LogIn();
        }

        private void LogIn() {

            string user, pass;

            user = Convert.ToString(ctrlUsername.EditValue);

            pass = Convert.ToString(ctrlPassword.EditValue);

            if (user == "admin" && pass == "admin") {

                SaveCredentials();
                Close();
            }
            else {
                MessageBox.Show("Incorrect Password!");
            }
        }

        private void ctrlExit_Click(object sender, EventArgs e) {

            Application.Exit();
        }

        void SaveCredentials() {
            if (checkBox1.Checked) {

                Properties.Settings.Default.Username = "admin";
                Properties.Settings.Default.Password = "admin";
                Properties.Settings.Default.Save();
            }
            else {

                Properties.Settings.Default.Username = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Save();
            }

        }

        void LoadCredentials() {

            if (Properties.Settings.Default.Username != string.Empty) {

                ctrlUsername.EditValue = Properties.Settings.Default.Username;
                ctrlPassword.EditValue = Properties.Settings.Default.Password;
                checkBox1.Checked = true;

            }
        }
    }
}
