using DepedencyInjection.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepedencyInjection
{
    internal class Business : IBusiness
    {
        private readonly IDataAccess _dataAccess;

        public Business(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }



        public void SingUp(string userName, string password)
        {
            // to do validations
            //DataAccess dataAccess = new();
            _dataAccess.Store(userName, password);
        }
    }
}
