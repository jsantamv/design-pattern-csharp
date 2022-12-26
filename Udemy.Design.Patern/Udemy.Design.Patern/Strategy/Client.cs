using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Design.Patern.Strategy
{
    internal class Client
    {
        private IStrategy strategy;

        public void SetStrategy(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void performTask()
        {
            strategy.execute();
        }
    }
}
