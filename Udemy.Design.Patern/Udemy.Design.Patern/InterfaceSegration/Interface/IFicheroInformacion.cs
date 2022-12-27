using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Design.Patern.InterfaceSegration.Interface
{
    public interface IFicheroInformacion
    {
        FileInfo GetInformacion(string titulo);
    }
}
