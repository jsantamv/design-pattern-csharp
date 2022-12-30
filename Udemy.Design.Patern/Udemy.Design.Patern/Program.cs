using System.Xml.Linq;
using Udemy.Design.Patern.DependecyInjection.Interface;
using Udemy.Design.Patern.DependecyInjection;
using Udemy.Design.Patern.InterfaceSegration;
using Udemy.Design.Patern.InterfaceSegration.Interface;
using Udemy.Design.Patern.Liskov;
using Udemy.Design.Patern.Liskov.Abstract;
using Udemy.Design.Patern.Liskov.Interface;
using Udemy.Design.Patern.OpenClose;
using Udemy.Design.Patern.OpenClose.Drinks;
using Udemy.Design.Patern.Strategy;


#region Strategy Pattern
Console.WriteLine("=====< Strategy Pattern >======");
Console.WriteLine();
Contexto context = new(new AntivirusSimple());
context.Ejecutar();

Console.WriteLine();

Contexto contextA = new(new AntivirusAvanzado());
contextA.Ejecutar();
#endregion

#region Open Closed Principle
Console.WriteLine();
Console.WriteLine("======< Open Closed Principle >======");
Invoice Invoice = new();
IList<Water> lstDrink = new List<Water>
{
    new Water
    {
        Name = "alpina",
        Invoice = 0.20m,
        Price = 10
    },
    new Water
    {
        Name = "alpina",
        Invoice = 0.20m,
        Price = 1012
    }
};

var result = Invoice.GetTotal(lstDrink);

Console.WriteLine($"Price is: {result}");
#endregion

#region Sustitución de Liskov
Console.WriteLine();
Console.WriteLine("======< Sustitución de Liskov >======");
IShape shape = new Circle();
double area = shape.CalculateArea();

shape = new Rectangle();
area = shape.CalculateArea();


Fruit fruit = new Orange();
Console.WriteLine($"Orange: {fruit.GetColor()}");
fruit = new Apple();
Console.WriteLine($"Apple: {fruit.GetColor()}");

#endregion

#region Segregacion de Interface
Console.WriteLine();
Console.WriteLine("======< Segregacion de Interface >======");

IOperaciones op = new Calculadora();
double suma = op.Sumar(23, 12);

Console.WriteLine($"Resultado de la suma: {suma}");

double resta = op.Restar(23, 12);

Console.WriteLine($"Resultado de la resta: {resta}");


#endregion

#region Validate Number wuth Pipes

//Console.WriteLine();
//Console.WriteLine("======< Validate Number wuth Pipes >======");
//var input = "";

//string[] parts = input.Split('|');

//int result;
//foreach (var item in parts)
//{
//    bool valid = true;
//    valid = int.TryParse(item, out result);
//    Console.WriteLine($"Es numero: {valid} dato: {item}");
//    if (!valid) break;
//}
#endregion

#region dependecy injection
//Esto nos permite intercambiar fácilmente la implementación de ILogger utilizada por UserService
//simplemente proporcionando una implementación diferente a través del constructor. Por ejemplo,
//podríamos utilizar una implementación diferente de ILogger que escriba mensajes en un archivo en lugar de en la consola.

//En resumen, la inyección de dependencia nos permite desacoplar la clase UserService de su dependencia ILogger
//y mejorar la testabilidad, la mantenibilidad y la flexibilidad del código.
Console.WriteLine();
Console.WriteLine("======< dependecy injection >======");

ILogger logger = new ConsoleLogger();
UserService userService = new(logger);
userService.Register("johndoe", "mypassword");

#endregion