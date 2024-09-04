namespace For_Soru4;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir sayı giriniz: ");
        int number = int.Parse(Console.ReadLine());

        for (int i = 0; i <= number ; i++)
        {
            
            for (int j = number ; j>0; j--)
            {
                System.Console.Write(" ");
            }
             for (int k = 1; k <= i+1; k++) {
                System.Console.Write("*");
            } 
            System.Console.WriteLine();

        }
    }
}
