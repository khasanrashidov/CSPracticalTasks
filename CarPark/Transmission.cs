namespace CarPark;

/// <summary>
/// Class <c>Transmission</c> is an abstract class that contains information about the transmission of the car.
/// </summary>
public class Transmission
{
    public string? Type { get; set; } // For XML serialization "set" is public
    public int NumberOfGears { get; set; }
    public string? Manufacturer { get; set; }

    public Transmission(string? type, int numberOfGears, string? manufacturer)
    {
        Type = type;
        NumberOfGears = numberOfGears;
        Manufacturer = manufacturer;
    }
    
    // Parameterless constructor for XML serialization
    public Transmission()
    {
        Type = null;
        NumberOfGears = 0;
        Manufacturer = null;
    }

    public override string ToString()
    {
        return $"\nType: {Type}" +
               $"\nNumber of gears: {NumberOfGears}" +
               $"\nManufacturer: {Manufacturer}";
    }
}