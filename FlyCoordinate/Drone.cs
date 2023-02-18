using System;

namespace FlyCoordinate;

/// <summary>
/// Class Drone implements IFlyable interface and
/// calculates the time of flight and the distance covered by the drone.
/// </summary>
public class Drone : IFlyable
{
    public Coordinate CurrentPosition { get; set; } = new Coordinate(0, 0, 0);
    public Coordinate NewPoint { get; set; }

    public void FlyTo(Coordinate newPoint)
    {
        // newPoint coordinates must be positive
        if (newPoint.X < 0 || newPoint.Y < 0 || newPoint.Z < 0)
        {
            Console.WriteLine("Destination coordinates must be positive.");
            Console.WriteLine($"Drone didn't fly to {newPoint}.\n");
            return;
        }

        NewPoint = newPoint;
        Console.WriteLine($"Drone flies to {newPoint}.");
    }

    public double GetFlyTime()
    {
        double distance = Math.Sqrt(Math.Pow(NewPoint.X - CurrentPosition.X, 2) +
                                    Math.Pow(NewPoint.Y - CurrentPosition.Y, 2) +
                                    Math.Pow(NewPoint.Z - CurrentPosition.Z, 2));
        
        double storeDistance = distance;

        // The drone can't fly more than 1000 km
        if (distance > 1000)
        {
            Console.WriteLine("The drone can't fly more than 1000 km.");
            return 0;
        }

        double flyTime = 0;
        double speed = 100;
        int time = 0;

        while (distance > 0)
        {
            if (distance > 10)
            {
                flyTime += 10 / speed;
                distance -= 10;
                time += 10;

                // The drone hovers in the air every 10 minutes of flight for 1 minute
                if (time == 10)
                {
                    flyTime += 1;
                    time = 0;
                }
            }
            else
            {
                flyTime += distance / speed;
                distance = 0;
            }
        }

        Console.WriteLine($"Drone flew to {NewPoint} covering {storeDistance:0.00} km in {flyTime:0.00} hours.\n");

        return flyTime;
    }
}