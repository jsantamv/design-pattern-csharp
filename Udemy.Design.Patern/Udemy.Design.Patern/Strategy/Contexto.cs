using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Design.Patern.Strategy
{
    public class Contexto 
    {
        private IStrategia estrategia;

        public Contexto(IStrategia estrategia)
        {
            this.estrategia = estrategia;
        }

        public void Ejecutar()
        {
            estrategia.Analizar();
        }
    }
}
