using Udemy.Design.Patern.Strategy;


#region Strategy Pattern
Console.WriteLine("=====< Strategy Pattern >======");
Console.WriteLine();
Contexto context = new Contexto(new AntivirusSimple());
context.Ejecutar();

Console.WriteLine();

Contexto contextA = new Contexto(new AntivirusAvanzado());
contextA.Ejecutar();
#endregion

