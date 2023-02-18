namespace CarPark;

/// <summary>
/// Class <c>Car</c> builds a car object. (Type: PassengerCar, Truck, Bus, or Scooter)
/// </summary>
public class Car : ICar
{
    public Engine Engine { get; set; }
    public Chassis Chassis { get; set; }
    public Transmission Transmission { get; set; }
    public TypeOfCar CarType { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }

    public Car(TypeOfCar carType, string model, int year, string color, Engine engine, Chassis chassis,
        Transmission transmission)
    {
        CarType = carType;
        Model = model;
        Year = year;
        Color = color;
        Engine = engine;
        Chassis = chassis;
        Transmission = transmission;
    }
    
    // Parameterless constructor for XML serialization
    public Car()
    {
        CarType = TypeOfCar.Default;
        Model = "Default";
        Year = 0;
        Color = "Default";
        Engine = new Engine();
        Chassis = new Chassis();
        Transmission = new Transmission();
    }

    public override string ToString()
    {
        return $"\n===== {CarType} =====\n" +
               $"Model: {Model}\n" +
               $"Year: {Year}\n" +
               $"Color: {Color}\n" +
               $"Engine: {Engine}\n" +
               $"Chassis: {Chassis}\n" +
               $"Transmission: {Transmission}";
    }
}