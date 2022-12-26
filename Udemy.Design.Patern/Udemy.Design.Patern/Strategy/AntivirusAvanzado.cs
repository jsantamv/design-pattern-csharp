using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Design.Patern.Strategy
{
    public class AntivirusAvanzado : AnalisisAvanzados
    {
        public override void AnalizarKeyLoggers()
        {
            try
            {
                Console.WriteLine("Analizando AnalizarKeyLoggers ...");
                Thread.Sleep(1000);                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");                
            }
        }

        public override void AnalizarMemoria()
        {
            try
            {
                Console.WriteLine("Analizando AnalizarMemoria ...");
                Thread.Sleep(1000);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
        }

        public override void AnalizarRootKits()
        {
            try
            {
                Console.WriteLine("Analizando AnalizarRootKits ...");
                Thread.Sleep(1000);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
        }

        public override void DescomprimirZip()
        {
            try
            {
                Console.WriteLine("DescomprimirZip ...");
                Thread.Sleep(1000);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
        }

        public override void Detener()
        {
            Console.WriteLine("Antivirus Avanzado - Analisis Finalizado");
        }

        public override void Iniciar()
        {
            Console.WriteLine("Antivirus AVanzado - Analisis Iniciado ...");
        }
    }
}
