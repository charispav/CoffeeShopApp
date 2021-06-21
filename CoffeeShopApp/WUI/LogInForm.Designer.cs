
namespace CoffeeShopApp.WUI {
    partial class LogInForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ctrlExit = new System.Windows.Forms.Button();
            this.ctrlPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.ctrlLogIn = new System.Windows.Forms.Button();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ctrlUsername = new DevExpress.XtraEditors.TextEdit();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.ForestGreen;
            this.checkBox1.Location = new System.Drawing.Point(188, 303);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(122, 21);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Remember me";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // ctrlExit
            // 
            this.ctrlExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ctrlExit.BackColor = System.Drawing.Color.ForestGreen;
            this.ctrlExit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ctrlExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ctrlExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrlExit.Location = new System.Drawing.Point(313, 372);
            this.ctrlExit.Name = "ctrlExit";
            this.ctrlExit.Size = new System.Drawing.Size(86, 35);
            this.ctrlExit.TabIndex = 16;
            this.ctrlExit.Text = "Exit";
            this.ctrlExit.UseVisualStyleBackColor = false;
            this.ctrlExit.Click += new System.EventHandler(this.ctrlExit_Click);
            // 
            // ctrlPassword
            // 
            this.ctrlPassword.Location = new System.Drawing.Point(188, 249);
            this.ctrlPassword.Name = "ctrlPassword";
            this.ctrlPassword.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlPassword.Properties.Appearance.Options.UseFont = true;
            this.ctrlPassword.Properties.PasswordChar = '*';
            this.ctrlPassword.Properties.UseSystemPasswordChar = true;
            this.ctrlPassword.Size = new System.Drawing.Size(211, 32);
            this.ctrlPassword.TabIndex = 15;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(188, 217);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(66, 16);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "Password :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(166, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(273, 31);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Log in to Your Account";
            // 
            // ctrlLogIn
            // 
            this.ctrlLogIn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ctrlLogIn.BackColor = System.Drawing.Color.ForestGreen;
            this.ctrlLogIn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ctrlLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ctrlLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlLogIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrlLogIn.Location = new System.Drawing.Point(188, 372);
            this.ctrlLogIn.Name = "ctrlLogIn";
            this.ctrlLogIn.Size = new System.Drawing.Size(86, 35);
            this.ctrlLogIn.TabIndex = 12;
            this.ctrlLogIn.Text = "Log in";
            this.ctrlLogIn.UseVisualStyleBackColor = false;
            this.ctrlLogIn.Click += new System.EventHandler(this.ctrlLogIn_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(185, 144);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(69, 16);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Username :";
            // 
            // ctrlUsername
            // 
            this.ctrlUsername.Location = new System.Drawing.Point(188, 166);
            this.ctrlUsername.Name = "ctrlUsername";
            this.ctrlUsername.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlUsername.Properties.Appearance.Options.UseFont = true;
            this.ctrlUsername.Size = new System.Drawing.Size(211, 32);
            this.ctrlUsername.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(240, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(608, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.ctrlExit);
            this.Controls.Add(this.ctrlPassword);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.ctrlLogIn);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ctrlUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Login";
            ((System.ComponentModel.ISupportInitialize)(this.ctrlPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button ctrlExit;
        private DevExpress.XtraEditors.TextEdit ctrlPassword;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Button ctrlLogIn;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit ctrlUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}