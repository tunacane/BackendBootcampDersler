using System;

namespace Project23_InheritanceSamples.CarManagementSystem;

public class Car : Vehicle
{
    public Car(string brand, string model, int year, int countOfDoors) : base(brand, model, year)
    {
        CountOfDoors = countOfDoors;
    }

    public int CountOfDoors { get; set; }

    public void OpenTrunk(){
        System.Console.WriteLine($"Arabanın üstü açıldı.");
    }

    public void CloseTrunk()
    {
        System.Console.WriteLine($"Arabanın üstü kapandı.");
    }

    public override void VehicleDefine()
    {
        base.VehicleDefine();
        System.Console.WriteLine($"Kapı sayısı: {CountOfDoors} ");

    }

    public override void GetSignal()
    {
        throw new NotImplementedException();
    }
}
