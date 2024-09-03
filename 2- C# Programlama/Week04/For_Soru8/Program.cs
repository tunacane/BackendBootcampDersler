namespace For_Soru8;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir sayı giriniz: ");
        int number = int.Parse(Console.ReadLine());

        for (int i = number; i > 1; i--)
        {
            System.Console.WriteLine($"{i}^2 : {Math.Pow(i , 2)}");
        }


    }
}
