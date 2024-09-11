namespace For_Soru9;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir sayı giriniz: ");
        int number = int.Parse(Console.ReadLine());

        bool isPrime = true;

        for (int i = 2; i <= number-1; i++)
        {
            if (number %i ==0)
            {
                isPrime = false;
                System.Console.WriteLine($"{number}: asal değildir.");
                break;
            }
        }
        System.Console.WriteLine(number);

        
    }
}
