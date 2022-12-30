using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepedencyInjection.Interface
{
    internal interface IDataAccess
    {
        void Store(string user, string password);
    }
}
