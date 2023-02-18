/*
Create a program which manages a car park. 
For this purpose, you need to implement the next entities as separate classes: 
"Engine" (includes the next fields: power, volume, type, serial number), 
"Chassis" (wheels number, number, permissible load), 
"Transmission" (type, number of gears, manufacturer).
Implement entities "Passenger car", "Truck", "Bus", "Scooter" 
using class described previously (distinguished by unique fields) 
and provide the output of complete information about objects of these types.
*/

using System;

namespace CarPark
{
    public class CarPark
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Car Park");

            Car passengerCar = new Car(TypeOfCar.PassengerCar, "BMW X5", 2019, "Black",
                new Engine(300, 3.0, "Diesel", "1234567890"),
                new Chassis(4, "1234567890", 2000),
                new Transmission("Automatic", 6, "BMW"));

            Car truck = new Car(TypeOfCar.Truck, "Volvo FH", 2018, "White",
                new Engine(500, 5.0, "Diesel", "0987654321"),
                new Chassis(6, "0987654321", 3000),
                new Transmission("Automatic", 6, "Volvo"));

            Car bus = new Car(TypeOfCar.Bus, "Mercedes-Benz Citaro", 2017, "Blue",
                new Engine(200, 2.0, "Diesel", "1234567890"),
                new Chassis(6, "1234567890", 2000),
                new Transmission("Automatic", 6, "Mercedes-Benz"));

            Car scooter = new Car(TypeOfCar.Scooter, "Yamaha X-Max", 2016, "Red",
                new Engine(100, 1.0, "Gasoline", "0987654321"),
                new Chassis(2, "0987654321", 100),
                new Transmission("Automatic", 6, "Yamaha"));

            Console.WriteLine(passengerCar);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
            Console.WriteLine(scooter);
        }
    }
}