using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Design.Patern.OpenClose.Drinks
{
    public class Invoice
    {
        public decimal GetTotal(IEnumerable<Drink> drinks)
        {
            decimal total = 0;

            foreach (var drink in drinks)
            {
                if (drink.Type.Equals("agua"))
                    total += drink.Price;
                else if (drink.Type.Equals("azucar"))
                    total += drink.Price * 0.33m;
                else if (drink.Type.Equals("Alcohol"))
                    total += drink.Price * 0.14m;
                else if (drink.Type.Equals("Energizante"))
                    total += drink.Price * 0.20m;
            }

            return total;
        }
    }
}
