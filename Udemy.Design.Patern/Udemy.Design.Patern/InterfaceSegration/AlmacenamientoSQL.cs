using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Design.Patern.InterfaceSegration.Interface;

namespace Udemy.Design.Patern.InterfaceSegration
{
    public class AlmacenamientoSQL : IAlmacenamiento
    {
        public void Guardar(string titulo, string contenido)
        {
            //TO DO
            throw new NotImplementedException();
        }

        public string Leer(string titulo)
        {
            //TO DO
            throw new NotImplementedException();
        }
    }
}
