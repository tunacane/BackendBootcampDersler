namespace For_Soru3;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir sayı giriniz: ");
        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i < number; i++)
        {
            if (number%i==0){
                System.Console.WriteLine($"{number}'ın tam bölenleri {i}'dir.");
            }
         
           
        }
    }
}
