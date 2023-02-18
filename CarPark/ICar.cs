namespace CarPark;

/// <summary>
/// Interface <c>ICar</c> defines the properties of a car.
/// </summary>
public interface ICar
{
    TypeOfCar CarType { get; set; }
    string Model { get; set; }
    int Year { get; set; }
    string Color { get; set; }
    Engine Engine { get; set; }
    Chassis Chassis { get; set; }
    Transmission Transmission { get; set; }
}