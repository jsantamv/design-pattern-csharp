using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Design.Patern.Strategy
{
    public class AntivirusSimple : AnalisisSimple
    {
        public override void Detener()
        {
            Console.WriteLine("Antivirus Simple - Analisis Finalizado");
        }

        public override void Iniciar()
        {
            Console.WriteLine("Antivirus Simple - Analisis Iniciado ..."); 
        }

        public override void SaltarZip()
        {
            Console.WriteLine("Analizando ...");
            Thread.Sleep(2500);
            Console.WriteLine("No se pudo analizar archivos con extencion .zip");
        }
    }
}
