namespace Soru9;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 5, -6, 8, 7, -9, 10, -11, 15, -48, 75, 42 };
        int positiveCount=0;
        int[] positive = new int[numbers.Length];


        for (int i = 0; i < numbers.Length; i++)
        {
            System.Console.Write(numbers[i] + " ");

            if (numbers[i] >0)
            {
                positive[positiveCount]= numbers[i];
                positiveCount++;
            }
           
        }
        System.Console.WriteLine();
        Array.Resize(ref positive, positiveCount);
        Array.Reverse(positive);
       

        foreach (var item in positive)
        {
            System.Console.WriteLine(item);
        }










    }
}