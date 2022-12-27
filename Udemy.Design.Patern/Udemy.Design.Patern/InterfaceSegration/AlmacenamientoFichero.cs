using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Design.Patern.InterfaceSegration.Interface;

namespace Udemy.Design.Patern.InterfaceSegration
{
    /// <summary>
    /// Pero, ahora nos puede fallar en caso de que utilicemos la clase de escribir y
    /// guardar en el sistema de archivos (AlmacenamientoFichero). lo que tenemos que 
    /// hacer es mover esa interfaz como un parámetro en el constructor de nuestra clase 
    /// AlmacenamientoFichero ya que es la clase cliente de IFicheroInformacion.
    /// </summary>
    public class AlmacenamientoFichero : IAlmacenamiento
    {
        readonly string path = "C:/temp";
        private readonly IFicheroInformacion _ficheroInformacion;

        public AlmacenamientoFichero(IFicheroInformacion ficheroInformacion)
        {
            _ficheroInformacion = ficheroInformacion;
        }
        public void Guardar(string titulo, string contenido)
        {
            File.WriteAllText($"{path}/{titulo}.txt", contenido);
        }

        public string Leer(string titulo)
        {
            return File.ReadAllText($"{path}/{titulo}.txt");
        }

        
        public FileInfo? InformacionFichero(string titulo)
        {
            if (!GetFicheroInformation(titulo).Exists)
                return null;

            return new FileInfo($"{path}/{titulo}.txt");
        }


        private FileInfo GetFicheroInformation(string titulo)
        {
            // AlmacenamientoFichero ya que es la clase cliente de IFicheroInformacion.
            return _ficheroInformacion.GetInformacion(titulo);
        }


    }
}
