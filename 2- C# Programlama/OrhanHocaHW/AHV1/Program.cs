using System.Diagnostics.CodeAnalysis;

namespace AHV1;

class Program
{
    static void Main(string[] args)
    {
        string[] products = { "Sabun", "Şampuan", "Deodarant", "Elma", "Üzüm" };

        double[] price = { 9, 34, 90, 67, 44 };
        double sum = 0;


        for (int i = 0; i < products.Length; i++)
        {
            Console.WriteLine($"{i + 1}. ürün : {products[i]} / Tutarı : {price[i]} tl'dir)");

        }

        
        while (true)
        {
            
            System.Console.WriteLine("Hangi ürünü almak istiyorsunuz");
            string index = Console.ReadLine();

            if (index == "1")
            {
                sum += price[0];
            }
            else if (index == "2")
            {
                sum += price[1];
            }

            else if (index == "3")
            {
                sum += price[2];
            }

            else if (index == "4")
            {
                sum += price[3];
            }

            else if (index == "5")
            {
                sum += price[4];
            }
            
            
            else
            {
                if (index == "t")
                {
                    System.Console.WriteLine($"Toplam tutar: {sum}");
                    break;
                }
            }
            System.Console.WriteLine($"Toplam tutar: {sum}");


        }


        System.Console.WriteLine(sum);



    }

}
