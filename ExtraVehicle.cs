using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    internal class ExtraVehicle : IVehicle
    {
        public string? ExtraEngine { get; set; }
        public string? ExtraWheel { get; set; }
        public string? ExtraSuspesion { get; set; }
        public string? GetEngineType()
        {
            return ExtraEngine;
        }
        public string? GetWheelType()
        { 
            return ExtraWheel;
        }
        public string? GetSuspensionType()
        { 
            return ExtraSuspesion;
        }
    }
}
