using System.Globalization;
using System.Xml.XPath;

namespace While_Soru1;

class Program
{
    static void Main(string[] args)
    {

        int number;
        int result = 0;

        while (true)
        {
            Console.Write("Bir sayı giriniz : ");
            number = int.Parse(Console.ReadLine());

            result += number;

            if (number ==0)
            {
                break;
            }
        }


        System.Console.WriteLine(result);
    }
}
