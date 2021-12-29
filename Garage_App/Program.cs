// See https://aka.ms/new-console-template for more information
using Garage_App;
using Garage_App.Utilities;


VehicleHandler vehicleHandler = new VehicleHandler();

vehicleHandler.UserMenu();

vehicleHandler.DesplayGarage();

//Garage<Car> car = new Garage<Car>(10);
//car.Add(new Car() 
//{   VehicleType = "Car",
//    RegisterNumber = "DER432",
//    VehicleColor = "Blue",
//    NumberOfWheel = 4,
//    CylVol = 250,
//    FuelType = "Benzin",
//    NumOfSit = 4
//    });
//car.Add(new Car()
//{
//    VehicleType = "Car",
//    RegisterNumber = "DER476",
//    VehicleColor = "Yellow",
//    NumberOfWheel = 4,
//    CylVol = 250,
//    FuelType = "Disel",
//    NumOfSit = 4
//    });
//car.Add(new Car()
//{
//    VehicleType = "Car",
//    RegisterNumber = "SDX582",
//    VehicleColor = "Silver",
//    NumberOfWheel = 4,
//    CylVol = 250,
//    FuelType = "Biofuel",
//    NumOfSit = 4
//    });
//Garage<MotorCycle> motorCycle = new Garage<MotorCycle>(10);
//motorCycle.Add(new MotorCycle()
//{
//    NumberOfWheel = 2,
//    RegisterNumber = "CSE056",
//    VehicleType = "Motor Cycle",
//    VehicleColor = "Orange"
//    });
//motorCycle.Add(new MotorCycle()
//{
//    NumberOfWheel = 2,
//    RegisterNumber = "CSE786",
//    VehicleType = "Motor Cycle",
//    VehicleColor = "Brown"
//    });


//car.DesplayVehicle();
//motorCycle.DesplayVehicle();