using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public class EconomyFactory : IDetailsAbstractFactory
    {
        public IEngine CreateEngine() => new EcomomyEngine();
        public IWheel CreateWheel() => new EconomyWheel();
        public ISuspension CreateSuspension() => new EconomySuspension();

    }
}
