using DepedencyInjection.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepedencyInjection
{
    internal class BusinessV2 : IBusiness
    {
        public void SingUp(string userName, string password)
        {
            // to do validations Anotter conection
            DataAccess dataAccess = new();
            dataAccess.Store(userName, password);
        }
    }
}
