using System.Xml.XPath;

namespace For_Soru2;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir sayı giriniz: ");
        int number = int.Parse(Console.ReadLine());
        int result =0;

        for (int i = 0; i < number; i++)
        {
           result = i*i*i;
            System.Console.WriteLine($"{i}'nin küpü : {result}");
        }
   
    }
}
