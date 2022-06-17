using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierApplication
{
    public partial class frmLoginAccount : Form
    {
        public frmLoginAccount()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPurchaseDiscountedItem frmPurchaseDiscountedItem = new frmPurchaseDiscountedItem();
            frmPurchaseDiscountedItem.ShowDialog();
        }
    }
}
