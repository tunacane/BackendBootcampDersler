using System;

namespace VehicleManagementSystem;

public class Car : Vehicle
{
    public Car(string brans, string model, int year, int numberOfDoors) : base(brans, model, year)
    {
        NumberOfDoors = numberOfDoors;
    }

    public int NumberOfDoors { get; set; }

    public override void DefineVehicle()
    {
        base.DefineVehicle();
        System.Console.WriteLine($"NumberOfDoors: {NumberOfDoors}");
    }
}
