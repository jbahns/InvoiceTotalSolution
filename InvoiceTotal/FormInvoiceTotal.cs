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
        private decimal subtotal, discPercent, discAmount, Total, avg, prevSub;
        private int invNum = 0;
        private decimal totInv = 0;
        private decimal minInv = decimal.MaxValue;
        private decimal maxInv = decimal.MinValue;

        private void btnClear_Click(object sender, EventArgs e)
        {
            avg = 0;
            invNum = 0;
            totInv = 0;
            maxInv = decimal.MinValue;
            minInv = decimal.MaxValue;
            txtInvoiceAvg.Text = "";
            txtNumOfInvoice.Text = "";
            txtTotOfInvoice.Text = "";
            txtBigInv.Text = "";
            txtSmallInv.Text = "";
        }

        public FormInvoiceTotal()
        {
            InitializeComponent();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            subtotal = Decimal.Parse(txtEnterSub.Text);
             
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
            
            
            discAmount = Math.Round(subtotal * (discPercent / 100), 2);
            Total = Math.Round(subtotal - discAmount,2);
            prevSub = subtotal;
            invNum++;
            totInv += Total;
            avg = totInv / invNum;

            maxInv = Math.Max(Total, maxInv);
            minInv = Math.Min(Total, minInv);

            discPerTextBox.Text = discPercent.ToString()+"%";
            discAmt.Text = discAmount.ToString();
            txtTotal.Text = Total.ToString();
            txtNumOfInvoice.Text = invNum.ToString();
            txtTotOfInvoice.Text = totInv.ToString("c");
            txtInvoiceAvg.Text = avg.ToString("c");
            subtotalTextBox.Text = prevSub.ToString();
            txtBigInv.Text = maxInv.ToString();
            txtSmallInv.Text = minInv.ToString();

            txtEnterSub.Text = "";
            txtEnterSub.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
