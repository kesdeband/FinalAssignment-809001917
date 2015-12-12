using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Classes
{
    public abstract class Vehicle
    {
        public virtual int TopSpeed
        {
            get
            {
                return 150;
            }
        }

        public abstract int Wheels
        {
            get;
        }

        public override string ToString()
        {
            return String.Format("A {0} has {1} wheels, and a top speed of {2} MPH.", this.GetType().Name, this.Wheels, this.TopSpeed);
        }
    }
}
