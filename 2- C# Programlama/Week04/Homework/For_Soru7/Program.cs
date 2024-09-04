using System.Globalization;
using System.Xml.XPath;

namespace For_Soru7;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("10'dan büyük bir sayı giriniz: ");
        int number = int.Parse(Console.ReadLine());
        int result =0;

        if (number < 10)
        {
            System.Console.WriteLine("Geçersiz veri girdiniz.");
        }

        for (int i = 1; i < number; i++)  
             {
            if (i %2 == 0)
            {
                result += i;
                System.Console.WriteLine($"Sayıların toplamı: {result}");
            }
            
        }
    }
}
