using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIBA_BASE_Library
{
   public class CalculateUtil
    {
        public decimal CalculateDiscount(decimal price, int quantity)
        {
            Order objOrder = new Order();
            decimal cost;
            price = quantity * objOrder.unitPrice;
            decimal discount;

            if (quantity > 10 && quantity <= 20)
            {
                cost = price - ((price * 5) / 100);
                price = cost;
            }
            else if (quantity > 20 && quantity <= 30)
            {
                cost = price - ((price * 10) / 100);
                price = cost;
            }

            else if (quantity > 30)
            {
                decimal _maxObj = Convert.ToDecimal(30);
                decimal _bal = Convert.ToDecimal(quantity - 30);
                // compute 
                discount = (_bal * 20) / 100;
                discount += (_maxObj * 15) / 100;
                price = price - discount;
            }
            return price;
        }

    }
}
