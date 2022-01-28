
namespace InvoiceTotal
{
    partial class FormInvoiceTotal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.discPerLabel = new System.Windows.Forms.Label();
            this.discAmtLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.subtotalTextBox = new System.Windows.Forms.TextBox();
            this.discPerTextBox = new System.Windows.Forms.TextBox();
            this.discAmt = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.calcBtn = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.labNumInvoices = new System.Windows.Forms.Label();
            this.labTotInvoice = new System.Windows.Forms.Label();
            this.labInvoiceAvg = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtNumOfInvoice = new System.Windows.Forms.TextBox();
            this.txtTotOfInvoice = new System.Windows.Forms.TextBox();
            this.txtInvoiceAvg = new System.Windows.Forms.TextBox();
            this.labEnterSub = new System.Windows.Forms.Label();
            this.txtEnterSub = new System.Windows.Forms.TextBox();
            this.labSmallInv = new System.Windows.Forms.Label();
            this.labBigInv = new System.Windows.Forms.Label();
            this.txtSmallInv = new System.Windows.Forms.TextBox();
            this.txtBigInv = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Location = new System.Drawing.Point(85, 82);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(83, 25);
            this.subtotalLabel.TabIndex = 0;
            this.subtotalLabel.Text = "&Subtotal:";
            // 
            // discPerLabel
            // 
            this.discPerLabel.AutoSize = true;
            this.discPerLabel.Location = new System.Drawing.Point(20, 127);
            this.discPerLabel.Name = "discPerLabel";
            this.discPerLabel.Size = new System.Drawing.Size(148, 25);
            this.discPerLabel.TabIndex = 1;
            this.discPerLabel.Text = "Discount Percent:";
            // 
            // discAmtLabel
            // 
            this.discAmtLabel.AutoSize = true;
            this.discAmtLabel.Location = new System.Drawing.Point(17, 175);
            this.discAmtLabel.Name = "discAmtLabel";
            this.discAmtLabel.Size = new System.Drawing.Size(151, 25);
            this.discAmtLabel.TabIndex = 2;
            this.discAmtLabel.Text = "DiscountAmount:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(115, 212);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(53, 25);
            this.totalLabel.TabIndex = 3;
            this.totalLabel.Text = "Total:";
            // 
            // subtotalTextBox
            // 
            this.subtotalTextBox.Location = new System.Drawing.Point(174, 76);
            this.subtotalTextBox.Name = "subtotalTextBox";
            this.subtotalTextBox.ReadOnly = true;
            this.subtotalTextBox.Size = new System.Drawing.Size(150, 31);
            this.subtotalTextBox.TabIndex = 4;
            // 
            // discPerTextBox
            // 
            this.discPerTextBox.Location = new System.Drawing.Point(174, 121);
            this.discPerTextBox.Name = "discPerTextBox";
            this.discPerTextBox.ReadOnly = true;
            this.discPerTextBox.Size = new System.Drawing.Size(150, 31);
            this.discPerTextBox.TabIndex = 5;
            // 
            // discAmt
            // 
            this.discAmt.Location = new System.Drawing.Point(174, 169);
            this.discAmt.Name = "discAmt";
            this.discAmt.ReadOnly = true;
            this.discAmt.Size = new System.Drawing.Size(150, 31);
            this.discAmt.TabIndex = 6;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(174, 212);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(150, 31);
            this.txtTotal.TabIndex = 7;
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(174, 273);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(94, 44);
            this.calcBtn.TabIndex = 8;
            this.calcBtn.Text = "&Calculate";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(427, 273);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 44);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labNumInvoices
            // 
            this.labNumInvoices.AutoSize = true;
            this.labNumInvoices.Location = new System.Drawing.Point(353, 34);
            this.labNumInvoices.Name = "labNumInvoices";
            this.labNumInvoices.Size = new System.Drawing.Size(171, 25);
            this.labNumInvoices.TabIndex = 10;
            this.labNumInvoices.Text = "Number of invoices:";
            // 
            // labTotInvoice
            // 
            this.labTotInvoice.AutoSize = true;
            this.labTotInvoice.Location = new System.Drawing.Point(381, 76);
            this.labTotInvoice.Name = "labTotInvoice";
            this.labTotInvoice.Size = new System.Drawing.Size(143, 25);
            this.labTotInvoice.TabIndex = 11;
            this.labTotInvoice.Text = "Total of invoices:";
            // 
            // labInvoiceAvg
            // 
            this.labInvoiceAvg.AutoSize = true;
            this.labInvoiceAvg.Location = new System.Drawing.Point(385, 127);
            this.labInvoiceAvg.Name = "labInvoiceAvg";
            this.labInvoiceAvg.Size = new System.Drawing.Size(139, 25);
            this.labInvoiceAvg.TabIndex = 12;
            this.labInvoiceAvg.Text = "Invoice average:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(305, 273);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 44);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clea&r";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtNumOfInvoice
            // 
            this.txtNumOfInvoice.Location = new System.Drawing.Point(530, 34);
            this.txtNumOfInvoice.Name = "txtNumOfInvoice";
            this.txtNumOfInvoice.ReadOnly = true;
            this.txtNumOfInvoice.Size = new System.Drawing.Size(150, 31);
            this.txtNumOfInvoice.TabIndex = 14;
            // 
            // txtTotOfInvoice
            // 
            this.txtTotOfInvoice.Location = new System.Drawing.Point(530, 76);
            this.txtTotOfInvoice.Name = "txtTotOfInvoice";
            this.txtTotOfInvoice.ReadOnly = true;
            this.txtTotOfInvoice.Size = new System.Drawing.Size(150, 31);
            this.txtTotOfInvoice.TabIndex = 15;
            // 
            // txtInvoiceAvg
            // 
            this.txtInvoiceAvg.Location = new System.Drawing.Point(530, 127);
            this.txtInvoiceAvg.Name = "txtInvoiceAvg";
            this.txtInvoiceAvg.ReadOnly = true;
            this.txtInvoiceAvg.Size = new System.Drawing.Size(150, 31);
            this.txtInvoiceAvg.TabIndex = 16;
            // 
            // labEnterSub
            // 
            this.labEnterSub.AutoSize = true;
            this.labEnterSub.Location = new System.Drawing.Point(40, 37);
            this.labEnterSub.Name = "labEnterSub";
            this.labEnterSub.Size = new System.Drawing.Size(128, 25);
            this.labEnterSub.TabIndex = 17;
            this.labEnterSub.Text = "Enter Subtotal:";
            // 
            // txtEnterSub
            // 
            this.txtEnterSub.Location = new System.Drawing.Point(174, 34);
            this.txtEnterSub.Name = "txtEnterSub";
            this.txtEnterSub.Size = new System.Drawing.Size(150, 31);
            this.txtEnterSub.TabIndex = 18;
            // 
            // labSmallInv
            // 
            this.labSmallInv.AutoSize = true;
            this.labSmallInv.Location = new System.Drawing.Point(381, 172);
            this.labSmallInv.Name = "labSmallInv";
            this.labSmallInv.Size = new System.Drawing.Size(143, 25);
            this.labSmallInv.TabIndex = 19;
            this.labSmallInv.Text = "Smallest Invoice:";
            // 
            // labBigInv
            // 
            this.labBigInv.AutoSize = true;
            this.labBigInv.Location = new System.Drawing.Point(390, 212);
            this.labBigInv.Name = "labBigInv";
            this.labBigInv.Size = new System.Drawing.Size(134, 25);
            this.labBigInv.TabIndex = 20;
            this.labBigInv.Text = "Largest Invoice:";
            // 
            // txtSmallInv
            // 
            this.txtSmallInv.Location = new System.Drawing.Point(530, 169);
            this.txtSmallInv.Name = "txtSmallInv";
            this.txtSmallInv.ReadOnly = true;
            this.txtSmallInv.Size = new System.Drawing.Size(150, 31);
            this.txtSmallInv.TabIndex = 21;
            // 
            // txtBigInv
            // 
            this.txtBigInv.Location = new System.Drawing.Point(530, 209);
            this.txtBigInv.Name = "txtBigInv";
            this.txtBigInv.ReadOnly = true;
            this.txtBigInv.Size = new System.Drawing.Size(150, 31);
            this.txtBigInv.TabIndex = 22;
            // 
            // FormInvoiceTotal
            // 
            this.AcceptButton = this.calcBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(705, 329);
            this.Controls.Add(this.txtBigInv);
            this.Controls.Add(this.txtSmallInv);
            this.Controls.Add(this.labBigInv);
            this.Controls.Add(this.labSmallInv);
            this.Controls.Add(this.txtEnterSub);
            this.Controls.Add(this.labEnterSub);
            this.Controls.Add(this.txtInvoiceAvg);
            this.Controls.Add(this.txtTotOfInvoice);
            this.Controls.Add(this.txtNumOfInvoice);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.labInvoiceAvg);
            this.Controls.Add(this.labTotInvoice);
            this.Controls.Add(this.labNumInvoices);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.discAmt);
            this.Controls.Add(this.discPerTextBox);
            this.Controls.Add(this.subtotalTextBox);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.discAmtLabel);
            this.Controls.Add(this.discPerLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Name = "FormInvoiceTotal";
            this.Text = "Invoice Total";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label discPerLabel;
        private System.Windows.Forms.Label discAmtLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox subtotalTextBox;
        private System.Windows.Forms.TextBox discPerTextBox;
        private System.Windows.Forms.TextBox discAmt;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label labNumInvoices;
        private System.Windows.Forms.Label labTotInvoice;
        private System.Windows.Forms.Label labInvoiceAvg;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtNumOfInvoice;
        private System.Windows.Forms.TextBox txtTotOfInvoice;
        private System.Windows.Forms.TextBox txtInvoiceAvg;
        private System.Windows.Forms.Label labEnterSub;
        private System.Windows.Forms.TextBox txtEnterSub;
        private System.Windows.Forms.Label labSmallInv;
        private System.Windows.Forms.Label labBigInv;
        private System.Windows.Forms.TextBox txtSmallInv;
        private System.Windows.Forms.TextBox txtBigInv;
    }
}

