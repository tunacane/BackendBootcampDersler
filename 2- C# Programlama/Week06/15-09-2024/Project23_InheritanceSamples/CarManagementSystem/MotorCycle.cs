using System;

namespace Project23_InheritanceSamples.CarManagementSystem;

public class MotorCycle : Vehicle
{
    public MotorCycle(string brand, string model, int year, string coolingSystem) : base(brand, model, year)
    {
        CoolingSystem = coolingSystem;
    }

    public string CoolingSystem { get; set; }

    public override void GetSignal()
    {
        throw new NotImplementedException();
    }

    public override void VehicleDefine()
    {
        base.VehicleDefine();
        System.Console.WriteLine($"Soğutma sistemi: {CoolingSystem}");
    }
}
