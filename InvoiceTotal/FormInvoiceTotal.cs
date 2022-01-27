using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceTotal
{
    public partial class FormInvoiceTotal : Form
    {
        private decimal subtotal, discPercent, discAmount, Total;
        public FormInvoiceTotal()
        {
            InitializeComponent();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            subtotal = Convert.ToDecimal(subtotalTextBox.Text);

            if (subtotal >= 500)
            {
                discPercent = 20;
            } else if (subtotal >= 250)
            {
                discPercent = 15;
            }else if(subtotal >= 100)
            {
                discPercent = 10;
            }
            else
            {
                discPercent = 0;
            }

            
            discAmount = subtotal * (discPercent / 100);
            Total = subtotal - discAmount;

            discPerTextBox.Text = discPercent.ToString()+"%";
            discAmt.Text = discAmount.ToString("c");
            txtTotal.Text = Total.ToString("c");

            subtotalTextBox.Focus();

            /*
            subtotal = decimal.Parse(""+subtotalTextBox);
            discPercent = 5;
            discAmount = subtotal * ((100 - 5) / 100);
            Total = subtotal - discAmount;

            discPerTextBox = discPercent;
            discAmt = discAmount;
            txtTotal = Total;
            */
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
