using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Design.Patern.SRP
{
    public class TaxCalculator
    {
        public void CalculateTax(Employee employee)
        {
            if (employee.GetEmployeeType().Equals("full-time"))
                Console.WriteLine("tax by full time");

            if (employee.GetEmployeeType().Equals("contract"))
                Console.WriteLine("Tax by contract");
        }
        
    }
}
