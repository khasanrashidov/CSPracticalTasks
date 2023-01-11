using System;

/// <summary>
/// The Drone class provides the drone object and implements the IFlyable interface.
/// </summary>
class Drone : IFlyable
{
    public Coordinate CurrentPosition { get; set; }

    /// <summary>
    /// FlyTo method provides the new point.
    /// </summary>
    public void FlyTo(Coordinate newPoint)
    {
        CurrentPosition = newPoint;
        Console.WriteLine("Drone is flying to new point");
        Console.WriteLine("New point coordinates: " + newPoint.x + " " + newPoint.y + " " + newPoint.z);
    }

    /// <summary>
    /// GetFlyTime method provides the time of flight to the new point.
    /// </summary>
    /// <param name="newPoint">The new point.</param>
    public double GetFlyTime(Coordinate newPoint)
    {
        double distance = Math.Sqrt(Math.Pow(newPoint.x, 2) + Math.Pow(newPoint.y, 2) + Math.Pow(newPoint.z, 2));
        // return time = distance / speedDrone
        // speedDrone = 1000 + (distance / 1000) * 10
        // drone cannot fly more than 1000 km
        if (distance > 1000)
        {
            Console.WriteLine("*Drone cannot fly more than 1000 km");
            /// <returns>Time of flight as 0 if distance more than 1000 km.</returns>
            return 0;
        }
        else
        {
            /// <returns>Time of flight to the new point.</returns>
            return distance / (1000 + (distance / 1000) * 10);
        }

    }
}