using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserAccountNamespace;

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

            String username = UsernameTextBox.Text;
            String password = PasswordTextBox.Text;

            Cashier cashier = new Cashier(null, null, username, password);

            String full_name = cashier.getFullName();
            String department = cashier.getDepartment();

            if (cashier.validateLogin(username,password))
            {
                MessageBox.Show("Welcome " + full_name + " of " + department);
                this.Hide();
                frmPurchaseDiscountedItem frmPurchaseDiscountedItem = new frmPurchaseDiscountedItem();
                frmPurchaseDiscountedItem.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password.");
            }

            
        }
    }
}
