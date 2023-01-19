using System;

// Class Scooter
/// <summary>
/// Class Scooter provides information about the scooter
/// </summary>
public class Scooter
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
    public Scooter(string brand, string model, string color, int year, Engine engine, Chassis chassis, Transmission transmission)
    {
        Brand = brand;
        Model = model;
        Color = color;
        Year = year;
        Engine = engine;
        Chassis = chassis;
        Transmission = transmission;
    }
    // parameterless constructor
    public Scooter()
    {
        Brand = "Some brand";
        Model = "Some model";
        Color = "Some color";
        Year = 2000;
        Engine = new Engine();
        Chassis = new Chassis();
        Transmission = new Transmission();
    }

}