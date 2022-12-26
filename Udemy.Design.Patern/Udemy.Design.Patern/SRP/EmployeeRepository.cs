using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Design.Patern.SRP
{
    public class EmployeeRepository
    {
        public void Save(Employee employee) => Console.WriteLine($"save data in my-sql {employee.Name}");
    }
}
