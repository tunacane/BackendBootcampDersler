namespace Project11_Loops;

class Program
{
    static void Main(string[] args)
    {
        #region For

        /*   for(int count =1; count <=5 ; count = count+1){

              System.Console.WriteLine("Hello world");

          } */

        // i++ = > i = i+1
        // i= i+3 => i+=3

        /*     for (int i = 1; i <= 5; i++)
            {

                System.Console.WriteLine("Hello world");
            } */

        //ekrana 1-10 arasındaki sayıları yazdıran programı hazırlayınız
        /* string message;
        int count = 1;

                for (int i = 100; i <= 200; i++)
                {
                    message =$"Sayı {count++}: {i}";
                    System.Console.WriteLine(message);
                } */


        /*  for (int i = 2; i < 10; i+=2)
         {
             System.Console.WriteLine(i);
         } */

 // ************************************************

        /*  for (int i = 1; i < 10; i++)
         {
             if (i%2 ==0)
             {
                 System.Console.WriteLine(i);
             }
         } */

     // ************************************************

        /* kuulanıcıdan iki sayı alın. Bu iki sayı arasındaki çift sayıları ekrana yazdırın

       System.Console.WriteLine("Alt sınırı giriniz: ");
        int min =int.Parse(Console.ReadLine());
        min = min %2 ==0 ? min : min+1;
        System.Console.WriteLine("Üst sınırı giriniz: ");
        int max = int.Parse(Console.ReadLine());

        for (int i = min ; i < max ; i += 2)
        {
            System.Console.WriteLine(i);
        }*/

      // ************************************************

        // kullanıcının girdiği sayının faktörüiyelilni hesaplayan programı yazınız

        /* System.Console.WriteLine("Bir sayı giriniz: ");
        int value = int.Parse(Console.ReadLine());
        int factorial = 1;
        
        for (int i = 2; i <= value; i++)
        {
            //  factorial = factorial *1;
             factorial *=i;
        }
        System.Console.WriteLine($"{value}! = {factorial}"); */
/* 
        System.Console.WriteLine("Bir sayı giriniz: ");
        int value = int.Parse(Console.ReadLine());
        int factorial = value;

        for (int i = value-1 ; i > 1; i--)
        {
            //  factorial = factorial *1;
            factorial *= i;
        }
        System.Console.WriteLine($"{value}! = {factorial}"); */











        #endregion
    
    #region while

  /*   int i =1;
    while (i <= 5)
    {
        System.Console.WriteLine("Hello world");
        i++;
    } */

    /*  int total = 0;
    string input ="";

    while (input !="exit")
    {
        System.Console.WriteLine("Sayı (çıkış için exit) giriniz: ");
        input = Console.ReadLine();

        if (int.TryParse(input, out int inputNumber))
        {
            total += inputNumber;
        }
        else if (input != "exit")
        {
            System.Console.WriteLine("Lütfen geçerli bir değer giriniz");
        }
    }
    System.Console.WriteLine($"Toplam: {total}");
  */

        // kullanıcıdan arka arkaya alınacak sayıları toplayan kodu hazırlayınız. Ancak kullanıcnın girdiği sayıların toplamı 100'den büyük ya da eşitse programı sona erdirip toplamı ekrana yazsın

       /*  int total=0;
        string input ="";

        while (total <= 100)
        {
            System.Console.WriteLine("Sayı giriniz: ");
            input = Console.ReadLine();

            if (int.TryParse(input, out int newInput))
            {
                total+= newInput;
            }
            else if (input != "exit")
            {
                System.Console.WriteLine("Geçerli veri giriniz");
            }
         
        }
        System.Console.WriteLine(total);
     */
    #endregion
    
    
    
    }
}
