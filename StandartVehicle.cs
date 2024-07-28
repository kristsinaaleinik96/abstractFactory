using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    internal class StandartVehicle : IVehicle
    {
        public string? StandartEngine { get; set; }
        public string? StandartWheel { get; set; }
        public string? StandartSuspesion { get; set; }
        public string? GetEngineType()
        {
            return StandartEngine;
        }
        public string? GetWheelType()
        { 
            return StandartWheel;
        }
        public string? GetSuspensionType()
        { 
            return StandartSuspesion;
        }
    }
}
