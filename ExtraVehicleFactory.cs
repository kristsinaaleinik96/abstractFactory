using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    internal class ExtraVehicleFactory : IVehicleFactory
    {
        public IVehicle CreateCar()
        {
            return new ExtraVehicle();
        }
    }
}
