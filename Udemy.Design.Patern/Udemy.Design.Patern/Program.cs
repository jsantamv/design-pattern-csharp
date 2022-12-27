using System.Xml.Linq;
using Udemy.Design.Patern.Liskov;
using Udemy.Design.Patern.Liskov.Abstract;
using Udemy.Design.Patern.Liskov.Interface;
using Udemy.Design.Patern.OpenClose;
using Udemy.Design.Patern.OpenClose.Drinks;
using Udemy.Design.Patern.Strategy;


#region Strategy Pattern
//Console.WriteLine("=====< Strategy Pattern >======");
//Console.WriteLine();
//Contexto context = new Contexto(new AntivirusSimple());
//context.Ejecutar();

//Console.WriteLine();

//Contexto contextA = new Contexto(new AntivirusAvanzado());
//contextA.Ejecutar();
#endregion

#region Open Closed Principle
Console.WriteLine();
Console.WriteLine("======< Open Closed Principle >======");
Invoice Invoice = new();
IList<Water> lstDrink = new List<Water>();

lstDrink.Add(new Water
{
    Name = "alpina",
    Invoice = 0.20m,
    Price = 10
});
lstDrink.Add(new Water
{
    Name = "alpina",
    Invoice = 0.20m,
    Price = 1012
});

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