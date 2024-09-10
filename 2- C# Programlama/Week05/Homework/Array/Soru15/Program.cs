namespace Soru15;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 21, 3, 4, 5, 63, 7, 8, 12, 56, 47, 41, 15, 13, 78, 25 };
       
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i]%2==1)
            {
                System.Console.Write(numbers[i]+" ");
            }
            Array.Sort(numbers);
        }
        int[] newNumbers = new int[numbers.Length];
        
    }
}
