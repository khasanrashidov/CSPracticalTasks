using CarPark; 
using System.Collections.Generic;

namespace CarParkXml;

// All information about all vehicles, grouped by transmission type
// List of anonymous types cannot be serialized, so we need to create a new class
// and create a list of objects of this class with a list of cars
public class TransmissionInfo
{
    public string TransmissionType { get; set; }
    public List<Car> Cars { get; set; }

    public TransmissionInfo(string transmissionType, List<Car> cars)
    {
        TransmissionType = transmissionType;
        Cars = cars;
    }

    // Default constructor is needed for XML serialization
    public TransmissionInfo()
    {
        TransmissionType = string.Empty;
        Cars = new List<Car>();
    }
}