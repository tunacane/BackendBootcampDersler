using System.Net.WebSockets;

namespace For_Soru10;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("Bir sayı giriniz: ");
        int number1 = int.Parse(Console.ReadLine());

        Console.Write("Bir sayı giriniz: ");
        int number2 = int.Parse(Console.ReadLine());
        int result = 1;

        for (int i = number1; i <= number2; i++)
        {
            result *=i;
        }

        System.Console.WriteLine(result);

    }
}
