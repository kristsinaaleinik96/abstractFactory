using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    internal interface IEconomyFactory : IDetailsAbstractFactory
    {
        IEngine CreateEngine()
        {
            return new EcomomyEngine();
        }

        IWheel CreateWheel()
        { 
            return new EconomyWheel();
        }
        ISuspension CreateSuspension()
        {
            return new StandartSuspension();
        }
    }
}
