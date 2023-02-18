// Practical Task
// 1) Fill in a single collection containing objects 
//    of the type "Truck", "Passenger car", "Bus", "Scooter" 
//    (from the previous OOP task) with different field values.
// 2) Write the following information to the corresponding XML files:
//  • All information about all vehicles an engine capacity of which is more than 1.5 liters;
//  • Engine type, serial number and power rating for all buses and trucks;
//  • All information about all vehicles, grouped by transmission type.

using System;
using System.Linq;
using System.Xml.Serialization; // for XML serialization
using CarPark; // for Car class
using System.IO;
using System.Collections.Generic;

namespace CarParkXml
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Car passengerCar1 = new Car(TypeOfCar.PassengerCar, "BMW X5", 2019, "Black",
                new Engine(300, 3.0, "Diesel", "1234567890"),
                new Chassis(4, "1234567890", 2000),
                new Transmission("Automatic", 6, "BMW"));

            Car passengerCar2 = new Car(TypeOfCar.PassengerCar, "Hyundai i30", 2019, "Black",
                new Engine(300, 1.0, "Diesel", "1234567890"),
                new Chassis(4, "1234567890", 2000),
                new Transmission("Automatic", 6, "Hyundai"));

            Car passengerCar3 = new Car(TypeOfCar.PassengerCar, "Audi A6", 2019, "White",
                new Engine(300, 4.0, "Diesel", "1234567890"),
                new Chassis(4, "1234567890", 2000),
                new Transmission("Automatic", 6, "Audi"));

            Car passengerCar4 = new Car(TypeOfCar.PassengerCar, "Ferrari F12 Berlinetta", 2019, "Red",
                new Engine(800, 6.3, "Gasoline", "1234567890"),
                new Chassis(4, "1234567890", 2000),
                new Transmission("Automatic", 6, "Ferrari"));

            Car truck1 = new Car(TypeOfCar.Truck, "Volvo FH", 2018, "White",
                new Engine(500, 5.0, "Diesel", "0987654321"),
                new Chassis(6, "0987654321", 3000),
                new Transmission("Automatic", 6, "Volvo"));

            Car truck2 = new Car(TypeOfCar.Truck, "Scania R", 2018, "White",
                new Engine(500, 5.0, "Diesel", "0987654321"),
                new Chassis(6, "0987654321", 3000),
                new Transmission("Manual", 6, "Scania"));

            Car truck3 = new Car(TypeOfCar.Truck, "Chevrolet Silverado", 2018, "White",
                new Engine(500, 5.0, "Diesel", "0987654321"),
                new Chassis(6, "0987654321", 3000),
                new Transmission("Automatic", 6, "Chevrolet"));

            Car bus1 = new Car(TypeOfCar.Bus, "Mercedes-Benz Citaro", 2017, "Blue",
                new Engine(200, 2.0, "Diesel", "1234567890"),
                new Chassis(6, "1234567890", 2000),
                new Transmission("Manual", 6, "Mercedes-Benz"));

            Car bus2 = new Car(TypeOfCar.Bus, "MCI D4500", 2017, "Blue",
                new Engine(200, 2.0, "Diesel", "1234567890"),
                new Chassis(6, "1234567890", 2000),
                new Transmission("Automatic", 6, "MCI"));

            Car bus3 = new Car(TypeOfCar.Bus, "Volvo B9TL", 2017, "Blue",
                new Engine(200, 2.0, "Diesel", "1234567890"),
                new Chassis(6, "1234567890", 2000),
                new Transmission("Manual", 6, "Volvo"));

            Car scooter1 = new Car(TypeOfCar.Scooter, "Yamaha X-Max", 2016, "Red",
                new Engine(100, 1.0, "Gasoline", "0987654321"),
                new Chassis(2, "0987654321", 100),
                new Transmission("Automatic", 6, "Yamaha"));

            Car scooter2 = new Car(TypeOfCar.Scooter, "Vespa Primavera", 2016, "Red",
                new Engine(100, 2.0, "Gasoline", "0987654321"),
                new Chassis(2, "0987654321", 100),
                new Transmission("Automatic", 6, "Vespa"));

            Car scooter3 = new Car(TypeOfCar.Scooter, "Honda Forza", 2016, "Red",
                new Engine(100, 3.0, "Gasoline", "0987654321"),
                new Chassis(2, "0987654321", 100),
                new Transmission("Automatic", 6, "Honda"));

            // Putting all cars in a single collection of cars (List)
            List<Car> cars = new List<Car>
            {
                passengerCar1, passengerCar2, passengerCar3, passengerCar4,
                truck1, truck2, truck3, bus1, bus2, bus3, scooter1, scooter2, scooter3
            };

            // LINQ query to get all vehicles with engine capacity more than 1.5 liters
            var engineCapacityMoreThan15 = (from car in cars
                where car.Engine.Volume > 1.5
                select car).ToList();

            // LINQ query to get engine type, serial number and power rating for all buses and trucks
            // with model, year and color
            var engineForAllBusesAndTrucks = (from car in cars
                where car.CarType == TypeOfCar.Bus || car.CarType == TypeOfCar.Truck
                select new
                {
                    car.Model,
                    car.Year,
                    car.Color,
                    car.Engine.Type,
                    car.Engine.SerialNumber,
                    car.Engine.Power
                }).ToList();


            // LINQ query to get all information about all vehicles, grouped by transmission type
            var allGroupedByTransmissionType = (from car in cars
                group car by car.Transmission.Type
                into transmissionGroup
                select new
                {
                    TransmissionType = transmissionGroup.Key,
                    Cars = transmissionGroup.ToList()
                }).ToList();

            // Printing results

            Console.WriteLine("All vehicles with engine capacity more than 1.5 liters:");
            foreach (var car in engineCapacityMoreThan15)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine("Engine type, serial number and power rating for all buses and trucks:");
            foreach (var car in engineForAllBusesAndTrucks)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine("All information about all vehicles, grouped by transmission type:");
            foreach (var transmissionGroup in allGroupedByTransmissionType)
            {
                Console.WriteLine($"\nTransmission type: {transmissionGroup.TransmissionType}");
                foreach (var car in transmissionGroup.Cars)
                {
                    Console.WriteLine(car);
                }
            }

            // XML serialization

            // All information about all vehicles an engine capacity of which is more than 1.5 liters
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Car>));

            using (FileStream fileStream = new FileStream("carsEngineMoreThan15.xml", FileMode.Create))
            {
                xmlSerializer.Serialize(fileStream, engineCapacityMoreThan15);
            }

            // Engine type, serial number and power rating for all buses and trucks
            // Creating a list of EngineInfo objects and
            // adding LINQ query results to it (engineForAllBusesAndTrucks)
            List<EngineInfo> engineInfoList = new List<EngineInfo>();
            foreach (var car in engineForAllBusesAndTrucks)
            {
                engineInfoList.Add(new EngineInfo(car.Model, car.Year, car.Color, car.Type,
                    car.SerialNumber, car.Power));
            }

            // Serializing the list of EngineInfo objects
            XmlSerializer xmlSerializer2 = new XmlSerializer(typeof(List<EngineInfo>));
            using (FileStream fileStream = new FileStream("engineInfoForBusesAndTrucks.xml", FileMode.Create))
            {
                xmlSerializer2.Serialize(fileStream, engineInfoList);
            }


            // All information about all vehicles, grouped by transmission type
            List<TransmissionInfo> transmissionInfoList = new List<TransmissionInfo>();
            foreach (var transmissionGroup in allGroupedByTransmissionType)
            {
                transmissionInfoList.Add(new TransmissionInfo(transmissionGroup.TransmissionType,
                    transmissionGroup.Cars));
            }
            
            XmlSerializer xmlSerializer3 = new XmlSerializer(typeof(List<TransmissionInfo>));
            using (FileStream fileStream = new FileStream("transmissionInfoForAllVehicles.xml", FileMode.Create))
            {
                xmlSerializer3.Serialize(fileStream, transmissionInfoList);
            }
        }
    }
}