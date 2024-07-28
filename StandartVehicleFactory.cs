using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    internal class StandartVehicleFactory : IVehicleFactory
    {
        public IVehicle CreateCar()
        {
            return new StandartVehicle();
        }
    }
}
