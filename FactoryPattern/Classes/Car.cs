﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Classes
{
    class Car : Vehicle
    {
        public override int Wheels
        {
            get { return 4; }
        }
    }
}
