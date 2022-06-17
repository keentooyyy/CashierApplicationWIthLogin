using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApplication
{
    internal class DiscountedItem : Item
    {
        private double item_discount;
        private double discounted_price;
        private double payment_amount;
        private double change;
        public DiscountedItem(String name, double price, int quantity, double discount) : base(name, price, quantity)
        {
            this.item_discount = discount;
        }

        public new double getTotalPrice()
        {
            double currentprice = base.returnTotalPrice();

            discounted_price = currentprice * (item_discount / 100);
            return currentprice - discounted_price;
        }

        public new void setPayment(double amount)
        {
            this.payment_amount = amount;
        }

        public double getChange()
        {
            change = payment_amount - getTotalPrice();
            return change;
        }
    }
}
