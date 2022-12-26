using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Design.Patern.OpenClose
{
    
    public class HealthInsuranceCustomerProfile : ICustomerProfile
    {
        public bool IsLoyalCustomer()
        {
            return (new Random().Next(2)) % 2 == 0;
        }
    }
}
