using System;

/// <summary>
/// The Airplane class provides the airplane object and implements the IFlyable interface.
/// </summary>
class Airplane : IFlyable
{
    public Coordinate CurrentPosition { get; set; }

    /// <summary>
    /// FlyTo method provides the new point.
    /// </summary>
    public void FlyTo(Coordinate newPoint)
    {
        CurrentPosition = newPoint;
        Console.WriteLine("Airplane is flying to new point");
        Console.WriteLine("New point coordinates: " + newPoint.x + " " + newPoint.y + " " + newPoint.z);
    }

    /// <summary>
    /// GetFlyTime method provides the time of flight to the new point.
    /// </summary>
    /// <param name="newPoint">The new point.</param>
    public double GetFlyTime(Coordinate newPoint)
    {
        double distance = Math.Sqrt(Math.Pow(newPoint.x, 2) + Math.Pow(newPoint.y, 2) + Math.Pow(newPoint.z, 2));
        // return time = distance / speedAirplane
        // speedAirplane = 200 + (distance / 10) * 10
        /// <returns>Time of flight to the new point.</returns>
        return distance / (200 + (distance / 10) * 10);
    }
}