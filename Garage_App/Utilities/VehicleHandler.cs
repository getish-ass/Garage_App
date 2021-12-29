using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_App.Utilities
{
    internal class VehicleHandler
    {
       
        public void UserMenu()
        {
            Console.WriteLine("Enter the corresponding number to chose which type of vehicle you want to park");
            Console.WriteLine("1. Car \n " +
                              "2. Bus \n " +
                              "3. Motor Cycle \n" +
                              "4. Boat \n" +
                              "5. Airplane \n" +
                              "0. Exit \n");

            int i = int.Parse(Console.ReadLine());
            switch (i)
            {
                case 1:
                    AddVehicle("Car"); break;
                case 2:
                    AddVehicle("Bus"); break;
                case 3:
                    AddVehicle("MotorCycle"); break;
                case 4:
                    AddVehicle("Boat"); break;
                case 5:
                    AddVehicle("Boat"); break;
                case 0:
                    Environment.Exit(0); break;
                default:
                    Console.WriteLine("Please enter some valid input ( 1, 2,... 5, 0)"); break;
            }
         }

        private void AddVehicle(string v)
        {
            if(v == "Car")
            {
                Garage<Car> car = new Garage<Car>(20);
                int x = 0;
                while(!(x == 1)) { 
                Console.WriteLine("Enter registration number:");
                string regnum = Console.ReadLine();
                Console.WriteLine("Enter type of vehicle (Car, MotorCycle, Bus, Airplane, Boat):");
                string vehtyp = Console.ReadLine();
                Console.WriteLine("Enter vehicle color:");
                string vehcol = Console.ReadLine();
                Console.WriteLine("Enter number of wheel:");
                int numwheel = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter cylinder volume:");
                double cylvol = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter fuel type:");
                string fueltype = Console.ReadLine();
                Console.WriteLine("Enter number of sit:");
                int numofsit = int.Parse(Console.ReadLine());
                car.Add(new Car { RegisterNumber = regnum, VehicleType = vehtyp, VehicleColor = vehcol, NumberOfWheel = numwheel, CylVol = cylvol, FuelType = fueltype, NumOfSit = numofsit});
                Console.WriteLine("enter 1 to exit other wise continue to enter the necessary details of your vehicle");
                }

            }
            else if(v == "Bus")
            {
                Garage<Bus> bus = new Garage<Bus>(10);
                int x = 0;
                while (!(x == 1))
                {
                    Console.WriteLine("Enter registration number:");
                    string regnum = Console.ReadLine();
                    Console.WriteLine("Enter type of vehicle (Car, MotorCycle, Bus, Airplane, Boat):");
                    string vehtyp = Console.ReadLine();
                    Console.WriteLine("Enter vehicle color:");
                    string vehcol = Console.ReadLine();
                    Console.WriteLine("Enter number of wheel:");
                    int numwheel = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter cylinder volume:");
                    double cylvol = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter fuel type:");
                    string fueltype = Console.ReadLine();
                    Console.WriteLine("Enter number of sit:");
                    int numofsit = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter bus length");
                    double len = double.Parse(Console.ReadLine());
                    bus.Add(new Bus { RegisterNumber = regnum, VehicleType = vehtyp, VehicleColor = vehcol, NumberOfWheel = numwheel, CylVol = cylvol, FuelType = fueltype, NumOfSit = numofsit, Length = len });
                    Console.WriteLine("enter 1 to exit other wise continue to enter the necessary details of your vehicle");
                } 
            }
            else if(v == "MotorCycle")
            {
                Garage<MotorCycle> motorcycle = new Garage<MotorCycle>(10);
                int x = 0;
                while (!(x == 1))
                {
                    Console.WriteLine("Enter registration number:");
                    string regnum = Console.ReadLine();
                    Console.WriteLine("Enter type of vehicle (Car, MotorCycle, Bus, Airplane, Boat):");
                    string vehtyp = Console.ReadLine();
                    Console.WriteLine("Enter vehicle color:");
                    string vehcol = Console.ReadLine();
                    Console.WriteLine("Enter number of wheel:");
                    int numwheel = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter cylinder volume:");
                    double cylvol = double.Parse(Console.ReadLine());
                    
                    motorcycle.Add(new MotorCycle { RegisterNumber = regnum, VehicleType = vehtyp, VehicleColor = vehcol, NumberOfWheel = numwheel, CylVol = cylvol});
                    Console.WriteLine("enter 1 to exit other wise continue to enter the necessary details of your vehicle");
                }

            }
        }
    }
}
