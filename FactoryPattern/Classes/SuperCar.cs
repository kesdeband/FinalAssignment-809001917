using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Classes
{
    public class SuperCar : Vehicle
    {
        public override int TopSpeed
        {
            get
            {
                return 200;
            }
        }

        public override int Wheels
        {
            get { return 4; }
        }
    }
}
