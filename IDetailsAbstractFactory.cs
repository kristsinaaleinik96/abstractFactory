﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    internal interface IDetailsAbstractFactory
    {
        string CreateEngine();
        string CreateWheel();
        string CreateSuspension();
    }
}
