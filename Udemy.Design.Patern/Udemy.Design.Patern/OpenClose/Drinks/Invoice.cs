using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Design.Patern.OpenClose.Interfaces;

namespace Udemy.Design.Patern.OpenClose.Drinks
{
    public class Invoice
    {
        public decimal GetTotal(IEnumerable<IDrink> drinks)
        {
            decimal total = 0;

            foreach (var drink in drinks)
            {
                total += drink.GetPrice();
            }

            return total;
        }
    }
}
