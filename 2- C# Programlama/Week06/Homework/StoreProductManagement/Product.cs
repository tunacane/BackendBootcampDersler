using System;

namespace StoreProductManagement;

public class Product
{
    public Product(string name, int price, int stockQuantity)
    {
        Name = name;
        Price = price;
        StockQuantity = stockQuantity;
    }

    
    

    public string Name { get; set; }
    public int Price { get; set; }
    public int StockQuantity { get; set; }

    int quantity;
    public void CheckStock(){
     

        if (StockQuantity == 0)
        {
            System.Console.WriteLine("Stokta ürün kalmamıştır, yeni ürün girişi yapınız.");
        }
       
    }

    public void UpdateStock(){

        if (StockQuantity == 0)
        {
           StockQuantity += quantity;
        }

        System.Console.WriteLine($"Güncel stok sayısı: {StockQuantity}");

    }

    public virtual void DefineProduct(){
        System.Console.WriteLine($"Product Name: {Name}\n Price: {Price}\n Stock Quantity: {StockQuantity}");
    }

}
