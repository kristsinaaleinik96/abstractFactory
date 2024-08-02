using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    internal interface IStandartFactory : IDetailsAbstractFactory
    {
        IEngine CreateEngine()
        {
            return new StandartEngine();
        }

        IWheel CreateWheel()
        {
            return new StandartWheel();
        }
        ISuspension CreateSuspension()
        {
            return new StandartSuspension();
        }
    }
}
