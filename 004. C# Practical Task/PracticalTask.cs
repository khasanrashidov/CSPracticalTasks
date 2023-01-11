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
    /// <summary>
    /// Class PracticalTask provides the main entry point for the application.
    /// </summary>
    /// <remarks>
    /// Class PracticalTask is used to associate the objects of Bird, Airplane, Drone classes
    /// with the IFlyable interface methods in the main method to calculate the time of flight to the new point.
    /// </remarks>
    class PracticalTask
    {
        /// <summary>
        /// The main method is the entry point for the application.
        /// </summary>
        /// <param name="args">The command-line arguments.</param>
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
}
