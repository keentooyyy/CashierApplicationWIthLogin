using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApplication
{
    internal class Item
    {
        protected String item_name;
        protected double item_price;
        protected int quantity;
        private double total_price;

        public Item(String name, double price, int quantity)
        {
            this.item_name = name;
            this.item_price = price;
            this.quantity = quantity;
        }

        public void getTotalPrice()
        {
            total_price = item_price * quantity;

        }
        public double returnTotalPrice()
        {
            getTotalPrice();
            return total_price;
        }
        public void setPayment(double amount)
        {
            DiscountedItem discountedItem = new DiscountedItem(item_name,item_price,quantity,0);
            discountedItem.setPayment(amount);
        }
    }
}
