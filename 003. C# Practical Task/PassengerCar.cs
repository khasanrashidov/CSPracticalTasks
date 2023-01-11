using System;

// Class PassengerCar
/// <summary>
/// Class PassengerCar provides information about the passenger car
/// </summary>
class PassengerCar
{
    public string Brand;
    public string Model;
    public string Color;
    public int Year;
    public Engine Engine;
    public Chassis Chassis;
    public Transmission Transmission;

    // Constructor with parameters
    /// <summary>
    /// Constructor with parameters: brand, model, color, year, engine, chassis, transmission
    /// </summary>
    /// <param name="brand">Brand of the car</param>
    /// <param name="model">Model of the car</param>
    /// <param name="color">Color of the car</param>
    /// <param name="year">Year of the car</param>
    /// <param name="engine">Engine of the car</param>
    /// <param name="chassis">Chassis of the car</param>
    /// <param name="transmission">Transmission of the car</param>
    /// <see cref="Engine"/>
    /// <see cref="Chassis"/>
    /// <see cref="Transmission"/>
    public PassengerCar(string brand, string model, string color, int year, Engine engine, Chassis chassis, Transmission transmission)
    {
        Brand = brand;
        Model = model;
        Color = color;
        Year = year;
        Engine = engine;
        Chassis = chassis;
        Transmission = transmission;
    }

}