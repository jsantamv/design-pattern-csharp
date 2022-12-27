using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Design.Patern.InterfaceSegration.Interface;

namespace Udemy.Design.Patern.InterfaceSegration
{
    /// <summary>
    /// De esta forma podemos realizar un cambio el cual nos va a añadir esta nueva interfaz
    /// a nuestra clase ArticuloServicio y desde el método que acabamos de crear llamamos 
    /// a nuestra nueva interfaz IFicheroInformacion y no a IAlmacenamiento
    /// </summary>
    public class ArticulosServicio
    {
        //private readonly Cache _cache;
        //private readonly ILogging _logging;
        private readonly IAlmacenamiento _almacenamiento;
        private readonly IFicheroInformacion _ficheroInformacion;

        public ArticulosServicio(IFicheroInformacion ficheroInformacion)
        {
            //_logging = new DatabaseLog();
            _almacenamiento = new AlmacenamientoSQL();
            //_cache = new Cache();
            _ficheroInformacion = ficheroInformacion;
        }
    }
}
