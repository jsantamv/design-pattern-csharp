using DepedencyInjection.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DepedencyInjection
{
    public class UserInterface
    {
        private readonly IBusiness _business;
        public UserInterface(IBusiness business)
        {
            _business = business;
        }

        public void GetDate()
        {
            Console.WriteLine("Enter your User Name");
            var userName = Console.ReadLine();

            Console.WriteLine("Enter Your Password");
            var password = Console.ReadLine();


            IDataAccess dal = new DataAccess();
            IBusiness business = new Business(dal);

            business.SingUp(userName, password);
        }
    }
}
