
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
            this.SuspendLayout();
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Location = new System.Drawing.Point(125, 52);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(83, 25);
            this.subtotalLabel.TabIndex = 0;
            this.subtotalLabel.Text = "&Subtotal:";
            // 
            // discPerLabel
            // 
            this.discPerLabel.AutoSize = true;
            this.discPerLabel.Location = new System.Drawing.Point(60, 97);
            this.discPerLabel.Name = "discPerLabel";
            this.discPerLabel.Size = new System.Drawing.Size(148, 25);
            this.discPerLabel.TabIndex = 1;
            this.discPerLabel.Text = "Discount Percent:";
            // 
            // discAmtLabel
            // 
            this.discAmtLabel.AutoSize = true;
            this.discAmtLabel.Location = new System.Drawing.Point(57, 145);
            this.discAmtLabel.Name = "discAmtLabel";
            this.discAmtLabel.Size = new System.Drawing.Size(151, 25);
            this.discAmtLabel.TabIndex = 2;
            this.discAmtLabel.Text = "DiscountAmount:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(155, 182);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(53, 25);
            this.totalLabel.TabIndex = 3;
            this.totalLabel.Text = "Total:";
            // 
            // subtotalTextBox
            // 
            this.subtotalTextBox.Location = new System.Drawing.Point(214, 46);
            this.subtotalTextBox.Name = "subtotalTextBox";
            this.subtotalTextBox.Size = new System.Drawing.Size(150, 31);
            this.subtotalTextBox.TabIndex = 4;
            // 
            // discPerTextBox
            // 
            this.discPerTextBox.Location = new System.Drawing.Point(214, 91);
            this.discPerTextBox.Name = "discPerTextBox";
            this.discPerTextBox.ReadOnly = true;
            this.discPerTextBox.Size = new System.Drawing.Size(150, 31);
            this.discPerTextBox.TabIndex = 5;
            // 
            // discAmt
            // 
            this.discAmt.Location = new System.Drawing.Point(214, 139);
            this.discAmt.Name = "discAmt";
            this.discAmt.ReadOnly = true;
            this.discAmt.Size = new System.Drawing.Size(150, 31);
            this.discAmt.TabIndex = 6;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(214, 182);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(150, 31);
            this.txtTotal.TabIndex = 7;
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(125, 266);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(94, 44);
            this.calcBtn.TabIndex = 8;
            this.calcBtn.Text = "&Calculate";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(270, 266);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 44);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FormInvoiceTotal
            // 
            this.AcceptButton = this.calcBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(420, 343);
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
    }
}

