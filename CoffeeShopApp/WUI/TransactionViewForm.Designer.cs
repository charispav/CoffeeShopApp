
namespace CoffeeShopApp.WUI {
    partial class TransactionViewForm {
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
            this.ctrlViewList = new System.Windows.Forms.ListBox();
            this.ctrlCustomerCode = new DevExpress.XtraEditors.TextEdit();
            this.ctrlCustomerDescription = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ctrlTotalPrice = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.ctrlDate = new DevExpress.XtraEditors.TextEdit();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCustomerCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCustomerDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlTotalPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlViewList
            // 
            this.ctrlViewList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ctrlViewList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlViewList.FormattingEnabled = true;
            this.ctrlViewList.HorizontalScrollbar = true;
            this.ctrlViewList.ItemHeight = 24;
            this.ctrlViewList.Location = new System.Drawing.Point(51, 33);
            this.ctrlViewList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctrlViewList.Name = "ctrlViewList";
            this.ctrlViewList.ScrollAlwaysVisible = true;
            this.ctrlViewList.Size = new System.Drawing.Size(583, 388);
            this.ctrlViewList.TabIndex = 1;
            // 
            // ctrlCustomerCode
            // 
            this.ctrlCustomerCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlCustomerCode.Location = new System.Drawing.Point(688, 56);
            this.ctrlCustomerCode.Name = "ctrlCustomerCode";
            this.ctrlCustomerCode.Properties.ReadOnly = true;
            this.ctrlCustomerCode.Size = new System.Drawing.Size(134, 22);
            this.ctrlCustomerCode.TabIndex = 2;
            // 
            // ctrlCustomerDescription
            // 
            this.ctrlCustomerDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlCustomerDescription.Location = new System.Drawing.Point(688, 146);
            this.ctrlCustomerDescription.Name = "ctrlCustomerDescription";
            this.ctrlCustomerDescription.Properties.ReadOnly = true;
            this.ctrlCustomerDescription.Size = new System.Drawing.Size(134, 22);
            this.ctrlCustomerDescription.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(701, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Customer Code:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(691, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Customer Description:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(716, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total Cost:";
            // 
            // ctrlTotalPrice
            // 
            this.ctrlTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlTotalPrice.Location = new System.Drawing.Point(688, 240);
            this.ctrlTotalPrice.Name = "ctrlTotalPrice";
            this.ctrlTotalPrice.Properties.ReadOnly = true;
            this.ctrlTotalPrice.Size = new System.Drawing.Size(134, 22);
            this.ctrlTotalPrice.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(731, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Date:";
            // 
            // ctrlDate
            // 
            this.ctrlDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlDate.Location = new System.Drawing.Point(688, 325);
            this.ctrlDate.Name = "ctrlDate";
            this.ctrlDate.Properties.ReadOnly = true;
            this.ctrlDate.Size = new System.Drawing.Size(134, 22);
            this.ctrlDate.TabIndex = 9;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.ForestGreen;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(694, 395);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 39);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // TransactionViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ctrlTotalPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlCustomerDescription);
            this.Controls.Add(this.ctrlCustomerCode);
            this.Controls.Add(this.ctrlViewList);
            this.Name = "TransactionViewForm";
            this.Text = "Transaction Details";
            this.Load += new System.EventHandler(this.TransactionViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCustomerCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCustomerDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlTotalPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ctrlViewList;
        private DevExpress.XtraEditors.TextEdit ctrlCustomerCode;
        private DevExpress.XtraEditors.TextEdit ctrlCustomerDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit ctrlTotalPrice;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit ctrlDate;
        private System.Windows.Forms.Button btnClose;
    }
}