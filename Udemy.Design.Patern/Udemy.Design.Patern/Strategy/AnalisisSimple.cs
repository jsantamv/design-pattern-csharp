using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Design.Patern.Strategy
{
    public abstract class AnalisisSimple : IStrategia
    {
        public void Analizar()
        {
            Iniciar();
            SaltarZip();
            Detener();
        }

        public abstract void Iniciar();
        public abstract void SaltarZip();
        public abstract void Detener();
    }
}
