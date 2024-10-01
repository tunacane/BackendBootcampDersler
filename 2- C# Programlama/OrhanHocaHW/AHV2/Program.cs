using System.Diagnostics;

namespace AHV2;

class Program
{
    static void Main(string[] args)
    {
        string[] products = { "kalem", "kağıt", "defter", "boya", "kitap", "kulaklık", "etiket", "mouse", "bardak", "dergi" };

        int[] price = { 10, 20, 30,40,50,60,70,80,90,5 };

        for (int i = 0; i < products.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {products[i]} - {price[i]} TL");
        }
        
        System.Console.WriteLine("Kaç adet ürün satın almak istiyorsunuz: ");
        int count=int.Parse(Console.ReadLine());
   
        int sum =0;
        
        for (int i = 0; i < count; i++)
        {
            System.Console.WriteLine("Hangi ürünleri almak istiyorsunuz (isim giriniz): ");
            string choise = Console.ReadLine().ToLower();
         // int choice1 = int.Parse(Console.ReadLine());

            int index= Array.IndexOf(products , choise);

            if (index >=0)
            {
                sum += price[index];
            }

            
        }
        System.Console.WriteLine($"Ürünlerinizin toplam fiyatı: {sum} TL'dir.");

        
    }
}
