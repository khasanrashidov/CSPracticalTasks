namespace CarPark;

/// <summary>
/// Class <c>Engine</c> is an abstract class that contains information about the engine of the car.
/// </summary>
public class Engine
{
    public double Power { get; set; } // For XML serialization "set" is public
    public double Volume { get; set; }
    public string? Type { get; set; }
    public string? SerialNumber { get; set; }

    public Engine(double power, double volume, string? type, string? serialNumber)
    {
        Power = power;
        Volume = volume;
        Type = type;
        SerialNumber = serialNumber;
    }

    // Parameterless constructor for XML serialization
    public Engine()
    {
        Power = 0;
        Volume = 0;
        Type = null;
        SerialNumber = null;
    }

    public override string ToString()
    {
        return $"\nPower: {Power}" +
               $"\nVolume: {Volume}" +
               $"\nType: {Type}" +
               $"\nSerial number: {SerialNumber}";
    }
}