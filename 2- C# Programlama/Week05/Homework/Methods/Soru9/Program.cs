namespace Soru9;
/*Bir sayı dizisi alıp, bu listedeki en küçük sayıyı döndüren bir metot yazın.*/ 
class Program
{
    static int MinNumber(int[] numbers){

        Array.Sort(numbers);
        int min = numbers[0];
        return min;
        

    }

    static void Main(string[] args)
    {
        System.Console.Write("Dizinin boyutunu giriniz: ");
        int lenght =0;
        int[] numbers = new int[lenght];


        for (int i = 0; i < lenght; i++)
       {
            Console.WriteLine("Bir sayı giriniz: ");
            int number = int.Parse(Console.ReadLine());

        }   
            int min = MinNumber(numbers);
            System.Console.WriteLine($"Minimum sayı: {min}");
           
        }
        
    }

