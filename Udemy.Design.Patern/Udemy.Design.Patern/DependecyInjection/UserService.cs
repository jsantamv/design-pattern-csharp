using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Design.Patern.DependecyInjection.Interface;

namespace Udemy.Design.Patern.DependecyInjection
{
    /// <summary>
    /// La clase UserService depende de una implementación de ILogger, y recibe esta dependencia a través de su constructor. 
    /// Ahora, para utilizar la clase UserService, primero debemos proporcionarle una implementación de ILogger. Por ejemplo:
    /// </summary>
    public class UserService
    {
        private readonly ILogger logger;

        public UserService(ILogger logger)
        {
            this.logger = logger;
        }

        
        public void Register(string username, string password)
        {
            // Aquí se puede hacer algún procesamiento de usuario...

            logger.Log($"El usuario {username} ha sido registrado.");
        }
    }

}
