using System;

namespace StoreProductManagement;

public class ElectronicProduct : Product
{
    public ElectronicProduct(string name, int price, int stockQuantity, DateTime updateTime) : base(name, price, stockQuantity)
    {
        UpdateTime = updateTime;
    }


    public DateTime UpdateTime { get; set; }

    public override void DefineProduct()
    {
        base.DefineProduct();
        System.Console.WriteLine($"Update Time: {UpdateTime}");
    }
}
