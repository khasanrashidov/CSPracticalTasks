// Practical Tasks
// Create a program which manages a car park. 
// For this purpose, you need to implement the next entities as separate classes: 
// "Engine" (includes the next fields: power, volume, type, serial number), 
// "Chassis" (wheels number, number, permissible load), 
// "Transmission" (type, number of gears, manufacturer).
// Implement entities "Passenger car", "Truck", "Bus", "Scooter" 
// using class described previously (distinguished by unique fields) 
// and provide the output of complete information about objects of these types.

using System;

namespace PracticalTask
{
    /// <summary>
    /// Class CarPark provides a main method that manages a car park.
    /// </summary>
    /// <remarks>
    /// This is a solution to the Practical Task.
    /// </remarks>
    class CarPark
    {
        /// <summary>
        /// The Main method manages a car park.
        /// </summary>
        /// <param name="args">The string to be evaluated.</param>
        static void Main(string[] args)
        {
            // Create a new PassengerCar
            PassengerCar car = new PassengerCar("BMW", "X5", "Black", 2015, new Engine { Power = 300, Volume = 3, Type = "Diesel", SerialNumber = "123456789" }, new Chassis { WheelsNumber = 4, Number = "123456789", PermissibleLoad = 1000 }, new Transmission { Type = "Automatic", NumberOfGears = 6, Manufacturer = "BMW" });
            // Create a new Truck
            Truck truck = new Truck("Ford", "F-150", "White", 2018, new Engine { Power = 400, Volume = 5, Type = "Diesel", SerialNumber = "987654321" }, new Chassis { WheelsNumber = 4, Number = "987654321", PermissibleLoad = 2000 }, new Transmission { Type = "Automatic", NumberOfGears = 6, Manufacturer = "Ford" });
            // Create a new Bus
            Bus bus = new Bus("Mercedes", "Sprinter", "Blue", 2019, new Engine { Power = 200, Volume = 2, Type = "Diesel", SerialNumber = "123456789" }, new Chassis { WheelsNumber = 4, Number = "123456789", PermissibleLoad = 1000 }, new Transmission { Type = "Automatic", NumberOfGears = 6, Manufacturer = "Mercedes" });
            // Create a new Scooter
            Scooter scooter = new Scooter("Yamaha", "X-Max", "Red", 2017, new Engine { Power = 100, Volume = 1, Type = "Gasoline", SerialNumber = "123456789" }, new Chassis { WheelsNumber = 2, Number = "123456789", PermissibleLoad = 100 }, new Transmission { Type = "Automatic", NumberOfGears = 6, Manufacturer = "Yamaha" });

            // Print all information about PassengerCar
            Console.WriteLine("====================================="); // Empty line
            Console.WriteLine("Passenger Car");
            Console.WriteLine("Brand: {0}", car.Brand);
            Console.WriteLine("Model: {0}", car.Model);
            Console.WriteLine("Color: {0}", car.Color);
            Console.WriteLine("Year: {0}", car.Year);
            Console.WriteLine("Engine: {0}", car.Engine);
            Console.WriteLine("Engine Power: {0}", car.Engine.Power);
            Console.WriteLine("Engine Volume: {0}", car.Engine.Volume);
            Console.WriteLine("Engine Type: {0}", car.Engine.Type);
            Console.WriteLine("Engine Serial Number: {0}", car.Engine.SerialNumber);
            Console.WriteLine("Chassis: {0}", car.Chassis);
            Console.WriteLine("Chassis Wheels Number: {0}", car.Chassis.WheelsNumber);
            Console.WriteLine("Chassis Number: {0}", car.Chassis.Number);
            Console.WriteLine("Chassis Permissible Load: {0}", car.Chassis.PermissibleLoad);
            Console.WriteLine("Transmission: {0}", car.Transmission);
            Console.WriteLine("Transmission Type: {0}", car.Transmission.Type);
            Console.WriteLine("Transmission Number Of Gears: {0}", car.Transmission.NumberOfGears);
            Console.WriteLine("Transmission Manufacturer: {0}", car.Transmission.Manufacturer);
            Console.WriteLine("====================================="); // Empty line

            // Print all information about Truck
            Console.WriteLine("====================================="); // Empty line
            Console.WriteLine("Truck");
            Console.WriteLine("Brand: {0}", truck.Brand);
            Console.WriteLine("Model: {0}", truck.Model);
            Console.WriteLine("Color: {0}", truck.Color);
            Console.WriteLine("Year: {0}", truck.Year);
            Console.WriteLine("Engine: {0}", truck.Engine);
            Console.WriteLine("Engine Power: {0}", truck.Engine.Power);
            Console.WriteLine("Engine Volume: {0}", truck.Engine.Volume);
            Console.WriteLine("Engine Type: {0}", truck.Engine.Type);
            Console.WriteLine("Engine Serial Number: {0}", truck.Engine.SerialNumber);
            Console.WriteLine("Chassis: {0}", truck.Chassis);
            Console.WriteLine("Chassis Wheels Number: {0}", truck.Chassis.WheelsNumber);
            Console.WriteLine("Chassis Number: {0}", truck.Chassis.Number);
            Console.WriteLine("Chassis Permissible Load: {0}", truck.Chassis.PermissibleLoad);
            Console.WriteLine("Transmission: {0}", truck.Transmission);
            Console.WriteLine("Transmission Type: {0}", truck.Transmission.Type);
            Console.WriteLine("Transmission Number Of Gears: {0}", truck.Transmission.NumberOfGears);
            Console.WriteLine("Transmission Manufacturer: {0}", car.Transmission.Manufacturer);
            Console.WriteLine("====================================="); // Empty line

            // Print all information about Bus
            Console.WriteLine("====================================="); // Empty line
            Console.WriteLine("Bus");
            Console.WriteLine("Brand: {0}", bus.Brand);
            Console.WriteLine("Model: {0}", bus.Model);
            Console.WriteLine("Color: {0}", bus.Color);
            Console.WriteLine("Year: {0}", bus.Year);
            Console.WriteLine("Engine: {0}", bus.Engine);
            Console.WriteLine("Engine Power: {0}", bus.Engine.Power);
            Console.WriteLine("Engine Volume: {0}", bus.Engine.Volume);
            Console.WriteLine("Engine Type: {0}", bus.Engine.Type);
            Console.WriteLine("Engine Serial Number: {0}", bus.Engine.SerialNumber);
            Console.WriteLine("Chassis: {0}", bus.Chassis);
            Console.WriteLine("Chassis Wheels Number: {0}", bus.Chassis.WheelsNumber);
            Console.WriteLine("Chassis Number: {0}", bus.Chassis.Number);
            Console.WriteLine("Chassis Permissible Load: {0}", bus.Chassis.PermissibleLoad);
            Console.WriteLine("Transmission: {0}", bus.Transmission);
            Console.WriteLine("Transmission Type: {0}", bus.Transmission.Type);
            Console.WriteLine("Transmission Number Of Gears: {0}", bus.Transmission.NumberOfGears);
            Console.WriteLine("Transmission Manufacturer: {0}", bus.Transmission.Manufacturer);
            Console.WriteLine("====================================="); // Empty line

            // Print all information about Scooter
            Console.WriteLine("====================================="); // Empty line
            Console.WriteLine("Scooter");
            Console.WriteLine("Brand: {0}", scooter.Brand);
            Console.WriteLine("Model: {0}", scooter.Model);
            Console.WriteLine("Color: {0}", scooter.Color);
            Console.WriteLine("Year: {0}", scooter.Year);
            Console.WriteLine("Engine: {0}", scooter.Engine);
            Console.WriteLine("Engine Power: {0}", scooter.Engine.Power);
            Console.WriteLine("Engine Volume: {0}", scooter.Engine.Volume);
            Console.WriteLine("Engine Type: {0}", scooter.Engine.Type);
            Console.WriteLine("Engine Serial Number: {0}", scooter.Engine.SerialNumber);
            Console.WriteLine("Chassis: {0}", scooter.Chassis);
            Console.WriteLine("Chassis Wheels Number: {0}", scooter.Chassis.WheelsNumber);
            Console.WriteLine("Chassis Number: {0}", scooter.Chassis.Number);
            Console.WriteLine("Chassis Permissible Load: {0}", scooter.Chassis.PermissibleLoad);
            Console.WriteLine("Transmission: {0}", scooter.Transmission);
            Console.WriteLine("Transmission Type: {0}", scooter.Transmission.Type);
            Console.WriteLine("Transmission Number Of Gears: {0}", scooter.Transmission.NumberOfGears);
            Console.WriteLine("Transmission Manufacturer: {0}", scooter.Transmission.Manufacturer);
            Console.WriteLine("====================================="); // Empty line

            Console.ReadKey(); // Pause


        }
    }

    // Class Engine
    /// <summary>
    /// Class Engine provides information about the engine
    /// </summary>
    class Engine
    {
        // Properties
        /// <summary>
        /// Power of the engine
        /// </summary>
        public int Power { get; set; }
        /// <summary>
        /// Volume of the engine
        /// </summary>
        public int Volume { get; set; }
        // string? - Nullable string
        // It means that the string can be null
        /// <summary>
        /// Property Type of the engine
        /// </summary>
        public string? Type { get; set; }
        /// <summary>
        /// Property SerialNumber of the engine
        /// </summary>
        public string? SerialNumber { get; set; }
    }

    // Class Chassis
    /// <summary>
    /// Class Chassis provides information about the chassis
    /// </summary>
    class Chassis
    {
        /// <summary>
        /// Properties of the class Chassis: WheelsNumber, Number, PermissibleLoad
        /// </summary>
        public int WheelsNumber { get; set; }
        public string? Number { get; set; }
        public int PermissibleLoad { get; set; }
    }

    // Class Transmission
    /// <summary>
    /// Class Transmission provides information about the transmission
    /// </summary>
    class Transmission
    {
        /// <summary>
        /// Properties of the class Transmission: Type, NumberOfGears, Manufacturer
        /// </summary>
        public string? Type { get; set; }
        public int NumberOfGears { get; set; }
        public string? Manufacturer { get; set; }
    }

    // Class PassengerCar
    /// <summary>
    /// Class PassengerCar provides information about the passenger car
    /// </summary>
    class PassengerCar
    {
        public string Brand;
        public string Model;
        public string Color;
        public int Year;
        public Engine Engine;
        public Chassis Chassis;
        public Transmission Transmission;

        // Constructor with parameters
        /// <summary>
        /// Constructor with parameters: brand, model, color, year, engine, chassis, transmission
        /// </summary>
        /// <param name="brand">Brand of the car</param>
        /// <param name="model">Model of the car</param>
        /// <param name="color">Color of the car</param>
        /// <param name="year">Year of the car</param>
        /// <param name="engine">Engine of the car</param>
        /// <param name="chassis">Chassis of the car</param>
        /// <param name="transmission">Transmission of the car</param>
        /// <see cref="Engine"/>
        /// <see cref="Chassis"/>
        /// <see cref="Transmission"/>
        public PassengerCar(string brand, string model, string color, int year, Engine engine, Chassis chassis, Transmission transmission)
        {
            Brand = brand;
            Model = model;
            Color = color;
            Year = year;
            Engine = engine;
            Chassis = chassis;
            Transmission = transmission;
        }

    }

    // Class Truck
    /// <summary>
    /// Class Truck provides information about the truck
    /// </summary>
    class Truck
    {
        public string Brand;
        public string Model;
        public string Color;
        public int Year;
        public Engine Engine;
        public Chassis Chassis;
        public Transmission Transmission;

        // Constructor with parameters
        /// <summary>
        /// Constructor with parameters: brand, model, color, year, engine, chassis, transmission
        /// </summary>
        public Truck(string brand, string model, string color, int year, Engine engine, Chassis chassis, Transmission transmission)
        {
            Brand = brand;
            Model = model;
            Color = color;
            Year = year;
            Engine = engine;
            Chassis = chassis;
            Transmission = transmission;
        }

    }

    // Class Bus
    /// <summary>
    /// Class Bus provides information about the bus
    /// </summary>
    class Bus
    {
        public string Brand;
        public string Model;
        public string Color;
        public int Year;
        public Engine Engine;
        public Chassis Chassis;
        public Transmission Transmission;

        // Constructor with parameters
        /// <summary>
        /// Constructor with parameters: brand, model, color, year, engine, chassis, transmission
        /// </summary>
        public Bus(string brand, string model, string color, int year, Engine engine, Chassis chassis, Transmission transmission)
        {
            Brand = brand;
            Model = model;
            Color = color;
            Year = year;
            Engine = engine;
            Chassis = chassis;
            Transmission = transmission;
        }

    }

    // Class Scooter
    /// <summary>
    /// Class Scooter provides information about the scooter
    /// </summary>
    class Scooter
    {
        public string Brand;
        public string Model;
        public string Color;
        public int Year;
        public Engine Engine;
        public Chassis Chassis;
        public Transmission Transmission;

        // Constructor with parameters
        /// <summary>
        /// Constructor with parameters: brand, model, color, year, engine, chassis, transmission
        /// </summary>
        public Scooter(string brand, string model, string color, int year, Engine engine, Chassis chassis, Transmission transmission)
        {
            Brand = brand;
            Model = model;
            Color = color;
            Year = year;
            Engine = engine;
            Chassis = chassis;
            Transmission = transmission;
        }

    }


}