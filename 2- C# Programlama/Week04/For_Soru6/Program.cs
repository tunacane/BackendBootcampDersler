using System.Xml.XPath;

namespace For_Soru6;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("10'dan büyük bir sayı giriniz: ");
        int number = int.Parse(Console.ReadLine());
        

        for (int i = 1; i < number; i++)
        {

            System.Console.WriteLine($"{i}^2 : {Math.Pow(i, 2)}");
        }
       
    }
}
