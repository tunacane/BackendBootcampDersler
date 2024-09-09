namespace Soru9;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { -2, 4, 5, -6, 8, 7, -9, 10, -11, 15, -48, 75, 42 };

        for (int i = 0; i < numbers.Length; i++)
        {
            System.Console.Write(numbers[i] + " ");

            int[] positive = new int[numbers.Length];
            Array.Reverse(positive);

                        
                foreach (var sayi in positive)
                {
                    if (sayi >0)
                 {
                     System.Console.WriteLine(sayi);
                }
                   
                }
        





        }
    }
}