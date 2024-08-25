namespace Homework01;

class Program
{
    static void Main(string[] args)
    {
       
        System.Console.WriteLine("Sınav puanınızı giriniz: ");
        int point = int.Parse(Console.ReadLine());
        byte resultPoint = 0;

        if (point < 45)
        {
            resultPoint = 1;
        }
        else if (point < 55)
        {
            resultPoint = 2;
        }
        else if (point < 70)
        {
            resultPoint = 3;
        }
        else if (point < 85)
        {
            resultPoint = 4;
        }
        else if (point <= 100)
        {
            resultPoint = 5;
        }
        else
        {
            System.Console.WriteLine("Geçerli bir not giriniz");
        }

        System.Console.WriteLine($"Sınav puanınız: {resultPoint}");
    }
}
