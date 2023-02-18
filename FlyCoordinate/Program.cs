// Practical Task
// Create a "Coordinate" structure that defines the 3D coordinates of some object (positive numbers). 
// Define an IFlyable interface with the FlyTo (new point), GetFlyTime () methods. 
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

namespace FlyCoordinate
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Bird bird = new Bird();
            Airplane airplane = new Airplane();
            Drone drone = new Drone();

            bird.FlyTo(new Coordinate(30, 62, 14));
            bird.GetFlyTime();
            

            airplane.FlyTo(new Coordinate(1023, 352, 602));
            airplane.GetFlyTime();
            
            // Example with negative coordinates
            airplane.FlyTo(new Coordinate(-1023, -352, -602));

            drone.FlyTo(new Coordinate(58, 32, 12));
            drone.GetFlyTime();
        }
    }
}