using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Design.Patern.OpenClose.Interfaces;

namespace Udemy.Design.Patern.OpenClose.Drinks
{
    public class Alcohol : IDrink
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Invoice { get; set; }
        public decimal Promo { get; set; }

        public decimal GetPrice() => (Price * Invoice) - Promo;
    }
}
