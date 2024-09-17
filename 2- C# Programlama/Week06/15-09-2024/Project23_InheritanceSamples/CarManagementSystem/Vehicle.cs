using System;
using System.ComponentModel;

/*  1)    Vahicle adında bir class yaratn
        -Brand, Model, Year property leri olsun
        -Start ve stop metotları olsun
        -Bir vehicle yaratılırken brand, model ve year bilgileri verilmek zorunda olsun


2) Car adı bir class oluşturun her car bir vehicle dir. 
   Ek olarak CountOfDoors adlı bir property olsun ve yaratılırken verilmek zorunda olsun
   OpenTrunk adlı bir metodu olsun

3) .Motorcyle adlı bir class oluşturun
    Her MotorCyle bir vehicledir
    Ek olarak CoolingSystem adlı bir propertysi olsun va yaratılırken verilmek zorunda olsun*/


namespace Project23_InheritanceSamples.CarManagementSystem;

public abstract class Vehicle // abstract program cs te new vehicle yazılmasına engel oldu
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
    public int MyProperty { get; set; }

    public void Start()
    {
        System.Console.WriteLine($"{Brand} çalıştı.");
    }

    public void Stop()
    {
        System.Console.WriteLine($"{Brand} stop etti.");
    }

    public virtual void VehicleDefine()
    {
        System.Console.WriteLine($"Brand: {Brand}\nModel: {Model}\nYear: {Year}");
    }

    public abstract void GetSignal(); // abstract yazılınca car ya da motorda altına özellikle açıklama yazılmalı burdan miras alamaz Car'a gidip implement edilmeli
}
