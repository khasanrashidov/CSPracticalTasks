using System;

// Class Truck
/// <summary>
/// Class Truck provides information about the truck
/// </summary>
class Truck
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
    public Truck(string brand, string model, string color, int year, Engine engine, Chassis chassis, Transmission transmission)
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