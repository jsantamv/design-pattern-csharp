
using DepedencyInjection;
using DepedencyInjection.Interface;
using Microsoft.Extensions.DependencyInjection;

//DOC https://learn.microsoft.com/es-es/dotnet/core/extensions/dependency-injection-guidelines

//Para utilizar esta libreria se instala este nuget
//Microsoft.Extensions.DependencyInjection
//Collecion de instancias.
var collection = new ServiceCollection();
collection.AddScoped<IDataAccess, DataAccess>();
collection.AddScoped<IBusiness, Business>();

// 1. Primero creamos el Service provider.
// para controlar la iyection, la cual ya esta ha sido creada por AddScoped
var provider = collection.BuildServiceProvider();

// Ya no es necesario porque biene dentro del builder services de collection
//IDataAccess dal = provider.GetService<IDataAccess>(); // new DataAccess();
IBusiness bix = provider.GetService<IBusiness>(); // new DataAccess();


var userInterface = new UserInterface(bix);

