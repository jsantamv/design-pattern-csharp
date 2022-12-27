using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Design.Patern.InterfaceSegration.Interface
{
    /// <summary>
    /// Si durante una implementación de una interfaz algún método de dicha interfaz 
    /// no tiene realmente funcionalidad y dejas vacío el método a implementar o 
    /// propagas una excepción en el, estas violando el Principio de segregación de interfaces.
    /// </summary>
    public interface IOperaciones
    {
        int Sumar(int a, int b);
        int Restar(int a, int b);
    }
}
