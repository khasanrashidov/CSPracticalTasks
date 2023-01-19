// Practical Tasks
// Create a program which manages a car park. 
// For this purpose, you need to implement the next entities as separate classes: 
// "Engine" (includes the next fields: power, volume, type, serial number), 
// "Chassis" (wheels number, number, permissible load), 
// "Transmission" (type, number of gears, manufacturer).
// Implement entities "Passenger car", "Truck", "Bus", "Scooter" 
// using class described previously (distinguished by unique fields) 
// and provide the output of complete information about objects of these types.

// Practical Task
//
// 1) Fill in a single collection containing objects 
// of the type "Truck", "Passenger car", "Bus", "Scooter" 
// (from the previous OOP task) with different field values.
//
// 2) Write the following information to the corresponding XML files:
//
// • All information about all vehicles an engine capacity of which is more than 1.5 liters;
// • Engine type, serial number and power rating for all buses and trucks;
// • All information about all vehicles, grouped by transmission type.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PracticalTask
{
    /// <summary>
    /// Class CarPark provides a main method that manages a car park.
    /// </summary>
    /// <remarks>
    /// This is a solution to the Practical Task.
    /// </remarks>
    public class CarPark
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

            // Single collection containing objects of the type "Truck", "Passenger car", "Bus", "Scooter"
            // Example using ArrayList
            ArrayList allVehicles = new ArrayList();
            allVehicles.Add(car);
            allVehicles.Add(truck);
            allVehicles.Add(bus);
            allVehicles.Add(scooter);

            // XML files:
            // XML file 1: 
            // containing all information about all vehicles an engine capacity of which is more than 1.5 liters

            // Single collection for different types of vehicles with various field values
            List<PassengerCar> vehiclesPassengerCars = new List<PassengerCar>()
            {
                new PassengerCar("BMW", "X5", "Black", 2015, new Engine { Power = 300, Volume = 3, Type = "Diesel", SerialNumber = "123456789" }, new Chassis { WheelsNumber = 4, Number = "123456789", PermissibleLoad = 1000 }, new Transmission { Type = "Automatic", NumberOfGears = 6, Manufacturer = "BMW" }),
                new PassengerCar("BMW", "X6", "Black", 2016, new Engine { Power = 300, Volume = 3, Type = "Diesel", SerialNumber = "123456789" }, new Chassis { WheelsNumber = 4, Number = "123456789", PermissibleLoad = 1000 }, new Transmission { Type = "Automatic", NumberOfGears = 6, Manufacturer = "BMW" }),
                new PassengerCar("Chevrolet", "Camaro", "Red", 2017, new Engine { Power = 300, Volume = 3, Type = "Gasoline", SerialNumber = "123456789" }, new Chassis { WheelsNumber = 4, Number = "123456789", PermissibleLoad = 1000 }, new Transmission { Type = "Automatic", NumberOfGears = 6, Manufacturer = "Chevrolet" }),
                new PassengerCar("Mercedes", "C-Class", "White", 2018, new Engine { Power = 300, Volume = 1, Type = "Diesel", SerialNumber = "123456789" }, new Chassis { WheelsNumber = 4, Number = "123456789", PermissibleLoad = 1000 }, new Transmission { Type = "Automatic", NumberOfGears = 6, Manufacturer = "Mercedes" }),

            };

            List<Truck> vehiclesTrucks = new List<Truck>()
            {
                new Truck("Ford", "F-150", "White", 2018, new Engine { Power = 400, Volume = 5, Type = "Diesel", SerialNumber = "987654321" }, new Chassis { WheelsNumber = 4, Number = "987654321", PermissibleLoad = 2000 }, new Transmission { Type = "Automatic", NumberOfGears = 6, Manufacturer = "Ford" }),
                new Truck("Ford", "F-250", "White", 2019, new Engine { Power = 400, Volume = 5, Type = "Diesel", SerialNumber = "987654321" }, new Chassis { WheelsNumber = 4, Number = "987654321", PermissibleLoad = 2000 }, new Transmission { Type = "Automatic", NumberOfGears = 6, Manufacturer = "Ford" }),
                new Truck("Chevrolet", "Silverado", "Red", 2017, new Engine { Power = 400, Volume = 1, Type = "Gasoline", SerialNumber = "987654321" }, new Chassis { WheelsNumber = 4, Number = "987654321", PermissibleLoad = 2000 }, new Transmission { Type = "Automatic", NumberOfGears = 6, Manufacturer = "Chevrolet" }),
                new Truck("Mercedes", "Actros", "White", 2018, new Engine { Power = 400, Volume = 5, Type = "Diesel", SerialNumber = "987654321" }, new Chassis { WheelsNumber = 4, Number = "987654321", PermissibleLoad = 2000 }, new Transmission { Type = "Automatic", NumberOfGears = 6, Manufacturer = "Mercedes" }),

            };

            List<Bus> vehiclesBuses = new List<Bus>()
            {
                new Bus("Mercedes", "Sprinter", "Blue", 2019, new Engine { Power = 200, Volume = 2, Type = "Diesel", SerialNumber = "123456789" }, new Chassis { WheelsNumber = 4, Number = "123456789", PermissibleLoad = 1000 }, new Transmission { Type = "Automatic", NumberOfGears = 6, Manufacturer = "Mercedes" }),
                new Bus("Mercedes", "Sprinter", "Blue", 2019, new Engine { Power = 200, Volume = 1, Type = "Diesel", SerialNumber = "123456789" }, new Chassis { WheelsNumber = 4, Number = "123456789", PermissibleLoad = 1000 }, new Transmission { Type = "Automatic", NumberOfGears = 6, Manufacturer = "Mercedes" }),
                new Bus("Chevrolet", "Express", "Red", 2017, new Engine { Power = 200, Volume = 2, Type = "Gasoline", SerialNumber = "123456789" }, new Chassis { WheelsNumber = 4, Number = "123456789", PermissibleLoad = 1000 }, new Transmission { Type = "Automatic", NumberOfGears = 6, Manufacturer = "Chevrolet" }),
                new Bus("Mercedes", "Sprinter", "White", 2018, new Engine { Power = 200, Volume = 2, Type = "Diesel", SerialNumber = "123456789" }, new Chassis { WheelsNumber = 4, Number = "123456789", PermissibleLoad = 1000 }, new Transmission { Type = "Automatic", NumberOfGears = 6, Manufacturer = "Mercedes" }),

            };

            List<Scooter> vehiclesScooters = new List<Scooter>()
            {
                new Scooter("BMW", "C650GT", "Black", 2015, new Engine { Power = 60, Volume = 0.6, Type = "Gasoline", SerialNumber = "123456789" }, new Chassis { WheelsNumber = 2, Number = "123456789", PermissibleLoad = 100 }, new Transmission { Type = "Automatic", NumberOfGears = 6, Manufacturer = "BMW" }),
                new Scooter("BMW", "C650GT", "Black", 2016, new Engine { Power = 60, Volume = 0.6, Type = "Gasoline", SerialNumber = "123456789" }, new Chassis { WheelsNumber = 2, Number = "123456789", PermissibleLoad = 100 }, new Transmission { Type = "Automatic", NumberOfGears = 6, Manufacturer = "BMW" }),
                new Scooter("Chevrolet", "Bolt", "Red", 2017, new Engine { Power = 60, Volume = 0.6, Type = "Gasoline", SerialNumber = "123456789" }, new Chassis { WheelsNumber = 2, Number = "123456789", PermissibleLoad = 100 }, new Transmission { Type = "Automatic", NumberOfGears = 6, Manufacturer = "Chevrolet" }),
                new Scooter("Mercedes", "C-Class", "White", 2018, new Engine { Power = 60, Volume = 0.6, Type = "Gasoline", SerialNumber = "123456789" }, new Chassis { WheelsNumber = 2, Number = "123456789", PermissibleLoad = 100 }, new Transmission { Type = "Automatic", NumberOfGears = 6, Manufacturer = "Mercedes" }),
            };

            // LINQ query to find all vehicles with engine capacity more than 1.5 liters
            var vehicles1_5_1 = (from vehicle in vehiclesPassengerCars
                                 where vehicle.Engine.Volume > 1.5
                                 select vehicle).ToList();

            var vehicles1_5_2 = (from vehicle in vehiclesTrucks
                                 where vehicle.Engine.Volume > 1.5
                                 select vehicle).ToList();

            var vehicles1_5_3 = (from vehicle in vehiclesBuses
                                 where vehicle.Engine.Volume > 1.5
                                 select vehicle).ToList();

            var vehicles1_5_4 = (from vehicle in vehiclesScooters
                                 where vehicle.Engine.Volume > 1.5
                                 select vehicle).ToList();

            // Print Passenger Cars with engine capacity more than 1.5 liters
            Console.WriteLine("====================================="); // Empty line
            Console.WriteLine("Passenger Cars with engine capacity more than 1.5 liters");
            foreach (var vehicle in vehicles1_5_1)
            {
                Console.WriteLine("Brand: {0}", vehicle.Brand);
                Console.WriteLine("Model: {0}", vehicle.Model);
                Console.WriteLine("Color: {0}", vehicle.Color);
                Console.WriteLine("Year: {0}", vehicle.Year);
                Console.WriteLine("Engine: {0}", vehicle.Engine);
                Console.WriteLine("Engine Power: {0}", vehicle.Engine.Power);
                Console.WriteLine("Engine Volume: {0}", vehicle.Engine.Volume);
                Console.WriteLine("Engine Type: {0}", vehicle.Engine.Type);
                Console.WriteLine("====================================="); // Empty line
            }

            // Print Trucks with engine capacity more than 1.5 liters
            Console.WriteLine("====================================="); // Empty line
            Console.WriteLine("Trucks with engine capacity more than 1.5 liters");
            foreach (var vehicle in vehicles1_5_2)
            {
                Console.WriteLine("Brand: {0}", vehicle.Brand);
                Console.WriteLine("Model: {0}", vehicle.Model);
                Console.WriteLine("Color: {0}", vehicle.Color);
                Console.WriteLine("Year: {0}", vehicle.Year);
                Console.WriteLine("Engine: {0}", vehicle.Engine);
                Console.WriteLine("Engine Power: {0}", vehicle.Engine.Power);
                Console.WriteLine("Engine Volume: {0}", vehicle.Engine.Volume);
                Console.WriteLine("Engine Type: {0}", vehicle.Engine.Type);
                Console.WriteLine("====================================="); // Empty line
            }

            // Print Buses with engine capacity more than 1.5 liters
            Console.WriteLine("====================================="); // Empty line
            Console.WriteLine("Buses with engine capacity more than 1.5 liters");
            foreach (var vehicle in vehicles1_5_3)
            {
                Console.WriteLine("Brand: {0}", vehicle.Brand);
                Console.WriteLine("Model: {0}", vehicle.Model);
                Console.WriteLine("Color: {0}", vehicle.Color);
                Console.WriteLine("Year: {0}", vehicle.Year);
                Console.WriteLine("Engine: {0}", vehicle.Engine);
                Console.WriteLine("Engine Power: {0}", vehicle.Engine.Power);
                Console.WriteLine("Engine Volume: {0}", vehicle.Engine.Volume);
                Console.WriteLine("Engine Type: {0}", vehicle.Engine.Type);
                Console.WriteLine("====================================="); // Empty line
            }

            // Print Scooters with engine capacity more than 1.5 liters
            Console.WriteLine("====================================="); // Empty line
            Console.WriteLine("Scooters with engine capacity more than 1.5 liters");
            foreach (var vehicle in vehicles1_5_4)
            {
                Console.WriteLine("Brand: {0}", vehicle.Brand);
                Console.WriteLine("Model: {0}", vehicle.Model);
                Console.WriteLine("Color: {0}", vehicle.Color);
                Console.WriteLine("Year: {0}", vehicle.Year);
                Console.WriteLine("Engine: {0}", vehicle.Engine);
                Console.WriteLine("Engine Power: {0}", vehicle.Engine.Power);
                Console.WriteLine("Engine Volume: {0}", vehicle.Engine.Volume);
                Console.WriteLine("Engine Type: {0}", vehicle.Engine.Type);
                Console.WriteLine("====================================="); // Empty line
            }

            // vehicles1_5_1 - list of Passenger Cars with engine capacity more than 1.5 liters
            // vehicles1_5_2 - list of Trucks with engine capacity more than 1.5 liters
            // vehicles1_5_3 - list of Buses with engine capacity more than 1.5 liters
            // vehicles1_5_4 - list of Scooters with engine capacity more than 1.5 liters

            // XML file 1:
            // containing all information about all vehicles an engine capacity of which is more than 1.5 liters
            // creating XMl writer
            System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(List<PassengerCar>));
            // creating file
            string path1 = System.IO.Directory.GetCurrentDirectory() + "\\PassengerCars_1_5_more.xml";
            System.IO.FileStream file1 = System.IO.File.Create(path1);
            // writing XML to file
            writer.Serialize(file1, vehicles1_5_1);
            // closing file
            file1.Close();

            // creating XMl writer
            System.Xml.Serialization.XmlSerializer writer2 = new System.Xml.Serialization.XmlSerializer(typeof(List<Truck>));
            // creating file
            string path2 = System.IO.Directory.GetCurrentDirectory() + "\\Trucks_1_5_more.xml";
            System.IO.FileStream file2 = System.IO.File.Create(path2);
            // writing XML to file
            writer2.Serialize(file2, vehicles1_5_2);
            // closing file
            file2.Close();

            // creating XMl writer
            System.Xml.Serialization.XmlSerializer writer3 = new System.Xml.Serialization.XmlSerializer(typeof(List<Bus>));
            // creating file
            string path3 = System.IO.Directory.GetCurrentDirectory() + "\\Buses_1_5_more.xml";
            System.IO.FileStream file3 = System.IO.File.Create(path3);
            // writing XML to file
            writer3.Serialize(file3, vehicles1_5_3);
            // closing file
            file3.Close();

            // creating XMl writer
            System.Xml.Serialization.XmlSerializer writer4 = new System.Xml.Serialization.XmlSerializer(typeof(List<Scooter>));
            // creating file
            string path4 = System.IO.Directory.GetCurrentDirectory() + "\\Scooters_1_5_more.xml";
            System.IO.FileStream file4 = System.IO.File.Create(path4);
            // writing XML to file
            writer4.Serialize(file4, vehicles1_5_4);
            // closing file
            file4.Close();

            // XML file 2:
            // containing engine type, serial number and power rating for all buses and trucks
            // Putting all engines of buses and trucks into one list
            List<Engine> engines = new List<Engine>();
            foreach (var vehicle in vehiclesBuses)
            {

                engines.Add(vehicle.Engine);
            }
            foreach (var vehicle in vehiclesTrucks)
            {
                engines.Add(vehicle.Engine);
            }

            // creating XMl writer
            System.Xml.Serialization.XmlSerializer writer5 = new System.Xml.Serialization.XmlSerializer(typeof(List<Engine>));
            // creating file
            string path5 = System.IO.Directory.GetCurrentDirectory() + "\\EnginesBusesTrucks.xml";
            System.IO.FileStream file5 = System.IO.File.Create(path5);
            // writing XML to file
            writer5.Serialize(file5, engines);
            // closing file
            file5.Close();


            // XML file 3:
            // containing all information about all vehicles, grouped by transmission type
            // creating XMl writer
            System.Xml.Serialization.XmlSerializer writer6 = new System.Xml.Serialization.XmlSerializer(typeof(List<PassengerCar>));
            // creating file
            string path6 = System.IO.Directory.GetCurrentDirectory() + "\\PassengerCars.xml";
            System.IO.FileStream file6 = System.IO.File.Create(path6);
            // writing XML to file
            writer6.Serialize(file6, vehiclesPassengerCars);
            // closing file
            file6.Close();

            // creating XMl writer
            System.Xml.Serialization.XmlSerializer writer7 = new System.Xml.Serialization.XmlSerializer(typeof(List<Truck>));
            // creating file
            string path7 = System.IO.Directory.GetCurrentDirectory() + "\\Trucks.xml";
            System.IO.FileStream file7 = System.IO.File.Create(path7);
            // writing XML to file
            writer7.Serialize(file7, vehiclesTrucks);
            // closing file
            file7.Close();

            // creating XMl writer
            System.Xml.Serialization.XmlSerializer writer8 = new System.Xml.Serialization.XmlSerializer(typeof(List<Bus>));
            // creating file
            string path8 = System.IO.Directory.GetCurrentDirectory() + "\\Buses.xml";
            System.IO.FileStream file8 = System.IO.File.Create(path8);
            // writing XML to file
            writer8.Serialize(file8, vehiclesBuses);
            // closing file
            file8.Close();

            // creating XMl writer
            System.Xml.Serialization.XmlSerializer writer9 = new System.Xml.Serialization.XmlSerializer(typeof(List<Scooter>));
            // creating file    
            string path9 = System.IO.Directory.GetCurrentDirectory() + "\\Scooters.xml";
            System.IO.FileStream file9 = System.IO.File.Create(path9);
            // writing XML to file
            writer9.Serialize(file9, vehiclesScooters);
            // closing file
            file9.Close();

            Console.ReadKey(); // Pause
        }
    }
}
