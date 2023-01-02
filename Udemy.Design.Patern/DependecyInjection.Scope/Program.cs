using DependecyInjection.Scope;
using Microsoft.Extensions.DependencyInjection;

var collection = new ServiceCollection();

collection.AddScoped<ScopedClass>();
collection.AddTransient<TransientClass>();

var builder = collection.BuildServiceProvider();

Console.Clear();

Parallel.For(1, 10, i =>
{
    //La misma Instancia
    Console.WriteLine($"ScopedClass Id {builder.GetService<ScopedClass>().GetHashCode()}");
    //Crea una nueva Instancia
    Console.WriteLine($"TransientClass Id {builder.GetService<TransientClass>().GetHashCode()}");
});


Console.WriteLine("Hello World");
Console.ReadKey();