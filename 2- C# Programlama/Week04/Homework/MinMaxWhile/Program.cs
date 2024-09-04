using System.Data;

namespace MinMaxWhile;

class Program
{
    static void Main(string[] args)
    {
   
      int maxNum = int.MinValue;
      int minNum = int.MaxValue;

       int i=0;

       while (i<5)
       {
        System.Console.WriteLine("Bir sayı giriniz: ");
        int num= int.Parse(Console.ReadLine());
        i++;

        if (num > maxNum)
        {
            maxNum = num;
        }
        if (num < minNum)
        {
            minNum =num;
        }
       }
        System.Console.WriteLine($"Minimum sayı: {minNum}");
        System.Console.WriteLine($"Maximum sayı: {maxNum}");
    }
}
