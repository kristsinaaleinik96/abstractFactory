using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    internal class Vehicle
    {
        private IEngine? engine;
        private IWheel? wheel;
        private ISuspension? suspension;

        public Vehicle(IDetailsAbstractFactory factory) 
        { 
            engine = factory.CreateEngine();
            wheel = factory.CreateWheel();
            suspension = factory.CreateSuspension();
        }
    }
}
