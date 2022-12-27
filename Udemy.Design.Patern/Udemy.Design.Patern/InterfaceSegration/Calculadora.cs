using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Design.Patern.InterfaceSegration.Interface;

namespace Udemy.Design.Patern.InterfaceSegration
{

    /// <summary>
    /// En este ejemplo, hemos creado una interfaz llamada IOperaciones que define dos métodos públicos: 
    /// Sumar y Restar. Luego, hemos creado una clase llamada Calculadora que implementa esta interfaz. 
    /// Esto significa que la clase Calculadora debe proporcionar implementaciones para ambos métodos.
    /// Hemos utilizado una propiedad privada llamada _resultado para almacenar el resultado de las 
    /// operaciones de suma y resta. Los clientes de la clase Calculadora pueden usar la interfaz IOperaciones
    /// para llamar a estos métodos públicos sin tener que conocer los detalles de la implementación de la clase.
    /// </summary>
    public class Calculadora : IOperaciones
    {
        private int _resultado;

        public int Sumar(int a, int b)
        {
            _resultado = a + b; return _resultado;
        }

        public int Restar(int a, int b)
        {
            _resultado = a - b; return _resultado;
        }
    }
}
