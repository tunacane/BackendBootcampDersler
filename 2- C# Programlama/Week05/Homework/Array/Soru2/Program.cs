using System.Net.WebSockets;

namespace Soru2;
// Klavyeden girilen 10 sayıyı bir diziye atayın. Bu sayılardan çift olanları for döngüsü kullanarak ayrı bir diziye aktarın. Ardından bu çift sayı dizisini küçükten büyüğe sıralayın.
class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int[] numbers = new int[10];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rnd.Next(1,50);
            System.Console.Write(numbers[i]+ " ");
        }

        System.Console.WriteLine();

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0)
            {
             
             System.Console.Write(numbers[i]+" ");
                Array.Sort(numbers);
            }
       //sort ettikten sonra yazdıramadım başka diziye aktarmadın
         

        
        }
        



        // int[] evenNumber = new int[numbers.Length];
        //Array.Copy(numbers, evenNumber, numbers.Length); ;
        // foreach (var even in evenNumber)
        // {
        //     System.Console.Write(even + " ");
        // }



    }
}
