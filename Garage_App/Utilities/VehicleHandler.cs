using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_App.Utilities
{
    internal class VehicleHandler
    {
        Garage<Car> car;
        Garage<Bus> bus;
        Garage<MotorCycle> motorcycle;
        Garage<Airplane> airplane;
        Garage<Boat> boat;

        public void MainMenu()
        {
            Console.WriteLine("Enter 1 if you want to park or 2 to see a the garage or 0 to exit");
            int ch = int.Parse(Console.ReadLine());
            if (ch == 1)
            {
              //UserMenu();
            }
            else if (ch == 2)
            {
              //DesplayGarage();
            }
            else if(ch == 0)
            {
                Environment.Exit(0);
            }

        }
        //public void UserMenu()
        //{
            

        //    do
        //    {
        //        Console.WriteLine("Enter the corresponding number to chose which type of vehicle you want to park");
        //        Console.WriteLine("1. Car\n" +
        //                          "2. Bus\n" +
        //                          "3. Motor Cycle\n" +
        //                          "4. Boat\n" +
        //                          "5. Airplane\n" +
        //                          "6. Back to MainMenu\n" +
        //                          "0. Exit\n");
                
        //        int i = int.Parse(Console.ReadLine());
                
        //        switch (i)
        //        {
        //            case 1:
        //                AddVehicle("Car"); break;
        //            case 2:
        //                AddVehicle("Bus"); break;
        //            case 3:
        //                AddVehicle("MotorCycle"); break;
        //            case 4:
        //                AddVehicle("Boat"); break;
        //            case 5:
        //                AddVehicle("Airplane"); break;
        //            case 6:
        //                MainMenu(); break;
        //            default:
        //                Console.WriteLine("Please enter some valid input ( 1, 2,...5)"); break;
        //        }
                
        //    } while (true);
        ////}

        //public void DesplayGarage()
        //{
           

        //    do
        //    {
        //        Console.WriteLine("Enter the corresponding number to chose which type of vehicle Garage you want to see");
        //        Console.WriteLine("1. Car\n" +
        //                          "2. Bus\n" +
        //                          "3. Motor Cycle\n" +
        //                          "4. Boat\n" +
        //                          "5. Airplane\n" +
        //                          "6. Back to MainMenu\n"
        //                          );

        //        int i = int.Parse(Console.ReadLine());
        //        switch (i)
        //        {
        //            case 1:
        //                Console.WriteLine("Parked cars in the Garage:\n");
        //                car.DesplayVehicle();
        //                break;
        //            case 2:
        //                Console.WriteLine("Parked Bus in the Garage:\n");
        //                bus.DesplayVehicle();
        //                break;
        //            case 3:
        //                Console.WriteLine("Parked MotorCycle in the Garage:\n");
        //                motorcycle.DesplayVehicle();
        //                break;
        //            case 4:
        //                Console.WriteLine("Parked Airplan in the Garage:\n");
        //                boat.DesplayVehicle();
                            
        //                break;
        //            case 5:
        //                Console.WriteLine("Parked Boat in the Garage:\n");
        //                airplane.DesplayVehicle();
        //                break;                  
        //            case 6:
        //                MainMenu(); break;
        //            default:
        //                Console.WriteLine("Please enter some valid input ( 1, 2,...5)"); break;
        //        }

        //    } while (true); 
            
        //}

        //private void AddVehicle(string v)
        //{
        //    if (v == "Car")
        //    {
        //        car = new Garage<Car>(20);
        //        int x = 0;
        //        while (!(x == 1))
        //        {
        //            if (x == 1)
        //            { break; }
        //            else
        //            {
        //                Console.WriteLine("Enter registration number:");
        //                string regnum = Console.ReadLine();
        //                Console.WriteLine("Enter type of vehicle (Car, MotorCycle, Bus, Airplane, Boat):");
        //                string vehtyp = Console.ReadLine();
        //                Console.WriteLine("Enter vehicle color:");
        //                string vehcol = Console.ReadLine();
        //                Console.WriteLine("Enter number of wheel:");
        //                int numwheel = int.Parse(Console.ReadLine());
        //                Console.WriteLine("Enter cylinder volume:");
        //                double cylvol = double.Parse(Console.ReadLine());
        //                Console.WriteLine("Enter fuel type:");
        //                string fueltype = Console.ReadLine();
        //                Console.WriteLine("Enter number of sit:");
        //                int numofsit = int.Parse(Console.ReadLine());
        //                car.Add(new Car { RegisterNumber = regnum, VehicleType = vehtyp, VehicleColor = vehcol, NumberOfWheel = numwheel, CylVol = cylvol, FuelType = fueltype, NumOfSit = numofsit });
        //            }
        //            Console.WriteLine("enter 1 to exit, 2 continue to enter the necessary details of your vehicle");
        //                x = int.Parse(Console.ReadLine());
                    
        //        }

        //    }
        //    else if (v == "Bus")
        //    {
        //        bus = new Garage<Bus>(10);
        //        int x = 0;
        //        while (!(x == 1))
        //        {
        //          if(x == 1) { break; }
        //          else
        //          { 
        //            Console.WriteLine("Enter registration number:");
        //            string regnum = Console.ReadLine();
        //            Console.WriteLine("Enter type of vehicle (Car, Bus, MotorCycle, Boat, Airplane):");
        //            string vehtyp = Console.ReadLine();
        //            Console.WriteLine("Enter vehicle color:");
        //            string vehcol = Console.ReadLine();
        //            Console.WriteLine("Enter number of wheel:");
        //            int numwheel = int.Parse(Console.ReadLine());
        //            Console.WriteLine("Enter cylinder volume:");
        //            double cylvol = double.Parse(Console.ReadLine());
        //            Console.WriteLine("Enter fuel type:");
        //            string fueltype = Console.ReadLine();
        //            Console.WriteLine("Enter number of sit:");
        //            int numofsit = int.Parse(Console.ReadLine());
        //            Console.WriteLine("Enter bus length");
        //            double len = double.Parse(Console.ReadLine());
        //            bus.Add(new Bus { RegisterNumber = regnum, VehicleType = vehtyp, VehicleColor = vehcol, NumberOfWheel = numwheel, CylVol = cylvol, FuelType = fueltype, NumOfSit = numofsit, Length = len });
        //          }
        //            Console.WriteLine("enter 1 to exit, 2 continue to enter the necessary details of your vehicle");
        //            x = int.Parse(Console.ReadLine());
        //        }
        //    }
        //    else if (v == "MotorCycle")
        //    {
        //        motorcycle = new Garage<MotorCycle>(10);
        //        int x = 0;
        //        while (!(x == 1))
        //        {
        //            if(x == 1) { break; }
        //            else
        //            {
        //                Console.WriteLine("Enter registration number:");
        //                string regnum = Console.ReadLine();
        //                Console.WriteLine("Enter type of vehicle (Car, MotorCycle, Bus, Airplane, Boat):");
        //                string vehtyp = Console.ReadLine();
        //                Console.WriteLine("Enter vehicle color:");
        //                string vehcol = Console.ReadLine();
        //                Console.WriteLine("Enter number of wheel:");
        //                int numwheel = int.Parse(Console.ReadLine());
        //                Console.WriteLine("Enter cylinder volume:");
        //                double cylvol = double.Parse(Console.ReadLine());
        //                motorcycle.Add(new MotorCycle { RegisterNumber = regnum, VehicleType = vehtyp, VehicleColor = vehcol, NumberOfWheel = numwheel, CylVol = cylvol });
        //            }                    
        //            Console.WriteLine("enter 1 to exit, 2 continue to enter the necessary details of your vehicle");
        //            x = int.Parse(Console.ReadLine());
        //        }
        //    }
        //    else if (v == "Boat")
        //    {
        //        boat = new Garage<Boat>(10);
        //        int x = 0;
        //        while (!(x == 1))
        //        {
        //            if (x == 1) { break; }
        //            else
        //            {
        //                Console.WriteLine("Enter registration number:");
        //                string regnum = Console.ReadLine();
        //                Console.WriteLine("Enter type of vehicle (Car, MotorCycle, Bus, Airplane, Boat):");
        //                string vehtyp = Console.ReadLine();
        //                Console.WriteLine("Enter vehicle color:");
        //                string vehcol = Console.ReadLine();
        //                Console.WriteLine("Enter number of wheel:");
        //                int numwheel = int.Parse(Console.ReadLine());
        //                Console.WriteLine("Enter the length of the boat:");
        //                double len = double.Parse(Console.ReadLine());
        //                boat.Add(new Boat { RegisterNumber = regnum, VehicleType = vehtyp, VehicleColor = vehcol, NumberOfWheel = numwheel, Length = len });
        //            }
        //            Console.WriteLine("enter 1 to exit other wise continue to enter the necessary details of your vehicle");
        //            x = int.Parse(Console.ReadLine());
        //        }
        //    }
        //    else if(v == "Airplane")
        //    {
        //        airplane = new Garage<Airplane>(10);
        //        int x = 0;
        //        while (!(x == 1))
        //        {
        //            if(x==1) { break; }
        //            else
        //            {
        //                Console.WriteLine("Enter registration number:");
        //                string regnum = Console.ReadLine();
        //                Console.WriteLine("Enter type of vehicle (Car, MotorCycle, Bus, Airplane, Boat):");
        //                string vehtyp = Console.ReadLine();
        //                Console.WriteLine("Enter vehicle color:");
        //                string vehcol = Console.ReadLine();
        //                Console.WriteLine("Enter number of wheel:");
        //                int numwheel = int.Parse(Console.ReadLine());
        //                Console.WriteLine("Enter number of engine:");
        //                int numengine = int.Parse(Console.ReadLine());
        //                Console.WriteLine("Enter number of sit:");
        //                int numofsit = int.Parse(Console.ReadLine());
        //                Console.WriteLine("Enter Airplane length");
        //                double len = double.Parse(Console.ReadLine());
        //                airplane.Add(new Airplane { RegisterNumber = regnum, VehicleType = vehtyp, VehicleColor = vehcol, NumberOfWheel = numwheel, NumberOfEngines = numengine, NumberOfSit = numofsit, Length = len });
        //            }                    
        //            Console.WriteLine("enter 1 to exit, 2 continue to enter the necessary details of your vehicle");
        //            x = int.Parse(Console.ReadLine());
        //        }
        //    }
            
        //}
    }
}
