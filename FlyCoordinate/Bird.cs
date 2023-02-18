using System;

namespace FlyCoordinate;

/// <summary>
/// Class Bird implements IFlyable interface and
/// calculates the time of flight and the distance covered by the bird.
/// </summary> 
public class Bird : IFlyable
{
    public Coordinate CurrentPosition { get; set; } = new Coordinate(0, 0, 0);
    public Coordinate NewPoint { get; set; }

    public void FlyTo(Coordinate newPoint)
    {
        // newPoint coordinates must be positive
        if (newPoint.X < 0 || newPoint.Y < 0 || newPoint.Z < 0)
        {
            Console.WriteLine("Destination coordinates must be positive.");
            Console.WriteLine($"Bird didn't fly to {newPoint}.\n");
            return;
        }
        
        NewPoint = newPoint;
        Console.WriteLine($"Bird flies to {newPoint}.");
    }

    public double GetFlyTime()
    {
        Random random = new Random();
        int speed = random.Next(0, 20);

        double distance = Math.Sqrt(Math.Pow(NewPoint.X - CurrentPosition.X, 2) +
                                    Math.Pow(NewPoint.Y - CurrentPosition.Y, 2) +
                                    Math.Pow(NewPoint.Z - CurrentPosition.Z, 2));
        
        if (distance > 160)
        {
            Console.WriteLine("The bird can't fly more than 100 km.");
            return 0;
        }

        double flyTime = distance / speed;

        Console.WriteLine($"Bird flew to {NewPoint} covering {distance:0.00} km in {flyTime:0.00} hours.\n");

        return flyTime;
    }
}