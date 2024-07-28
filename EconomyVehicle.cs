using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    internal class EconomyVehicle : IVehicle 
    {
        public string? EconomyEngine { get; set; }
        public string? EconomyWheel { get; set; }
        public string? EconomySuspesion { get; set; }
        public string? GetEngineType()
        {
            return EconomyEngine;
        }
        public string? GetWheelType()
        {
            return EconomyWheel;
        }
        public string? GetSuspensionType()
        {
            return EconomySuspesion;
        }
    }
}
