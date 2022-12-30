using DepedencyInjection.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepedencyInjection
{
    internal class DataAccess : IDataAccess
    {
        public void Store(string user, string password)
        {
            //write the data to db
        }

    }
}
