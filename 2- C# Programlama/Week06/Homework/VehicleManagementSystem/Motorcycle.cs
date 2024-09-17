using System;

namespace VehicleManagementSystem;

public class Motorcycle : Vehicle
{
    public Motorcycle(string brans, string model, int year, bool hasSidecar) : base(brans, model, year)
    {
        HasSidecar = hasSidecar;
    }

    public bool HasSidecar { get; set; }
   

    
    public override void DefineVehicle()
    {
        base.DefineVehicle();
       
    }

}
