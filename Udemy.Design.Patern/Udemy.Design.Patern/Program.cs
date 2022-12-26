// See https://aka.ms/new-console-template for more information
using Udemy.Design.Patern.Strategy;

Console.WriteLine("Hello, World!");

Contexto context = new Contexto(new AntivirusSimple());

context.Ejecutar();

Console.WriteLine();

Contexto contextA = new Contexto(new AntivirusAvanzado());

contextA.Ejecutar();

