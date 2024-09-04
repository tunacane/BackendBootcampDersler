namespace While_Soru8;

class Program
{
    static void Main(string[] args)
    {
        int number=1;
        int numberCount = 0;
        int count = 0;
        double numOrt=0;


        while (true)
        {
           System.Console.Write("Bir sayı giriniz: "); 
           number = int.Parse(Console.ReadLine());
           
          if (number > 100)
          {
            break;

          }

            numberCount++;

            count += number;
             numOrt = count / numberCount;

        }
        System.Console.WriteLine(numberCount);
        System.Console.WriteLine(count);
        System.Console.WriteLine(numOrt);


    }
}
