
using DepedencyInjection;
using DepedencyInjection.Interface;
using Microsoft.Extensions.DependencyInjection;


//Para utilizar esta libreria se instala este nuget
//Microsoft.Extensions.DependencyInjection
//Collecion de instancias.
var collection = new ServiceCollection();
collection.AddScoped<IDataAccess, DataAccess>();

// 1. Primero creamos el Service provider.
// para controlar la iyection
var provider = collection.BuildServiceProvider();
IDataAccess dal =  provider new DataAccess();
IBusiness bix = new Business(dal);

var userInterface = new UserInterface(bix);

