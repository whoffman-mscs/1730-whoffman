using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace whoffman_1b2
{
    public partial class frmInvoiceTotal : Form
    {
        public frmInvoiceTotal()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtDiscountAmount.Text = (Convert.ToDecimal(txtSubtotal.Text) * Convert.ToDecimal(txtDiscountPercent.Text) / 100).ToString("0.00");
            txtTotal.Text = (Convert.ToDecimal(txtSubtotal.Text) - Convert.ToDecimal(txtDiscountAmount.Text)).ToString("0.00");

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDiscountPercent_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmInvoiceTotal_Load(object sender, EventArgs e)
        {

        }

        private void txtDiscountAmount_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
