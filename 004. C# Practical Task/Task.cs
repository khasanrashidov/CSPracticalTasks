// Practical Task
// Create a "Coordinate" structure that defines the 3D coordinates of some object (positive numbers). 
// Define an IFlyable interface with the FlyTo (new point), GetFlyTime (new point) methods. 
// Create classes "Bird", "Airplane", "Drone", which implement this interface 
// and contain at least the field "Current position".
// Use the following assumptions: 
// the bird flies the entire distance at a constant speed in the range of 0-20 km/h (set randomly), 
// the aircraft increases speed by 10 km/h every 10 km of flight from an initial speed of 200 km/h, 
// the drone hovers in the air every 10 minutes of flight for 1 minute. 
// Based on the task, introduce additional restrictions 
// (for example, the impossibility of flying a drone at a distance of more than 1000 km). 
// Describe the methods and restrictions imposed in the comments.

using System;

namespace PracticalTask
{
    class PracticalTask
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Practical Task");
            Console.WriteLine("-------------------------------------------------");
            // create objects
            Bird bird = new Bird();
            Airplane airplane = new Airplane();
            Drone drone = new Drone();

            Coordinate newPoint = new Coordinate();
            // set new point coordinates
            newPoint.x = 10000;
            newPoint.y = 10000;
            newPoint.z = 10000;

            // fly to new point
            bird.FlyTo(newPoint);
            airplane.FlyTo(newPoint);
            drone.FlyTo(newPoint);
            Console.WriteLine("-------------------------------------------------");

            // Calculate fly time
            Console.WriteLine("Bird fly time: " + bird.GetFlyTime(newPoint) + " hours");
            Console.WriteLine("Airplane fly time: " + airplane.GetFlyTime(newPoint) + " hours");
            Console.WriteLine("Drone fly time: " + drone.GetFlyTime(newPoint) + " hours");
            Console.WriteLine("-------------------------------------------------");
      
            Console.ReadKey(); // Console.Readkey() is used to prevent the console from closing immediately

        }
    }

    struct Coordinate
    {
        public int x;
        public int y;
        public int z;
    }

    interface IFlyable
    {
        void FlyTo(Coordinate newPoint);
        double GetFlyTime(Coordinate newPoint);
    }

    class Bird : IFlyable
    {
        public Coordinate CurrentPosition { get; set; }
        public void FlyTo(Coordinate newPoint)
        {
            CurrentPosition = newPoint;
            Console.WriteLine("Bird is flying to new point");
            Console.WriteLine("New point coordinates: " + newPoint.x + " " + newPoint.y + " " + newPoint.z);
        }

        public double GetFlyTime(Coordinate newPoint)
        {
            Random randomNumber = new Random();
            double distance = Math.Sqrt(Math.Pow(newPoint.x, 2) + Math.Pow(newPoint.y, 2) + Math.Pow(newPoint.z, 2));
            // return time = distance / speedBird
            // speedBird = 0-20 km/h
            return distance / randomNumber.Next(0, 20);

        }
    }

    class Airplane : IFlyable
    {
        public Coordinate CurrentPosition { get; set; }

        public void FlyTo(Coordinate newPoint)
        {
            CurrentPosition = newPoint;
            Console.WriteLine("Airplane is flying to new point");
            Console.WriteLine("New point coordinates: " + newPoint.x + " " + newPoint.y + " " + newPoint.z);
        }

        public double GetFlyTime(Coordinate newPoint)
        {
            double distance = Math.Sqrt(Math.Pow(newPoint.x, 2) + Math.Pow(newPoint.y, 2) + Math.Pow(newPoint.z, 2));
            // return time = distance / speedAirplane
            // speedAirplane = 200 + (distance / 10) * 10
            return distance / (200 + (distance / 10) * 10);
        }
    }

    class Drone : IFlyable
    {
        public Coordinate CurrentPosition { get; set; }

        public void FlyTo(Coordinate newPoint)
        {
            CurrentPosition = newPoint;
            Console.WriteLine("Drone is flying to new point");
            Console.WriteLine("New point coordinates: " + newPoint.x + " " + newPoint.y + " " + newPoint.z);
        }

        public double GetFlyTime(Coordinate newPoint)
        {
            double distance = Math.Sqrt(Math.Pow(newPoint.x, 2) + Math.Pow(newPoint.y, 2) + Math.Pow(newPoint.z, 2));
            // return time = distance / speedDrone
            // speedDrone = 1000 + (distance / 1000) * 10
            // drone cannot fly more than 1000 km
            if (distance > 1000)
            {
                Console.WriteLine("*Drone cannot fly more than 1000 km");
                return 0;
            }
            else
            {
                return distance / (1000 + (distance / 1000) * 10);
            }

        }
    }

}
