using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Design.Patern.InterfaceSegration.Interface
{
    public interface IAlmacenamiento
    {
        void Guardar(string titulo, string contenido);
        string Leer(string titulo);
    }
}
