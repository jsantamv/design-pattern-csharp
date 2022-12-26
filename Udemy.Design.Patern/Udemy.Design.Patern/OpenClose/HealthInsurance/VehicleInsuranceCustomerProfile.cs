using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Design.Patern.OpenClose.Interfaces;

namespace Udemy.Design.Patern.OpenClose.HealthInsurance
{
    internal class VehicleInsuranceCustomerProfile : ICustomerProfile
    {
        public bool IsLoyalCustomer()
        {
            return new Random().Next(2) % 2 == 0;
        }
    }
}
