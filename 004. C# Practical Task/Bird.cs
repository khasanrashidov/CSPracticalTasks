using System;

/// <summary>
/// The Bird class provides the bird object and implements the IFlyable interface.
/// </summary>
class Bird : IFlyable
{
    public Coordinate CurrentPosition { get; set; }

    /// <summary>
    /// FlyTo method provides the new point.
    /// </summary>
    public void FlyTo(Coordinate newPoint)
    {
        CurrentPosition = newPoint;
        Console.WriteLine("Bird is flying to new point");
        Console.WriteLine("New point coordinates: " + newPoint.x + " " + newPoint.y + " " + newPoint.z);
    }

    /// <summary>
    /// GetFlyTime method provides the time of flight to the new point.
    /// </summary>
    /// <param name="newPoint">The new point.</param>
    public double GetFlyTime(Coordinate newPoint)
    {
        Random randomNumber = new Random();
        double distance = Math.Sqrt(Math.Pow(newPoint.x, 2) + Math.Pow(newPoint.y, 2) + Math.Pow(newPoint.z, 2));
        // return time = distance / speedBird
        // speedBird = 0-20 km/h
        /// <returns>Time of flight to the new point.</returns>
        return distance / randomNumber.Next(0, 20);

    }
}