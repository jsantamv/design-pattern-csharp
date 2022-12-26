using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Design.Patern.OpenClose
{
    /// <summary>
    /// open for extension
    /// closed for modification 
    /// </summary>
    public class InsurancePremiumDiscuntCalculator
    {
        public int CalculatePremiumDiscountPercentage(ICustomerProfile customer)
        {
            return customer.IsLoyalCustomer() ? 20 : 0;
        }
    }
}
