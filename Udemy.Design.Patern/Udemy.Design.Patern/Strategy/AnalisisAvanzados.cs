using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Design.Patern.Strategy
{
    public abstract class AnalisisAvanzados : IStrategia
    {

        public void Analizar()
        {
            Iniciar();
            AnalizarMemoria();
            AnalizarKeyLoggers();
            AnalizarRootKits();
            DescomprimirZip();
            Detener();
        }

        public abstract void Iniciar();
        public abstract void AnalizarMemoria();
        public abstract void AnalizarKeyLoggers();
        public abstract void AnalizarRootKits();
        public abstract void DescomprimirZip();
        public abstract void Detener();

    }
}
