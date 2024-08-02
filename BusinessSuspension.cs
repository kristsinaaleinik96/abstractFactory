using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    internal class BusinessSuspension : ISuspension
    {
        public string GetSuspension() => "BusinessSuspension";
    }
}
