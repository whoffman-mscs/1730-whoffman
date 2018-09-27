using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace whoffman2a1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal subTotal = Convert.ToDecimal(txtSubtotal.Text);
            decimal discountPercent = Convert.ToDecimal(txtDiscountPercent.Text);
            decimal discountAmount = subTotal * discountPercent / 100;
            txtDiscountAmount.Text = discountAmount.ToString("0.00");
            decimal total = subTotal - discountAmount;
            txtTotal.Text = total.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
