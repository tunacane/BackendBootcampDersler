using System;

namespace StoreProductManagement;

public class FoodProduct : Product
{
    public FoodProduct(string name, int price, int stockQuantity, DateTime expirationDate) : base(name, price, stockQuantity)
    {
        ExpirationDate = expirationDate;
    }

    public DateTime ExpirationDate { get; set; }

    public override void DefineProduct()
    {
        base.DefineProduct();
        System.Console.WriteLine($"Expiration Date : {ExpirationDate}");
    }
}
