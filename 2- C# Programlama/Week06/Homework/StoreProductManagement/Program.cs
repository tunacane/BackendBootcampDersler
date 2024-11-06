using System.Runtime.CompilerServices;

namespace StoreProductManagement;

class Program
{
    static void Main(string[] args)
    {
        FoodProduct foodProduct1 = new FoodProduct("Cheeps", 10, 0, new DateTime(2025,10,10));
        foodProduct1.DefineProduct();

       
        foodProduct1.CheckStock();
        foodProduct1.UpdateStock();

        System.Console.WriteLine("****************************************");

        ElectronicProduct electronicProduct1 = new ElectronicProduct("Phone", 1500, 5000, new DateTime(2024,12,12));
        electronicProduct1.DefineProduct();
        electronicProduct1.CheckStock();
        int quantity = 10;
        electronicProduct1.UpdateStock();






    }
}
