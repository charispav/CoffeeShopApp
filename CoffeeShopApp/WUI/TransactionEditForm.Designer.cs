
namespace CoffeeShopApp.WUI {
    partial class TransactionEditForm {
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ctrlListBox2 = new System.Windows.Forms.ListBox();
            this.ctrlListBox1 = new System.Windows.Forms.ListBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnAdd = new System.Windows.Forms.Button();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.ctrlSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.ctrlTotalPrice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.ctrlCustomerCode = new DevExpress.XtraEditors.TextEdit();
            this.ctrlCustomerDescription = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlTotalPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCustomerCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCustomerDescription.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(54, 13);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(126, 21);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Choose Product :";
            // 
            // ctrlListBox2
            // 
            this.ctrlListBox2.FormattingEnabled = true;
            this.ctrlListBox2.HorizontalScrollbar = true;
            this.ctrlListBox2.ItemHeight = 16;
            this.ctrlListBox2.Location = new System.Drawing.Point(476, 41);
            this.ctrlListBox2.Name = "ctrlListBox2";
            this.ctrlListBox2.ScrollAlwaysVisible = true;
            this.ctrlListBox2.Size = new System.Drawing.Size(236, 324);
            this.ctrlListBox2.TabIndex = 3;
            // 
            // ctrlListBox1
            // 
            this.ctrlListBox1.FormattingEnabled = true;
            this.ctrlListBox1.HorizontalScrollbar = true;
            this.ctrlListBox1.ItemHeight = 16;
            this.ctrlListBox1.Location = new System.Drawing.Point(35, 41);
            this.ctrlListBox1.Name = "ctrlListBox1";
            this.ctrlListBox1.ScrollAlwaysVisible = true;
            this.ctrlListBox1.Size = new System.Drawing.Size(195, 372);
            this.ctrlListBox1.TabIndex = 6;
            this.ctrlListBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(298, 113);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(74, 21);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Quantity :";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(298, 176);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(134, 48);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add product(s)";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(548, 13);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(92, 21);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Transaction ";
            // 
            // ctrlSpinEdit
            // 
            this.ctrlSpinEdit.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ctrlSpinEdit.Location = new System.Drawing.Point(380, 113);
            this.ctrlSpinEdit.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlSpinEdit.Name = "ctrlSpinEdit";
            this.ctrlSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ctrlSpinEdit.Properties.IsFloatValue = false;
            this.ctrlSpinEdit.Properties.MaskSettings.Set("mask", "N00");
            this.ctrlSpinEdit.Properties.MaxValue = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.ctrlSpinEdit.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ctrlSpinEdit.Size = new System.Drawing.Size(60, 24);
            this.ctrlSpinEdit.TabIndex = 11;
            // 
            // ctrlTotalPrice
            // 
            this.ctrlTotalPrice.Location = new System.Drawing.Point(497, 391);
            this.ctrlTotalPrice.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlTotalPrice.Name = "ctrlTotalPrice";
            this.ctrlTotalPrice.Size = new System.Drawing.Size(203, 22);
            this.ctrlTotalPrice.TabIndex = 12;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(385, 392);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(90, 21);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "Total Price :";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.ForestGreen;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(731, 41);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 38);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete Line";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(731, 481);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 38);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.BackColor = System.Drawing.Color.ForestGreen;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(731, 385);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(109, 38);
            this.btnOK.TabIndex = 17;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // ctrlCustomerCode
            // 
            this.ctrlCustomerCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ctrlCustomerCode.Location = new System.Drawing.Point(127, 500);
            this.ctrlCustomerCode.Name = "ctrlCustomerCode";
            this.ctrlCustomerCode.Size = new System.Drawing.Size(169, 22);
            this.ctrlCustomerCode.TabIndex = 18;
            // 
            // ctrlCustomerDescription
            // 
            this.ctrlCustomerDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ctrlCustomerDescription.Location = new System.Drawing.Point(497, 500);
            this.ctrlCustomerDescription.Name = "ctrlCustomerDescription";
            this.ctrlCustomerDescription.Size = new System.Drawing.Size(169, 22);
            this.ctrlCustomerDescription.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 502);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Customer Code:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 503);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Customer Description:";
            // 
            // TransactionEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 531);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlCustomerDescription);
            this.Controls.Add(this.ctrlCustomerCode);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.ctrlTotalPrice);
            this.Controls.Add(this.ctrlSpinEdit);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.ctrlListBox1);
            this.Controls.Add(this.ctrlListBox2);
            this.Controls.Add(this.labelControl1);
            this.Name = "TransactionEditForm";
            this.Text = "New Transaction";
            this.Load += new System.EventHandler(this.TransactionEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlTotalPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCustomerCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCustomerDescription.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ListBox ctrlListBox2;
        private System.Windows.Forms.ListBox ctrlListBox1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Button btnAdd;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SpinEdit ctrlSpinEdit;
        private DevExpress.XtraEditors.TextEdit ctrlTotalPrice;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private DevExpress.XtraEditors.TextEdit ctrlCustomerCode;
        private DevExpress.XtraEditors.TextEdit ctrlCustomerDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}