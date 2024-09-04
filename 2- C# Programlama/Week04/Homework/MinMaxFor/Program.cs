namespace MinMaxFor;

class Program
{
    static void Main(string[] args)
    {

        int num;
        int maxNum= int.MinValue;
        int minNum = int.MaxValue;


        for (int i = 0; i < 5; i++)
        {
            Console.Write("Bir sayı giriniz: ");
             num = int.Parse(Console.ReadLine());
          
            if (num> maxNum)
            {
                maxNum = num;
            }
           if (num < minNum)
           {
            minNum = num;
           }
            
        }
        System.Console.WriteLine($"Minimum sayı: {minNum}");
        System.Console.WriteLine($"Maximum sayı: {maxNum}");


    }
}
