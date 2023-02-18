namespace CarPark;

/// <summary>
/// Class <c>Chassis</c> is an abstract class that contains information about the chassis of the car.
/// </summary>
public class Chassis
{
    public int WheelsNumber { get; set; } // For XML serialization "set" is public
    public string? Number { get; set; }
    public double PermissibleLoad { get; set; }

    public Chassis(int wheelsNumber, string? number, double permissibleLoad)
    {
        WheelsNumber = wheelsNumber;
        Number = number;
        PermissibleLoad = permissibleLoad;
    }

    // Parameterless constructor for XML serialization
    public Chassis()
    {
        WheelsNumber = 0;
        Number = null;
        PermissibleLoad = 0;
    }

    public override string ToString()
    {
        return $"\nWheels number: {WheelsNumber}" +
               $"\nNumber: {Number}" +
               $"\nPermissible load: {PermissibleLoad}";
    }
}