using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApplication
{
    abstract class Item
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

        public abstract double getTotalPrice();

        public double returnTotalPrice()
        {
            total_price = item_price * quantity;
            return total_price;
        }
        public abstract void setPayment(double amount);
    }
}
