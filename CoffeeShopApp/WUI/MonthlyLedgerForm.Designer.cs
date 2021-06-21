
namespace CoffeeShopApp.WUI {
    partial class MonthlyLedgerForm {
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
            this.ctrlIncome = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlExpenses = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.ctrlTotal = new DevExpress.XtraEditors.TextEdit();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.ctrlMonth = new DevExpress.XtraEditors.SpinEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ctrlYear = new DevExpress.XtraEditors.SpinEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlIncome.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlExpenses.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlMonth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlYear.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlIncome
            // 
            this.ctrlIncome.Location = new System.Drawing.Point(570, 109);
            this.ctrlIncome.Name = "ctrlIncome";
            this.ctrlIncome.Properties.ReadOnly = true;
            this.ctrlIncome.Size = new System.Drawing.Size(181, 22);
            this.ctrlIncome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(448, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Income: ";
            // 
            // ctrlExpenses
            // 
            this.ctrlExpenses.Location = new System.Drawing.Point(570, 191);
            this.ctrlExpenses.Name = "ctrlExpenses";
            this.ctrlExpenses.Properties.ReadOnly = true;
            this.ctrlExpenses.Size = new System.Drawing.Size(181, 22);
            this.ctrlExpenses.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(447, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Expenses: ";
            // 
            // ctrlTotal
            // 
            this.ctrlTotal.Location = new System.Drawing.Point(570, 262);
            this.ctrlTotal.Name = "ctrlTotal";
            this.ctrlTotal.Properties.ReadOnly = true;
            this.ctrlTotal.Size = new System.Drawing.Size(181, 22);
            this.ctrlTotal.TabIndex = 4;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTotal.Location = new System.Drawing.Point(448, 262);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(51, 20);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total:";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.ForestGreen;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(654, 399);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 39);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlMonth
            // 
            this.ctrlMonth.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ctrlMonth.Location = new System.Drawing.Point(17, 110);
            this.ctrlMonth.Name = "ctrlMonth";
            this.ctrlMonth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ctrlMonth.Properties.IsFloatValue = false;
            this.ctrlMonth.Properties.MaskSettings.Set("mask", "N00");
            this.ctrlMonth.Properties.MaxLength = 12;
            this.ctrlMonth.Properties.MaxValue = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.ctrlMonth.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ctrlMonth.Size = new System.Drawing.Size(125, 24);
            this.ctrlMonth.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Month :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(14, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Year :";
            // 
            // ctrlYear
            // 
            this.ctrlYear.EditValue = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.ctrlYear.Location = new System.Drawing.Point(17, 218);
            this.ctrlYear.Name = "ctrlYear";
            this.ctrlYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ctrlYear.Properties.IsFloatValue = false;
            this.ctrlYear.Properties.MaskSettings.Set("mask", "d");
            this.ctrlYear.Properties.MaxLength = 12;
            this.ctrlYear.Properties.MaxValue = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.ctrlYear.Properties.MinValue = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.ctrlYear.Size = new System.Drawing.Size(125, 24);
            this.ctrlYear.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(12, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(340, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Choose month and year to calculate : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(446, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Monthly Ledger";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(12, 283);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(134, 39);
            this.btnCalculate.TabIndex = 16;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // MonthlyLedgerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ctrlYear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ctrlMonth);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.ctrlTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ctrlExpenses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlIncome);
            this.Name = "MonthlyLedgerForm";
            this.Text = "Monthly Ledger";
            ((System.ComponentModel.ISupportInitialize)(this.ctrlIncome.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlExpenses.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlMonth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlYear.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit ctrlIncome;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit ctrlExpenses;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit ctrlTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnClose;
        private DevExpress.XtraEditors.SpinEdit ctrlMonth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SpinEdit ctrlYear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCalculate;
    }
}