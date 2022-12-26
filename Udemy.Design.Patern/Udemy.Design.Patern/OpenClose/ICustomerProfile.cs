using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Design.Patern.OpenClose
{
    /// <summary>
    /// Software components should be closed for modification, 
    /// but open for extension
    /// </summary>
    public interface ICustomerProfile
    {
        public bool IsLoyalCustomer();
    }
}
