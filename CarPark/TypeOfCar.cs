namespace CarPark;

/// <summary>
/// Enum <c>TypeOfCar</c> defines the type of car.
/// It protects the user from entering incorrect car type.
/// </summary>
public enum TypeOfCar : int
{
    Default = 0, // For parameterless constructor (and for XML serialization)
    PassengerCar = 1,
    Truck = 2,
    Bus = 3,
    Scooter = 4
}