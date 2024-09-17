using System;

namespace VehicleManagementSystem;

public class Bicycle : Vehicle
{
    public Bicycle(string brand, string model, int year) : base(brand, model, year)
    {
    }

    public override void DefineVehicle()
    {
        base.DefineVehicle();
    }
}
