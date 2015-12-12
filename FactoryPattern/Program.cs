using FactoryPattern.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = VehicleFactory.GetVehicle(VehicleFactory.VehicleType.Car);
            Vehicle superCar = VehicleFactory.GetVehicle(VehicleFactory.VehicleType.SuperCar);
            Vehicle truck = VehicleFactory.GetVehicle(VehicleFactory.VehicleType.Truck);
            Vehicle motorCycle = VehicleFactory.GetVehicle(VehicleFactory.VehicleType.Motorcyle);
            //Vehicle test = VehicleFactory.GetVehicle((VehicleFactory.VehicleType)100);
            Console.Write(car + "\n");
            Console.Write(superCar + "\n");
            Console.Write(truck + "\n");
            Console.Write(motorCycle + "\n");
        }
    }
}
