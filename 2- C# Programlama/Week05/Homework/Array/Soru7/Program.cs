namespace Soru7;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int[] numbers = new int[50];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rnd.Next(1, 500);
            System.Console.WriteLine(numbers[i] + " ");
        }

        System.Console.WriteLine();
        
        foreach (var even in numbers)
        {
            if (even%2==0)
            {
                System.Console.WriteLine(even+" ");
            }
        }

    }
}
