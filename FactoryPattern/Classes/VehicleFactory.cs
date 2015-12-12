using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Classes
{
    public class VehicleFactory
    {
        public enum VehicleType
        {
            [VehicleInfo(typeof(Car))]
            Car,

            [VehicleInfo(typeof(SuperCar))]
            SuperCar,

            [VehicleInfo(typeof(Truck))]
            Truck,

            [VehicleInfo(typeof(MotorCycle))]
            Motorcyle
        }

        public static Vehicle GetVehicle(VehicleType vehicle)
        {
            if (!Enum.IsDefined(typeof(VehicleType), vehicle))
            {
                throw new InvalidOperationException("This is an Invalid Operation");
            }
            var vehicleAttribute = vehicle.GetAttribute<VehicleInfoAttribute>();
            //if (vehicleAttribute == null)
            //{
            //    //return null;
            //    throw new Exception("Class is not implemented");
            //}

            var type = vehicleAttribute.Type;
            Vehicle result = Activator.CreateInstance(type) as Vehicle;

            return result;
        }
    }
}
