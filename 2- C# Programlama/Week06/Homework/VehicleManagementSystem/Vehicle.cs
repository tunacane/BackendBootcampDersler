using System;


public class Vehicle
{
    public Vehicle(string brand, string model, int year)
    {
        Brand = brand;
        Model = model;
        Year = year;
    }

    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public virtual void DefineVehicle(){
        System.Console.WriteLine($"Brand: {Brand}\nModel: {Model}\nYear: {Year}");
    }
}
