
using DepedencyInjection;
using DepedencyInjection.Interface;

IDataAccess dal = new DataAccess();
IBusiness bix = new Business(dal);

var userInterface = new UserInterface(bix);

