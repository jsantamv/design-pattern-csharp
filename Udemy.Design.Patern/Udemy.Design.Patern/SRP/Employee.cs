using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Design.Patern.SRP
{
    /// <summary>
    /// Single Responsability
    /// Only one responsbaility to change
    /// Alta Cohesion y bajo acomplamiento
    /// </summary>
    public class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string Type { get; set; }


        public void Save()
        {
            new EmployeeRepository().Save(this);
        }

        public void CalculateTax()
        {
            new TaxCalculator().CalculateTax(this);
        }

        public string GetEmployeeType()
        {
            return Type;
        }



    }
}
