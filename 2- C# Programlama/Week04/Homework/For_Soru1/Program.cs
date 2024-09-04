using System.Xml.XPath;

namespace For_Soru1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir sayı giriniz: ");

        int number = int.Parse(Console.ReadLine());
        int result=0;


        for (int i = 1; i <= number; i++)
        {
            result +=i;
        }
    
        
         System.Console.WriteLine($"Sayıların toplamı: {result}");
    }
}
