using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    internal interface IBusinessFactory
    {
        IEngine CreateEngine()
        {
            return new BusinessEngine();
        }

        IWheel CreateWheel()
        {
            return new BusinessWheel();
        }
        ISuspension CreateSuspension()
        {
            return new BusinessSuspension();
        }
    }
}
