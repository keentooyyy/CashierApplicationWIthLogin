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
    public partial class frmPurchaseDiscountedItem : Form
    {
        String TotalAmountText;
        String ChangeAmountText;
        public frmPurchaseDiscountedItem()
        {
            InitializeComponent();
        }

        private void ComputeButton_Click(object sender, EventArgs e)
        {
            useThisMethod(false);
            TotalAmountLabel.Text = TotalAmountText;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            useThisMethod(true);
            ChangeLabel.Text = ChangeAmountText;
        }
        private void useThisMethod(bool withpayment)
        {
            String name = ItemTextbox.Text;
            double price = Convert.ToDouble(PriceTextBox.Text);
            int quantity = Convert.ToInt32(QuantityTextBox.Text);
            Double discount = Convert.ToDouble(DiscountTextBox.Text);
            Double payment;

            if (withpayment == true)
            {
                payment = Convert.ToDouble(PaymentTexbox.Text);
            }
            else
            {
                payment = 0;
            }


            DiscountedItem discountedItem = new DiscountedItem(name, price, quantity, discount);
            discountedItem.setPayment(payment);

            TotalAmountText = discountedItem.getTotalPrice().ToString();

            ChangeAmountText = discountedItem.getChange().ToString();
        }
    }
}
