using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Design.Patern.Liskov.Interface
{
    /// <summary>
    /// La sustitución de Liskov es un principio de diseño de objetos que se refiere 
    /// a la relación entre clases en una jerarquía de herencia. 
    /// Se basa en el principio de que si una clase es una subclase de otra, 
    /// entonces debe poder ser utilizada en cualquier lugar donde se espera la clase 
    /// base sin afectar el comportamiento del programa.
    /// </summary>
    public interface Shape
    {
        double CalculateArea();
    }
}
