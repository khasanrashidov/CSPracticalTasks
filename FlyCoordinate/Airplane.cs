using System;

namespace FlyCoordinate;

/// <summary>
/// Class Airplane implements IFlyable interface and
/// calculates the time of flight and the distance covered by the airplane.
/// </summary>
public class Airplane : IFlyable
{
    public Coordinate CurrentPosition { get; set; } = new Coordinate(0, 0, 0);
    public Coordinate NewPoint { get; set; }

    public void FlyTo(Coordinate newPoint)
    {
        // newPoint coordinates must be positive
        if (newPoint.X < 0 || newPoint.Y < 0 || newPoint.Z < 0)
        {
            Console.WriteLine("Destination coordinates must be positive.");
            Console.WriteLine($"Airplane didn't fly to {newPoint}.\n");
            return;
        }
        
        NewPoint = newPoint;
        Console.WriteLine($"Airplane flies to {newPoint}.");
    }

    public double GetFlyTime()
    {
        double distance = Math.Sqrt(Math.Pow(NewPoint.X - CurrentPosition.X, 2) +
                                    Math.Pow(NewPoint.Y - CurrentPosition.Y, 2) +
                                    Math.Pow(NewPoint.Z - CurrentPosition.Z, 2));
        
        // The airplane can't fly more than 10000 km
        if (distance > 10000)
        {
            Console.WriteLine("The airplane can't fly more than 10000 km.");
            return 0;
        }
        
        double storeDistance = distance;

        double flyTime = 0;
        double speed = 200;

        while (distance > 0)
        {
            if (distance > 10)
            {
                flyTime += 10 / speed;
                distance -= 10;
                speed += 10;
            }
            else
            {
                // if distance < 10
                // then just divide the rest of the distance by the current speed
                // and add the result to the total time
                flyTime += distance / speed;
                distance = 0;
            }
        }

        Console.WriteLine($"Airplane flew to {NewPoint} covering {storeDistance:0.00} km in {flyTime:0.00} hours.\n");

        return flyTime;
    }
}