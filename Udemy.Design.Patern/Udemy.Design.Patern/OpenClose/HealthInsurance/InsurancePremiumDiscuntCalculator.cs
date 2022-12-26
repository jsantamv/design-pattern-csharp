using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Design.Patern.OpenClose.Interfaces;

namespace Udemy.Design.Patern.OpenClose.HealthInsurance
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
