namespace CarParkXml;

// Engine type, serial number and power rating for all buses and trucks
// List of anonymous types cannot be serialized, so we need to create a new class
// and create a list of objects of this class
public class EngineInfo
{
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }
    public string Type { get; set; }
    public string SerialNumber { get; set; }
    public double Power { get; set; }

    public EngineInfo(string model, int year, string color, string type, string serialNumber, double power)
    {
        Model = model;
        Year = year;
        Color = color;
        Type = type;
        SerialNumber = serialNumber;
        Power = power;
    }

    // Default constructor is needed for XML serialization
    public EngineInfo()
    {
        Model = string.Empty;
        Year = 0;
        Color = string.Empty;
        Type = string.Empty;
        SerialNumber = string.Empty;
        Power = 0;
    }
}