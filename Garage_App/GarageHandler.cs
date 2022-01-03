using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_App
{
    internal class GarageHandler
    {

        private Garage<Vehicle> garage;

        public GarageHandler(int size)
        {
            garage = new Garage<Vehicle>(size);
        }


        public void SeedData()
        {
            garage.Park(new Car("CAR111", "Red", 4, 100));
            garage.Park(new MotorCycle("MOT111", "Green", 2, 100));
            garage.Park(new Bus("BUS111", "Red", 8, 40));
        }

        public void PrintAllVehicles()
        {
            foreach (var vehicle in garage)
            {
                Console.WriteLine(vehicle.ToString());
            }
        }
    }
}
